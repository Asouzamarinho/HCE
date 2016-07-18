using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.WebService.Core.Client;

namespace Visualizacao_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        QfeQfsClient qfeQfs = new QfeQfsClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            DadosCadastraisClient dadosCad = new DadosCadastraisClient();

            //Versao antiga usando Context

            //var context = new Cruzeiro.WebService.Core.Client.QfeQfsClient();
            //var qfe = context.GetQfe(data,20);
            //var qfs = context.GetQfs(data,5);

            //var curso = context.GetCursos().Take(1).First();
            //var curso = context.GetCursos();

            //var estabelecimento = context.GetEstabelecimentos();
            //var estabelecimento = context.GetEstabelecimentos().Take(1).First();

            //var turmas = context.GetAllTurmas(estabelecimento, curso);
            //var alunos = context
            //var turma = context.GetAllTurmas();


            //var qfe = qfeQfs.GetQfe(data,1).Take(1).First() as PessoaBean;
            //var nome = qfe.Name;

            var curso = dadosCad.GetCursos().Take(1).First();
            var estabelecimento = dadosCad.GetEstabelecimentos().Take(1).First();



            var turmas = dadosCad.GetAllTurmas(estabelecimento, curso);
            var res = from t in turmas select t.Name;

            //BindingSource bs = new BindingSource();
            //bs.DataSource = res;


            //dataGrid3.DataSource = bs;

            GetQfeQfs();


        }

        private void GetQfeQfs()
        {
            var data = DateTime.Now;

            var qfe = qfeQfs.GetQfe(data, 32);
            var qfs = qfeQfs.GetQfs(data, 32);

            dataGridView1.DataSource = qfe;
            dataGridView2.DataSource = qfs;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Hospital Cruzeiro, " + DateTime.Now + ", Rio de Janeiro.";

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int margin = 10;
            int ajuste = 65;

            dataGridView1.Location = new Point(margin, 150);
            dataGridView1.Size = new Size(((Form1)sender).Width / 2 - 2 * margin, ((Form1)sender).Size.Height - 150 - margin - ajuste);
            dataGridView2.Location = new Point(((Form1)sender).Width / 2, 150);
            dataGridView2.Size = new Size(((Form1)sender).Width / 2 - 2 * margin, ((Form1)sender).Size.Height - 150 - margin - ajuste);

            textBox1.Location = new Point(0, 103);
            textBox1.Size = new Size(((Form1)sender).Width / 2 - 2 * margin, 24);
            textBox2.Location = new Point(((Form1)sender).Width / 2 + margin - 2, 103);
            textBox2.Size = new Size(((Form1)sender).Width / 2 - 2 * margin, 24);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() => GetQfeQfs()));
        }
    }
}
