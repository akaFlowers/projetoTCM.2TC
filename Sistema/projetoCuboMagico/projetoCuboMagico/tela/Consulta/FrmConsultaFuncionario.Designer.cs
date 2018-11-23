namespace projetoCuboMagico.tela.Consulta
{
    partial class FrmConsultaFuncionario
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
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.cboOrdernarPor = new System.Windows.Forms.ComboBox();
            this.lblOrdernarPor = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.ckbCodigo = new System.Windows.Forms.CheckBox();
            this.gpbConsultaNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbConsultaCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.gpbConsultaNome.SuspendLayout();
            this.gpbConsultaCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.BackColor = System.Drawing.Color.SpringGreen;
            this.btnListarTodos.FlatAppearance.BorderSize = 0;
            this.btnListarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTodos.Location = new System.Drawing.Point(665, 543);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(149, 44);
            this.btnListarTodos.TabIndex = 22;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = false;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // cboOrdernarPor
            // 
            this.cboOrdernarPor.FormattingEnabled = true;
            this.cboOrdernarPor.Location = new System.Drawing.Point(912, 273);
            this.cboOrdernarPor.Name = "cboOrdernarPor";
            this.cboOrdernarPor.Size = new System.Drawing.Size(121, 21);
            this.cboOrdernarPor.TabIndex = 21;
            // 
            // lblOrdernarPor
            // 
            this.lblOrdernarPor.AutoSize = true;
            this.lblOrdernarPor.Location = new System.Drawing.Point(837, 276);
            this.lblOrdernarPor.Name = "lblOrdernarPor";
            this.lblOrdernarPor.Size = new System.Drawing.Size(69, 13);
            this.lblOrdernarPor.TabIndex = 20;
            this.lblOrdernarPor.Text = "Ordernar por:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(840, 543);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(207, 44);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(52, 300);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowTemplate.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(981, 198);
            this.dgvFuncionario.TabIndex = 18;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(391, 39);
            this.lblMessage1.TabIndex = 27;
            this.lblMessage1.Text = "Consulta de Funcionário";
            // 
            // ckbNome
            // 
            this.ckbNome.AutoSize = true;
            this.ckbNome.Location = new System.Drawing.Point(26, 229);
            this.ckbNome.Name = "ckbNome";
            this.ckbNome.Size = new System.Drawing.Size(15, 14);
            this.ckbNome.TabIndex = 31;
            this.ckbNome.UseVisualStyleBackColor = true;
            this.ckbNome.CheckedChanged += new System.EventHandler(this.ckbNome_CheckedChanged);
            // 
            // ckbCodigo
            // 
            this.ckbCodigo.AutoSize = true;
            this.ckbCodigo.Checked = true;
            this.ckbCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCodigo.Location = new System.Drawing.Point(26, 125);
            this.ckbCodigo.Name = "ckbCodigo";
            this.ckbCodigo.Size = new System.Drawing.Size(15, 14);
            this.ckbCodigo.TabIndex = 30;
            this.ckbCodigo.UseVisualStyleBackColor = true;
            this.ckbCodigo.CheckedChanged += new System.EventHandler(this.ckbCodigo_CheckedChanged);
            // 
            // gpbConsultaNome
            // 
            this.gpbConsultaNome.Controls.Add(this.txtNome);
            this.gpbConsultaNome.Controls.Add(this.lblNome);
            this.gpbConsultaNome.Location = new System.Drawing.Point(52, 181);
            this.gpbConsultaNome.Name = "gpbConsultaNome";
            this.gpbConsultaNome.Size = new System.Drawing.Size(281, 94);
            this.gpbConsultaNome.TabIndex = 29;
            this.gpbConsultaNome.TabStop = false;
            this.gpbConsultaNome.Text = "Consulta por Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(22, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // gpbConsultaCodigo
            // 
            this.gpbConsultaCodigo.Controls.Add(this.txtCodigo);
            this.gpbConsultaCodigo.Controls.Add(this.lblCodigo);
            this.gpbConsultaCodigo.Location = new System.Drawing.Point(52, 77);
            this.gpbConsultaCodigo.Name = "gpbConsultaCodigo";
            this.gpbConsultaCodigo.Size = new System.Drawing.Size(281, 94);
            this.gpbConsultaCodigo.TabIndex = 28;
            this.gpbConsultaCodigo.TabStop = false;
            this.gpbConsultaCodigo.Text = "Consulta por Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(22, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo:";
            // 
            // FrmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.ckbNome);
            this.Controls.Add(this.ckbCodigo);
            this.Controls.Add(this.gpbConsultaNome);
            this.Controls.Add(this.gpbConsultaCodigo);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.cboOrdernarPor);
            this.Controls.Add(this.lblOrdernarPor);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaFuncionario";
            this.Text = "FrmConsultaFuncionario";
            this.Load += new System.EventHandler(this.FrmConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.gpbConsultaNome.ResumeLayout(false);
            this.gpbConsultaNome.PerformLayout();
            this.gpbConsultaCodigo.ResumeLayout(false);
            this.gpbConsultaCodigo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.ComboBox cboOrdernarPor;
        private System.Windows.Forms.Label lblOrdernarPor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.CheckBox ckbCodigo;
        private System.Windows.Forms.GroupBox gpbConsultaNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbConsultaCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}