namespace TagGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Funcionários = new System.Windows.Forms.TabPage();
            this.terDataGridView = new System.Windows.Forms.DataGridView();
            this.terDataGridViewColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terDataGridViewColumnEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terDataGridViewColumnIdentificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terDataGridViewColumnEPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_apagar_funcionarios = new System.Windows.Forms.Button();
            this.btn_associar_funcionarios = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPessoafunc = new System.Windows.Forms.TextBox();
            this.Visitantes = new System.Windows.Forms.TabPage();
            this.visDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxpessoavisit = new System.Windows.Forms.TextBox();
            this.btn_associar_visitantes = new System.Windows.Forms.Button();
            this.btn_excluir_visitantes = new System.Windows.Forms.Button();
            this.visNomeTextBox = new System.Windows.Forms.TextBox();
            this.btn_apagar_visitantes = new System.Windows.Forms.Button();
            this.btn_criar_visitantes = new System.Windows.Forms.Button();
            this.visIdentTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.veicDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Administrativo = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxEPC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conectar_leitor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.relógio = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TipoPessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.visTipoTextBox = new System.Windows.Forms.TextBox();
            this.visLeitoTextBox = new System.Windows.Forms.TextBox();
            this.visDataGridViewColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visDataGridViewColumnLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visDataGridViewColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visDataGridViewColumnEPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veicDataGridViewColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veicDataGridViewColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veicDataGridViewColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veicDataGridViewColumnEPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Funcionários.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terDataGridView)).BeginInit();
            this.Visitantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicDataGridView)).BeginInit();
            this.Administrativo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.Funcionários);
            this.tabControl1.Controls.Add(this.Visitantes);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Administrativo);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // Funcionários
            // 
            this.Funcionários.Controls.Add(this.terDataGridView);
            this.Funcionários.Controls.Add(this.btn_apagar_funcionarios);
            this.Funcionários.Controls.Add(this.btn_associar_funcionarios);
            this.Funcionários.Controls.Add(this.label8);
            this.Funcionários.Controls.Add(this.textBoxPessoafunc);
            this.Funcionários.Location = new System.Drawing.Point(4, 22);
            this.Funcionários.Name = "Funcionários";
            this.Funcionários.Padding = new System.Windows.Forms.Padding(3);
            this.Funcionários.Size = new System.Drawing.Size(746, 435);
            this.Funcionários.TabIndex = 1;
            this.Funcionários.Text = "Terceirizados";
            this.Funcionários.UseVisualStyleBackColor = true;
            // 
            // terDataGridView
            // 
            this.terDataGridView.AllowUserToAddRows = false;
            this.terDataGridView.AllowUserToDeleteRows = false;
            this.terDataGridView.AllowUserToResizeRows = false;
            this.terDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.terDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.terDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.terDataGridViewColumnNome,
            this.terDataGridViewColumnEmpresa,
            this.terDataGridViewColumnIdentificacao,
            this.terDataGridViewColumnEPC});
            this.terDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.terDataGridView.Location = new System.Drawing.Point(9, 18);
            this.terDataGridView.MultiSelect = false;
            this.terDataGridView.Name = "terDataGridView";
            this.terDataGridView.ReadOnly = true;
            this.terDataGridView.RowHeadersVisible = false;
            this.terDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terDataGridView.Size = new System.Drawing.Size(727, 366);
            this.terDataGridView.TabIndex = 107;
            this.terDataGridView.SelectionChanged += new System.EventHandler(this.terDataGridView_SelectionChanged);
            // 
            // terDataGridViewColumnNome
            // 
            this.terDataGridViewColumnNome.DataPropertyName = "Nome";
            this.terDataGridViewColumnNome.HeaderText = "Nome";
            this.terDataGridViewColumnNome.Name = "terDataGridViewColumnNome";
            this.terDataGridViewColumnNome.ReadOnly = true;
            // 
            // terDataGridViewColumnEmpresa
            // 
            this.terDataGridViewColumnEmpresa.DataPropertyName = "Empresa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.terDataGridViewColumnEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.terDataGridViewColumnEmpresa.HeaderText = "Empresa";
            this.terDataGridViewColumnEmpresa.Name = "terDataGridViewColumnEmpresa";
            this.terDataGridViewColumnEmpresa.ReadOnly = true;
            // 
            // terDataGridViewColumnIdentificacao
            // 
            this.terDataGridViewColumnIdentificacao.DataPropertyName = "Identificacao";
            this.terDataGridViewColumnIdentificacao.HeaderText = "Idenfificação";
            this.terDataGridViewColumnIdentificacao.Name = "terDataGridViewColumnIdentificacao";
            this.terDataGridViewColumnIdentificacao.ReadOnly = true;
            // 
            // terDataGridViewColumnEPC
            // 
            this.terDataGridViewColumnEPC.DataPropertyName = "EPC";
            this.terDataGridViewColumnEPC.HeaderText = "EPC";
            this.terDataGridViewColumnEPC.Name = "terDataGridViewColumnEPC";
            this.terDataGridViewColumnEPC.ReadOnly = true;
            // 
            // btn_apagar_funcionarios
            // 
            this.btn_apagar_funcionarios.Location = new System.Drawing.Point(650, 401);
            this.btn_apagar_funcionarios.Name = "btn_apagar_funcionarios";
            this.btn_apagar_funcionarios.Size = new System.Drawing.Size(91, 23);
            this.btn_apagar_funcionarios.TabIndex = 4;
            this.btn_apagar_funcionarios.Text = "Apagar epc";
            this.btn_apagar_funcionarios.UseVisualStyleBackColor = true;
            this.btn_apagar_funcionarios.Click += new System.EventHandler(this.btn_apagar_funcionarios_Click);
            // 
            // btn_associar_funcionarios
            // 
            this.btn_associar_funcionarios.Location = new System.Drawing.Point(553, 401);
            this.btn_associar_funcionarios.Name = "btn_associar_funcionarios";
            this.btn_associar_funcionarios.Size = new System.Drawing.Size(91, 23);
            this.btn_associar_funcionarios.TabIndex = 3;
            this.btn_associar_funcionarios.Text = "Associar epc";
            this.btn_associar_funcionarios.UseVisualStyleBackColor = true;
            this.btn_associar_funcionarios.Click += new System.EventHandler(this.btn_associar_funcionarios_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Funcionário Selecionado";
            // 
            // textBoxPessoafunc
            // 
            this.textBoxPessoafunc.Location = new System.Drawing.Point(9, 403);
            this.textBoxPessoafunc.Name = "textBoxPessoafunc";
            this.textBoxPessoafunc.ReadOnly = true;
            this.textBoxPessoafunc.Size = new System.Drawing.Size(539, 20);
            this.textBoxPessoafunc.TabIndex = 2;
            // 
            // Visitantes
            // 
            this.Visitantes.Controls.Add(this.visLeitoTextBox);
            this.Visitantes.Controls.Add(this.visTipoTextBox);
            this.Visitantes.Controls.Add(this.visDataGridView);
            this.Visitantes.Controls.Add(this.label2);
            this.Visitantes.Controls.Add(this.label1);
            this.Visitantes.Controls.Add(this.label4);
            this.Visitantes.Controls.Add(this.textBoxpessoavisit);
            this.Visitantes.Controls.Add(this.btn_associar_visitantes);
            this.Visitantes.Controls.Add(this.btn_excluir_visitantes);
            this.Visitantes.Controls.Add(this.visNomeTextBox);
            this.Visitantes.Controls.Add(this.btn_apagar_visitantes);
            this.Visitantes.Controls.Add(this.btn_criar_visitantes);
            this.Visitantes.Controls.Add(this.visIdentTextBox);
            this.Visitantes.Controls.Add(this.label10);
            this.Visitantes.Controls.Add(this.label14);
            this.Visitantes.Location = new System.Drawing.Point(4, 22);
            this.Visitantes.Name = "Visitantes";
            this.Visitantes.Size = new System.Drawing.Size(746, 435);
            this.Visitantes.TabIndex = 2;
            this.Visitantes.Text = "Visitantes/Acomp.";
            this.Visitantes.UseVisualStyleBackColor = true;
            // 
            // visDataGridView
            // 
            this.visDataGridView.AllowUserToAddRows = false;
            this.visDataGridView.AllowUserToDeleteRows = false;
            this.visDataGridView.AllowUserToResizeRows = false;
            this.visDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.visDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visDataGridViewColumnNome,
            this.visDataGridViewColumnLeito,
            this.visDataGridViewColumnTipo,
            this.visDataGridViewColumnEPC});
            this.visDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.visDataGridView.Location = new System.Drawing.Point(10, 89);
            this.visDataGridView.MultiSelect = false;
            this.visDataGridView.Name = "visDataGridView";
            this.visDataGridView.ReadOnly = true;
            this.visDataGridView.RowHeadersVisible = false;
            this.visDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visDataGridView.Size = new System.Drawing.Size(727, 292);
            this.visDataGridView.TabIndex = 118;
            this.visDataGridView.SelectionChanged += new System.EventHandler(this.visDataGridView_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Leito do paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Visitante Selecionado";
            // 
            // textBoxpessoavisit
            // 
            this.textBoxpessoavisit.Location = new System.Drawing.Point(9, 403);
            this.textBoxpessoavisit.Name = "textBoxpessoavisit";
            this.textBoxpessoavisit.ReadOnly = true;
            this.textBoxpessoavisit.Size = new System.Drawing.Size(539, 20);
            this.textBoxpessoavisit.TabIndex = 6;
            // 
            // btn_associar_visitantes
            // 
            this.btn_associar_visitantes.Location = new System.Drawing.Point(553, 401);
            this.btn_associar_visitantes.Name = "btn_associar_visitantes";
            this.btn_associar_visitantes.Size = new System.Drawing.Size(91, 23);
            this.btn_associar_visitantes.TabIndex = 7;
            this.btn_associar_visitantes.Text = "Associar epc";
            this.btn_associar_visitantes.UseVisualStyleBackColor = true;
            this.btn_associar_visitantes.Click += new System.EventHandler(this.btn_associar_visitantes_Click);
            // 
            // btn_excluir_visitantes
            // 
            this.btn_excluir_visitantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir_visitantes.Location = new System.Drawing.Point(9, 60);
            this.btn_excluir_visitantes.Name = "btn_excluir_visitantes";
            this.btn_excluir_visitantes.Size = new System.Drawing.Size(91, 23);
            this.btn_excluir_visitantes.TabIndex = 5;
            this.btn_excluir_visitantes.Text = "Excluir Visitante";
            this.btn_excluir_visitantes.UseVisualStyleBackColor = true;
            this.btn_excluir_visitantes.Click += new System.EventHandler(this.btn_excluir_visitantes_Click);
            // 
            // visNomeTextBox
            // 
            this.visNomeTextBox.Location = new System.Drawing.Point(115, 24);
            this.visNomeTextBox.Name = "visNomeTextBox";
            this.visNomeTextBox.Size = new System.Drawing.Size(408, 20);
            this.visNomeTextBox.TabIndex = 2;
            // 
            // btn_apagar_visitantes
            // 
            this.btn_apagar_visitantes.Location = new System.Drawing.Point(650, 401);
            this.btn_apagar_visitantes.Name = "btn_apagar_visitantes";
            this.btn_apagar_visitantes.Size = new System.Drawing.Size(91, 23);
            this.btn_apagar_visitantes.TabIndex = 8;
            this.btn_apagar_visitantes.Text = "Apagar epc";
            this.btn_apagar_visitantes.UseVisualStyleBackColor = true;
            this.btn_apagar_visitantes.Click += new System.EventHandler(this.btn_apagar_visitantes_Click);
            // 
            // btn_criar_visitantes
            // 
            this.btn_criar_visitantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_criar_visitantes.Location = new System.Drawing.Point(9, 21);
            this.btn_criar_visitantes.Name = "btn_criar_visitantes";
            this.btn_criar_visitantes.Size = new System.Drawing.Size(91, 23);
            this.btn_criar_visitantes.TabIndex = 4;
            this.btn_criar_visitantes.Text = "Criar Visitante";
            this.btn_criar_visitantes.UseVisualStyleBackColor = true;
            this.btn_criar_visitantes.Click += new System.EventHandler(this.btn_criar_visitantes_Click);
            // 
            // visIdentTextBox
            // 
            this.visIdentTextBox.Location = new System.Drawing.Point(115, 63);
            this.visIdentTextBox.Name = "visIdentTextBox";
            this.visIdentTextBox.Size = new System.Drawing.Size(323, 20);
            this.visIdentTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Documento de identificação";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 13);
            this.label14.TabIndex = 109;
            this.label14.Text = "Nome do novo visitante";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.veicDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 435);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Veículos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // veicDataGridView
            // 
            this.veicDataGridView.AllowUserToAddRows = false;
            this.veicDataGridView.AllowUserToDeleteRows = false;
            this.veicDataGridView.AllowUserToResizeRows = false;
            this.veicDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.veicDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.veicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veicDataGridViewColumnModelo,
            this.veicDataGridViewColumnMarca,
            this.veicDataGridViewColumnPlaca,
            this.veicDataGridViewColumnEPC});
            this.veicDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.veicDataGridView.Location = new System.Drawing.Point(8, 51);
            this.veicDataGridView.MultiSelect = false;
            this.veicDataGridView.Name = "veicDataGridView";
            this.veicDataGridView.ReadOnly = true;
            this.veicDataGridView.RowHeadersVisible = false;
            this.veicDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veicDataGridView.Size = new System.Drawing.Size(731, 333);
            this.veicDataGridView.TabIndex = 123;
            this.veicDataGridView.SelectionChanged += new System.EventHandler(this.veicDataGridView_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 121;
            this.button1.Text = "Apagar epc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 120;
            this.button2.Text = "Associar epc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Veículo Selecionado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(539, 20);
            this.textBox1.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Cor";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "Id";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 29);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(98, 21);
            this.comboBox3.TabIndex = 117;
            this.comboBox3.ValueMember = "Id";
            this.comboBox3.Visible = false;
            // 
            // Administrativo
            // 
            this.Administrativo.Controls.Add(this.listBox1);
            this.Administrativo.Location = new System.Drawing.Point(4, 22);
            this.Administrativo.Name = "Administrativo";
            this.Administrativo.Size = new System.Drawing.Size(746, 435);
            this.Administrativo.TabIndex = 3;
            this.Administrativo.Text = "Administrativo";
            this.Administrativo.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 433);
            this.listBox1.TabIndex = 110;
            // 
            // textBoxEPC
            // 
            this.textBoxEPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEPC.Location = new System.Drawing.Point(277, 12);
            this.textBoxEPC.Name = "textBoxEPC";
            this.textBoxEPC.ReadOnly = true;
            this.textBoxEPC.Size = new System.Drawing.Size(222, 24);
            this.textBoxEPC.TabIndex = 2;
            this.textBoxEPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Epc do cartão atual";
            // 
            // btn_conectar_leitor
            // 
            this.btn_conectar_leitor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_conectar_leitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_leitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_leitor.Location = new System.Drawing.Point(3, 9);
            this.btn_conectar_leitor.Name = "btn_conectar_leitor";
            this.btn_conectar_leitor.Size = new System.Drawing.Size(113, 32);
            this.btn_conectar_leitor.TabIndex = 1;
            this.btn_conectar_leitor.Text = "Conectar leitor";
            this.btn_conectar_leitor.UseVisualStyleBackColor = false;
            this.btn_conectar_leitor.Click += new System.EventHandler(this.btn_conectar_leitor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 102);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::TagGen.Properties.Resources.Banner_Cadastro_Tags_HCE6;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(4, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 105);
            this.panel2.TabIndex = 74;
            // 
            // relógio
            // 
            this.relógio.Enabled = true;
            this.relógio.Interval = 1000;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 694);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "dd/mm/yyy HH/MM/ss";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_conectar_leitor);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.btn_apagar);
            this.panel3.Controls.Add(this.btn_procurar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxEPC);
            this.panel3.Location = new System.Drawing.Point(3, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 97);
            this.panel3.TabIndex = 75;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoPessoaId});
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView3.Location = new System.Drawing.Point(-2, 50);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(755, 42);
            this.dataGridView3.TabIndex = 5;
            // 
            // TipoPessoaId
            // 
            this.TipoPessoaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoPessoaId.DataPropertyName = "TipoPessoaId";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoPessoaId.DefaultCellStyle = dataGridViewCellStyle6;
            this.TipoPessoaId.HeaderText = "Tipo de usuário";
            this.TipoPessoaId.Name = "TipoPessoaId";
            this.TipoPessoaId.ReadOnly = true;
            this.TipoPessoaId.Width = 200;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(669, 12);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 4;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(567, 12);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(96, 23);
            this.btn_procurar.TabIndex = 3;
            this.btn_procurar.Text = "Procurar usuário";
            this.btn_procurar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Location = new System.Drawing.Point(3, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 467);
            this.panel4.TabIndex = 76;
            // 
            // visTipoTextBox
            // 
            this.visTipoTextBox.Location = new System.Drawing.Point(553, 25);
            this.visTipoTextBox.Name = "visTipoTextBox";
            this.visTipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.visTipoTextBox.TabIndex = 119;
            // 
            // visLeitoTextBox
            // 
            this.visLeitoTextBox.Location = new System.Drawing.Point(553, 64);
            this.visLeitoTextBox.Name = "visLeitoTextBox";
            this.visLeitoTextBox.Size = new System.Drawing.Size(100, 20);
            this.visLeitoTextBox.TabIndex = 120;
            // 
            // visDataGridViewColumnNome
            // 
            this.visDataGridViewColumnNome.DataPropertyName = "Nome";
            this.visDataGridViewColumnNome.HeaderText = "Nome";
            this.visDataGridViewColumnNome.Name = "visDataGridViewColumnNome";
            this.visDataGridViewColumnNome.ReadOnly = true;
            // 
            // visDataGridViewColumnLeito
            // 
            this.visDataGridViewColumnLeito.DataPropertyName = "Leito";
            this.visDataGridViewColumnLeito.HeaderText = "Leito";
            this.visDataGridViewColumnLeito.Name = "visDataGridViewColumnLeito";
            this.visDataGridViewColumnLeito.ReadOnly = true;
            // 
            // visDataGridViewColumnTipo
            // 
            this.visDataGridViewColumnTipo.DataPropertyName = "Tipo";
            this.visDataGridViewColumnTipo.HeaderText = "Tipo";
            this.visDataGridViewColumnTipo.Name = "visDataGridViewColumnTipo";
            this.visDataGridViewColumnTipo.ReadOnly = true;
            // 
            // visDataGridViewColumnEPC
            // 
            this.visDataGridViewColumnEPC.DataPropertyName = "EPC";
            this.visDataGridViewColumnEPC.HeaderText = "EPC";
            this.visDataGridViewColumnEPC.Name = "visDataGridViewColumnEPC";
            this.visDataGridViewColumnEPC.ReadOnly = true;
            // 
            // veicDataGridViewColumnModelo
            // 
            this.veicDataGridViewColumnModelo.DataPropertyName = "Modelo";
            this.veicDataGridViewColumnModelo.HeaderText = "Modelo";
            this.veicDataGridViewColumnModelo.Name = "veicDataGridViewColumnModelo";
            this.veicDataGridViewColumnModelo.ReadOnly = true;
            // 
            // veicDataGridViewColumnMarca
            // 
            this.veicDataGridViewColumnMarca.DataPropertyName = "Marca";
            this.veicDataGridViewColumnMarca.HeaderText = "Marca";
            this.veicDataGridViewColumnMarca.Name = "veicDataGridViewColumnMarca";
            this.veicDataGridViewColumnMarca.ReadOnly = true;
            // 
            // veicDataGridViewColumnPlaca
            // 
            this.veicDataGridViewColumnPlaca.DataPropertyName = "Placa";
            this.veicDataGridViewColumnPlaca.HeaderText = "Placa";
            this.veicDataGridViewColumnPlaca.Name = "veicDataGridViewColumnPlaca";
            this.veicDataGridViewColumnPlaca.ReadOnly = true;
            // 
            // veicDataGridViewColumnEPC
            // 
            this.veicDataGridViewColumnEPC.DataPropertyName = "EPC";
            this.veicDataGridViewColumnEPC.HeaderText = "EPC";
            this.veicDataGridViewColumnEPC.Name = "veicDataGridViewColumnEPC";
            this.veicDataGridViewColumnEPC.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(759, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema de Cadastro de Tags";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Funcionários.ResumeLayout(false);
            this.Funcionários.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terDataGridView)).EndInit();
            this.Visitantes.ResumeLayout(false);
            this.Visitantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicDataGridView)).EndInit();
            this.Administrativo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Matrícula;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxEPC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Funcionários;
        private System.Windows.Forms.TabPage Visitantes;
        private System.Windows.Forms.TabPage Administrativo;
        private System.Windows.Forms.Button btn_conectar_leitor;
        //private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn epcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_apagar_funcionarios;
        private System.Windows.Forms.Button btn_associar_funcionarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPessoafunc;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer relógio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox visIdentTextBox;
        private System.Windows.Forms.Button btn_criar_visitantes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_apagar_visitantes;
        private System.Windows.Forms.TextBox visNomeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Button btn_excluir_visitantes;
        private System.Windows.Forms.Button btn_associar_visitantes;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPessoaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxpessoavisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView terDataGridView;
        private System.Windows.Forms.DataGridView visDataGridView;
        private System.Windows.Forms.DataGridView veicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn terDataGridViewColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn terDataGridViewColumnEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn terDataGridViewColumnIdentificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn terDataGridViewColumnEPC;
        private System.Windows.Forms.TextBox visLeitoTextBox;
        private System.Windows.Forms.TextBox visTipoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn visDataGridViewColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn visDataGridViewColumnLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn visDataGridViewColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn visDataGridViewColumnEPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn veicDataGridViewColumnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn veicDataGridViewColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn veicDataGridViewColumnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn veicDataGridViewColumnEPC;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
    }
}

