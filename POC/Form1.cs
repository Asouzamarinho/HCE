using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TotalTag.Common.Model;
using TotalTag.Common.Tools;
using TotalTag.Monitor.Config.Bll;
using TotalTag.Monitor.Config.Enum;
using TotalTag.Monitor.Core.Detection;

namespace POC
{
    public partial class Form1 : Form
    {
        private BindingList<Evento> _eventos;
        private Provider _provider;

        public string RootPath
        {
            get
            {
                string path = Assembly.GetExecutingAssembly().Location;
                var directory = Path.GetDirectoryName(path);
                return directory;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTagStates()
        {
            var tagConfig = File.ReadAllLines(Path.Combine(RootPath, "Resources", "tag_epcs.txt"))
                .Select(_ => _.Split(new[] {"\t"}, StringSplitOptions.RemoveEmptyEntries))
                .Where(_ => _.Length >= 2)
                .ToDictionary(_ => _[1].Replace("-", ""), _ => _[0]);
            _provider = new Provider(tagConfig);
            _provider.Eventos += ProviderOnEventos;
        }

        private void ProviderOnEventos(object sender, EventosEventArgs args)
        {
            foreach (var evento in args.Eventos)
            {
                EscreveLog(evento);
            }
            Invoke(new MethodInvoker(() =>
            {
                foreach (var evento in args.Eventos)
                {
                    _eventos.Insert(0, evento);
                }
            }));
        }

        protected void EscreveLog(Evento ultimEvento)
        {
            if (ultimEvento != null)
            {
                var path = Path.GetFullPath(GetType().Assembly.Location);
                path = path.Substring(0, path.Length - Path.GetFileName(path).Length);
                var fileName = string.Format("{0:yyyy-MM-dd}.log", DateTime.Today);
                var fullFileName = Path.Combine(path, fileName);
                File.AppendAllLines(fullFileName,
                    new[]
                    {
                        string.Format("{0:dd-MM-yyyy - HH:mm:ss} - {1} - {2}", ultimEvento.DateTime, ultimEvento.Nome,
                            ultimEvento.Operacao)
                    });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _eventos.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _eventos = new BindingList<Evento>();
            eventoBindingSource.DataSource = _eventos;
            LoadTagStates();

            SetupReader();
            DetectionManager.Create(_provider, _provider);
            try
            {
                DetectionManager.Instance.Start();
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
            }
        }

        private void SetupReader()
        {
            var path = Path.GetFullPath(GetType().Assembly.Location);
            path = path.Substring(0, path.Length - Path.GetFileName(path).Length);
            var configFileName = Path.Combine(path, "Resources", "config.txt");
            var config = File.ReadAllLines(configFileName);

            var ip = config[0];
            var antenaIn = config[1].Split(new[] {'\t'}).ToArray();
            var antenaOut = config[2].Split(new[] {'\t'}).ToArray();

            ResetReaderConfig(ip, antenaIn, antenaOut);
        }

        private static void ResetReaderConfig(string ip, string[] antenaIn, string[] antenaOut)
        {
            var readerConfigBll = new ReaderConfigBll();
            readerConfigBll.Clear();
            var reader = readerConfigBll.InsertReader("Cruzeiro", ip, ReaderTypeEnum.IMPINJ_REVOLUTION);
            var antena1 = readerConfigBll.InsertAntenna(reader, "antena1", int.Parse(antenaIn[0]),
                AntennaTypeEnum.FAR_FIELD, float.Parse(antenaIn[1]), float.Parse(antenaIn[2]));
            var antena2 = readerConfigBll.InsertAntenna(reader, "antena2", int.Parse(antenaOut[0]),
                AntennaTypeEnum.FAR_FIELD, float.Parse(antenaOut[1]), float.Parse(antenaOut[2]));
            var routeOut = readerConfigBll.InsertRoute(new[] {antena1, antena2});
            var routeIn = readerConfigBll.InsertRoute(new[] {antena2, antena1});
            readerConfigBll.InsertRouteAction(routeOut, RouteActionTypeEnum.PRESENCE, "Saída", 1);
            readerConfigBll.InsertRouteAction(routeIn, RouteActionTypeEnum.PRESENCE, "Entrada", 2);
            readerConfigBll.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetectionManager.Instance.Stop();
        }
    }
}
