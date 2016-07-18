
namespace Portais.Presentation
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.PessoaId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBeanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sentidoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBeanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(13, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 73);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Projeto de Controle de Aluno e Saída de Alunos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROCESA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Portais.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 92);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(966, 378);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 256);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PessoaId,
            this.sentidoEventoDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.statusEventoDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.eventoBindingSource;
            this.dataGridViewEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEventos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.RowHeadersVisible = false;
            this.dataGridViewEventos.Size = new System.Drawing.Size(962, 252);
            this.dataGridViewEventos.TabIndex = 0;
            // 
            // PessoaId
            // 
            this.PessoaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PessoaId.DataPropertyName = "PessoaId";
            this.PessoaId.DataSource = this.pessoaBeanBindingSource;
            this.PessoaId.DisplayMember = "Name";
            this.PessoaId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PessoaId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PessoaId.HeaderText = "PessoaId";
            this.PessoaId.Name = "PessoaId";
            this.PessoaId.ReadOnly = true;
            this.PessoaId.ValueMember = "Id";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 118);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SentidoEvento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Sentido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StatusEvento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // pessoaBeanBindingSource
            // 
            this.pessoaBeanBindingSource.DataSource = typeof(Cruzeiro.Core.Model.Beans.PessoaBean);
            // 
            // sentidoEventoDataGridViewTextBoxColumn
            // 
            this.sentidoEventoDataGridViewTextBoxColumn.DataPropertyName = "SentidoEvento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sentidoEventoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sentidoEventoDataGridViewTextBoxColumn.HeaderText = "Sentido";
            this.sentidoEventoDataGridViewTextBoxColumn.Name = "sentidoEventoDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.dateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Horário";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // statusEventoDataGridViewTextBoxColumn
            // 
            this.statusEventoDataGridViewTextBoxColumn.DataPropertyName = "StatusEvento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusEventoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.statusEventoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusEventoDataGridViewTextBoxColumn.Name = "statusEventoDataGridViewTextBoxColumn";
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataSource = typeof(Cruzeiro.Core.Model.Beans.EventoBean);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 482);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "PROCESA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBeanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn PessoaId;
        private System.Windows.Forms.BindingSource pessoaBeanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentidoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusEventoDataGridViewTextBoxColumn;
    }
}

