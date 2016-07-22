using System;
using System.Windows.Forms;
using IRI.Win32.CSharp.IRIWrapper;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Net.NetworkInformation;
using System.Drawing;

namespace TagGen
{
    public partial class Form1 : Form
    {
        BD bd;
        public Form1()
        {
            InitializeComponent();
        }

    #if DEBUG
        string GetRandomEPC()
        {
            string epc = "";
            
            var chars = new char[]{ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F' };
            var random = new Random();

            for (int i = 0; i < 23; i++)
                epc += chars[random.Next(16)];

            return epc;
        }
    #endif

        void FeedBD()
        {
            using (var bd = new BD())
            {
                bd.Database.Delete();

                foreach (var terc in new Terceirizado[]
                {
                    new Terceirizado
                    {
                        Empresa = "CETUC",
                        Identificacao = "26.473.275-6",
                        Nome = "Rodrigo"
                    },
                    new Terceirizado
                    {
                        Empresa = "CETUC",
                        Identificacao = "26.275.473-6",
                        Nome = "Anderson"
                    },
                }) bd.Terceirizados.Add(terc);

                foreach (var veic in new Veiculo[] 
                {
                    new Veiculo
                    {
                        Marca = "Volkswagen",
                        Modelo = "Gol",
                        Placa = "ABC-1234"
                    },
                    new Veiculo
                    {
                        Marca = "Fiat",
                        Modelo = "Palio",
                        Placa = "HQW-5678"
                    },
                }) bd.Veiculos.Add(veic);

                bd.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bd = new BD();

            terDataGridView.AutoGenerateColumns = false;
            terDataGridView.DataSource = bd.Terceirizados.ToList();

            visDataGridView.AutoGenerateColumns = false;
            visDataGridView.DataSource = bd.Visitantes.ToList();

            veicDataGridView.AutoGenerateColumns = false;
            veicDataGridView.DataSource = bd.Veiculos.ToList();
         }

        private void btn_conectar_leitor_Click(object sender, EventArgs e)
        {
        #if !DEBUG
            ReaderHelper.Instance.Connect("COM3");
            ReaderHelper.Instance.Start();
            ReaderHelper.Instance.TagReported += tag => Invoke(new MethodInvoker(() => textBoxEPC.Text = tag.Epc));
        #else
            textBoxEPC.Text = GetRandomEPC();
        #endif
        }

        private void btn_associar_funcionarios_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)terDataGridView.SelectedRows[0]).Index;
            ((List<Terceirizado>)terDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

            bd.SaveChanges();

            terDataGridView.DataSource = bd.Terceirizados.ToList();
        }

        private void btn_apagar_funcionarios_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)terDataGridView.SelectedRows[0]).Index;
            ((List<Terceirizado>)terDataGridView.DataSource)[index].EPC = "";

            bd.SaveChanges();

            terDataGridView.DataSource = bd.Terceirizados.ToList();
        }

        private void terDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (terDataGridView.SelectedRows.Count > 0)
            {
                var index = ((DataGridViewRow)terDataGridView.SelectedRows[0]).Index;
                textBoxPessoafunc.Text = ((List<Terceirizado>)terDataGridView.DataSource)[index].Nome;
            }
        }

        private void btn_criar_visitantes_Click(object sender, EventArgs e)
        {
            bd.Visitantes.Add(new Visitante
            {
                Identificacao = visIdentTextBox.Text,
                Leito = visLeitoTextBox.Text,
                Nome = visNomeTextBox.Text,
                Tipo = visTipoTextBox.Text
            });

            bd.SaveChanges();

            visDataGridView.DataSource = bd.Visitantes.ToList();
        }

        private void btn_associar_visitantes_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)visDataGridView.SelectedRows[0]).Index;
            ((List<Visitante>)visDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

            bd.SaveChanges();

            visDataGridView.DataSource = bd.Visitantes.ToList();
        }

        private void btn_apagar_visitantes_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)visDataGridView.SelectedRows[0]).Index;
            ((List<Visitante>)visDataGridView.DataSource)[index].EPC = "";

            bd.SaveChanges();

            visDataGridView.DataSource = bd.Visitantes.ToList();
        }

        private void visDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (visDataGridView.SelectedRows.Count > 0)
            {
                var index = ((DataGridViewRow)visDataGridView.SelectedRows[0]).Index;
                textBoxpessoavisit.Text = ((List<Visitante>)visDataGridView.DataSource)[index].Nome;
            }
        }

        private void btn_excluir_visitantes_Click(object sender, EventArgs e)
        {
            if (visDataGridView.SelectedRows.Count > 0)
            {
                var index = ((DataGridViewRow)visDataGridView.SelectedRows[0]).Index;
                var vis = ((List<Visitante>)visDataGridView.DataSource)[index];

                bd.Visitantes.Remove(vis);

                bd.SaveChanges();

                visDataGridView.DataSource = bd.Visitantes.ToList();
            }
        }

        private void veicDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (veicDataGridView.SelectedRows.Count > 0)
            {
                var index = ((DataGridViewRow)veicDataGridView.SelectedRows[0]).Index;
                textBox1.Text = ((List<Veiculo>)veicDataGridView.DataSource)[index].Placa;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)veicDataGridView.SelectedRows[0]).Index;
            ((List<Veiculo>)veicDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

            bd.SaveChanges();

            veicDataGridView.DataSource = bd.Veiculos.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)veicDataGridView.SelectedRows[0]).Index;
            ((List<Veiculo>)veicDataGridView.DataSource)[index].EPC = "";

            bd.SaveChanges();

            veicDataGridView.DataSource = bd.Veiculos.ToList();
        }
    }
}