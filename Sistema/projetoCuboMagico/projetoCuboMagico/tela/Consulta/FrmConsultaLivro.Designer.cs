namespace projetoCuboMagico.tela.Consulta
{
    partial class FrmConsultaLivro
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
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.ckbCodigo = new System.Windows.Forms.CheckBox();
            this.gpbConsultaNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbConsultaCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.ckbGenero = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.gpbConsultaNome.SuspendLayout();
            this.gpbConsultaCodigo.SuspendLayout();
            this.gpbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(286, 39);
            this.lblMessage1.TabIndex = 19;
            this.lblMessage1.Text = "Consulta de Livro";
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivro.BackgroundColor = System.Drawing.Color.White;
            this.dgvLivro.Location = new System.Drawing.Point(52, 300);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            this.dgvLivro.RowTemplate.ReadOnly = true;
            this.dgvLivro.Size = new System.Drawing.Size(981, 198);
            this.dgvLivro.TabIndex = 22;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.BackColor = System.Drawing.Color.SpringGreen;
            this.btnListarTodos.FlatAppearance.BorderSize = 0;
            this.btnListarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTodos.Location = new System.Drawing.Point(665, 543);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(149, 44);
            this.btnListarTodos.TabIndex = 24;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(840, 543);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(207, 44);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ckbNome
            // 
            this.ckbNome.AutoSize = true;
            this.ckbNome.Location = new System.Drawing.Point(26, 227);
            this.ckbNome.Name = "ckbNome";
            this.ckbNome.Size = new System.Drawing.Size(15, 14);
            this.ckbNome.TabIndex = 29;
            this.ckbNome.UseVisualStyleBackColor = true;
            this.ckbNome.CheckedChanged += new System.EventHandler(this.ckbNome_CheckedChanged);
            // 
            // ckbCodigo
            // 
            this.ckbCodigo.AutoSize = true;
            this.ckbCodigo.Checked = true;
            this.ckbCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCodigo.Location = new System.Drawing.Point(26, 123);
            this.ckbCodigo.Name = "ckbCodigo";
            this.ckbCodigo.Size = new System.Drawing.Size(15, 14);
            this.ckbCodigo.TabIndex = 28;
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
            this.gpbConsultaNome.TabIndex = 27;
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
            this.gpbConsultaCodigo.TabIndex = 26;
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
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.lblGenero);
            this.gpbGenero.Controls.Add(this.cboGenero);
            this.gpbGenero.Location = new System.Drawing.Point(364, 77);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(281, 94);
            this.gpbGenero.TabIndex = 30;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Consulta por Gênero";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(28, 26);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Genero:";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Enabled = false;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "TERROR",
            "INFANTO-JUVENIL",
            "HISTÓRIA",
            "ROMANCE",
            "AVENTURA"});
            this.cboGenero.Location = new System.Drawing.Point(31, 42);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 0;
            // 
            // ckbGenero
            // 
            this.ckbGenero.AutoSize = true;
            this.ckbGenero.Location = new System.Drawing.Point(343, 123);
            this.ckbGenero.Name = "ckbGenero";
            this.ckbGenero.Size = new System.Drawing.Size(15, 14);
            this.ckbGenero.TabIndex = 31;
            this.ckbGenero.UseVisualStyleBackColor = true;
            this.ckbGenero.CheckedChanged += new System.EventHandler(this.ckbGenero_CheckedChanged);
            // 
            // FrmConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.ckbGenero);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.ckbNome);
            this.Controls.Add(this.ckbCodigo);
            this.Controls.Add(this.gpbConsultaNome);
            this.Controls.Add(this.gpbConsultaCodigo);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvLivro);
            this.Controls.Add(this.lblMessage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaLivro";
            this.Text = "FrmConsultaLivro";
            this.Load += new System.EventHandler(this.FrmConsultaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.gpbConsultaNome.ResumeLayout(false);
            this.gpbConsultaNome.PerformLayout();
            this.gpbConsultaCodigo.ResumeLayout(false);
            this.gpbConsultaCodigo.PerformLayout();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.CheckBox ckbCodigo;
        private System.Windows.Forms.GroupBox gpbConsultaNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbConsultaCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.CheckBox ckbGenero;
    }
}