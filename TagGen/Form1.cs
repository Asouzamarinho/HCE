using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
//using Excel = Microsoft.Office.Interop.Excel;

namespace TagGen
{
    public partial class Form1 : Form
    {
        BD bd;
        Action deletar;
        Action refresh;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            bd = new BD();

        #if DEBUG
            bd.Database.Delete();
        #endif

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
            if (!Procurar())
            {
                var index = ((DataGridViewRow)terDataGridView.SelectedRows[0]).Index;
                ((List<Terceirizado>)terDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

                bd.SaveChanges();

                terDataGridView.DataSource = bd.Terceirizados.ToList();

                dadosLabel.Text = "cadastrado";
            }
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
            if (!Procurar())
            {
                var index = ((DataGridViewRow)visDataGridView.SelectedRows[0]).Index;
                ((List<Visitante>)visDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

                bd.SaveChanges();

                visDataGridView.DataSource = bd.Visitantes.ToList();

                dadosLabel.Text = "cadastrado";
            }
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
            if (!Procurar())
            {
                var index = ((DataGridViewRow)veicDataGridView.SelectedRows[0]).Index;
                ((List<Veiculo>)veicDataGridView.DataSource)[index].EPC = textBoxEPC.Text;

                bd.SaveChanges();

                veicDataGridView.DataSource = bd.Veiculos.ToList();

                dadosLabel.Text = "cadastrado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = ((DataGridViewRow)veicDataGridView.SelectedRows[0]).Index;
            ((List<Veiculo>)veicDataGridView.DataSource)[index].EPC = "";

            bd.SaveChanges();

            veicDataGridView.DataSource = bd.Veiculos.ToList();
        }

        bool Procurar()
        {
            if (textBoxEPC.Text != "")
            {
                string dados;

                try
                {
                    var v = bd.Terceirizados.Single(t => t.EPC == textBoxEPC.Text);
                    dados = v.Nome;
                    deletar = () => bd.Terceirizados.Remove(v);
                    refresh = () => terDataGridView.DataSource = bd.Terceirizados.ToList();

                    tipoLabel.Text = "Terceirizado";
                }
                catch
                {
                    try
                    {
                        var v = bd.Visitantes.Single(t => t.EPC == textBoxEPC.Text);
                        dados = v.Nome;
                        deletar = () => bd.Visitantes.Remove(v);
                        refresh = () => visDataGridView.DataSource = bd.Visitantes.ToList();

                        tipoLabel.Text = "Visitantes";
                    }
                    catch
                    {
                        try
                        {
                            var v = bd.Veiculos.Single(t => t.EPC == textBoxEPC.Text);
                            dados = v.Placa;
                            deletar = () => bd.Veiculos.Remove(v);
                            refresh = () => veicDataGridView.DataSource = bd.Veiculos.ToList();

                            tipoLabel.Text = "Veículos";
                        }
                        catch
                        {
                            dados = "Não encontrado";
                            deletar = null;
                            refresh = null;

                            tipoLabel.Text = "";

                            return false;
                        }
                    }
                }

                dadosLabel.Text = dados;

                return true;
            }
            else return false;
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            Procurar();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (deletar != null)
                deletar();

            bd.SaveChanges();

            if (refresh != null)
                refresh();
        }

        //https://social.msdn.microsoft.com/Forums/en-US/1d5c04c7-157f-4955-a14b-41d912d50a64/how-to-fix-error-the-microsoftaceoledb120-provider-is-not-registered-on-the-local-machine?forum=vstsdb
        private void Importar<T>(Func<string[], T> func, int skip = 0) where T : class
        {
            var fileDialog = new OpenFileDialog();

            fileDialog.ShowDialog();

            string fileName = fileDialog.FileName;

            var ds = new DataSet();

            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text\""; ;
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [" + sheets.Rows[0]["TABLE_NAME"].ToString() + "] ";

                    var adapter = new OleDbDataAdapter(cmd);
                    
                    adapter.Fill(ds);
                }
            }

            var t = ds.Tables[0].Rows.Cast<DataRow>().Skip(skip).Select(row => func(row.ItemArray.Select(o => o is string ? (string)o : string.Empty).ToArray()));

            bd.Set<T>().AddRange(t);

            bd.SaveChanges();

        }

        private void btn_importar_terc_Click(object sender, EventArgs e)
        {
            Importar(columns => new Terceirizado
            {
                Empresa = columns[0],
                Nome = columns[1],
                Identificacao = columns[2],
                EPC = columns[3]
            }, 1);

            terDataGridView.DataSource = bd.Terceirizados.ToList();
        }

        private void btn_importar_veic_Click(object sender, EventArgs e)
        {
            Importar(columns => new Veiculo
            {
                Selo = columns[0],
                Motorista = columns[1],
                Patente = columns[2],
                Cor = columns[3],
                Modelo = columns[4],
                Placa = columns[6],
                Setor = columns[7]
            }, 2);

            veicDataGridView.DataSource = bd.Veiculos.ToList();
        }
    }
}