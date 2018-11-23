namespace projetoCuboMagico.tela.Consulta
{
    partial class FrmConsultaUsuario
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
            this.gpbConsultaNome = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbConsultaCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.ckbCodigo = new System.Windows.Forms.CheckBox();
            this.dgvUsuário = new System.Windows.Forms.DataGridView();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbConsultaNome.SuspendLayout();
            this.gpbConsultaCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuário)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(330, 39);
            this.lblMessage1.TabIndex = 25;
            this.lblMessage1.Text = "Consulta de Usuário";
            // 
            // gpbConsultaNome
            // 
            this.gpbConsultaNome.Controls.Add(this.txtUsuario);
            this.gpbConsultaNome.Controls.Add(this.lblNome);
            this.gpbConsultaNome.Location = new System.Drawing.Point(52, 181);
            this.gpbConsultaNome.Name = "gpbConsultaNome";
            this.gpbConsultaNome.Size = new System.Drawing.Size(281, 94);
            this.gpbConsultaNome.TabIndex = 29;
            this.gpbConsultaNome.TabStop = false;
            this.gpbConsultaNome.Text = "Consulta por Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(22, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Usuário";
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
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
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
            // ckbNome
            // 
            this.ckbNome.AutoSize = true;
            this.ckbNome.Location = new System.Drawing.Point(26, 227);
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
            this.ckbCodigo.Location = new System.Drawing.Point(26, 123);
            this.ckbCodigo.Name = "ckbCodigo";
            this.ckbCodigo.Size = new System.Drawing.Size(15, 14);
            this.ckbCodigo.TabIndex = 30;
            this.ckbCodigo.UseVisualStyleBackColor = true;
            this.ckbCodigo.CheckedChanged += new System.EventHandler(this.ckbCodigo_CheckedChanged);
            // 
            // dgvUsuário
            // 
            this.dgvUsuário.AllowUserToAddRows = false;
            this.dgvUsuário.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuário.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuário.Location = new System.Drawing.Point(52, 300);
            this.dgvUsuário.Name = "dgvUsuário";
            this.dgvUsuário.ReadOnly = true;
            this.dgvUsuário.RowTemplate.ReadOnly = true;
            this.dgvUsuário.Size = new System.Drawing.Size(981, 198);
            this.dgvUsuário.TabIndex = 32;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.BackColor = System.Drawing.Color.SpringGreen;
            this.btnListarTodos.FlatAppearance.BorderSize = 0;
            this.btnListarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTodos.Location = new System.Drawing.Point(665, 543);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(149, 44);
            this.btnListarTodos.TabIndex = 34;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = false;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(840, 543);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(207, 44);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvUsuário);
            this.Controls.Add(this.ckbNome);
            this.Controls.Add(this.ckbCodigo);
            this.Controls.Add(this.gpbConsultaNome);
            this.Controls.Add(this.gpbConsultaCodigo);
            this.Controls.Add(this.lblMessage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaUsuario";
            this.Text = "FrmConsultaUsuario";
            this.Load += new System.EventHandler(this.FrmConsultaUsuario_Load);
            this.gpbConsultaNome.ResumeLayout(false);
            this.gpbConsultaNome.PerformLayout();
            this.gpbConsultaCodigo.ResumeLayout(false);
            this.gpbConsultaCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuário)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.GroupBox gpbConsultaNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbConsultaCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.CheckBox ckbCodigo;
        private System.Windows.Forms.DataGridView dgvUsuário;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnConsultar;
    }
}