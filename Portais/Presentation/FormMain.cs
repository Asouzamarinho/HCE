using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Cruzeiro.Core.Bll;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using TotalTag.Common.Tools;

namespace Portais.Presentation
{
    public partial class FormMain : Form
    {
        private EventoManager _eventoManager;
        private BindingList<PessoaBean> _pessoas;
        private BindingList<EventoBean> _eventos;

        public FormMain()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _pessoas = new BindingList<PessoaBean>(new PessoaBll().GetAll().Cast<PessoaBean>().ToList());
                _pessoas.Add(new PessoaBean
                {
                    Id = 0,
                    Name = "Pessoa Inválida"
                });
                pessoaBeanBindingSource.DataSource = _pessoas;
                _eventos =
                    new BindingList<EventoBean>(
                        new EventoPortalBll().GetEventosPorData(DateTime.Today).Cast<EventoBean>().ToList());
                dataGridViewEventos.DataSource = _eventos;

                WindowState = FormWindowState.Maximized;
                new LeitorBll().SetConfiguracaoLeitor();
                _eventoManager = new EventoManager();
                _eventoManager.EventoProcessado += EventoManagerOnEventoProcessado;
                _eventoManager.Start();
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
            }
        }

        private void EventoManagerOnEventoProcessado(object sender, EventoPortal evento)
        {
            Invoke(new MethodInvoker(() =>
            {
                _eventos.Insert(0, evento);
                dataGridViewEventos.Refresh();
            }));
        }
    }
}
