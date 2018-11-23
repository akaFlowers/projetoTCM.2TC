namespace projetoCuboMagico.tela.Alterar
{
    partial class FrmAlterarUsuario
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
            this.gpbCadastrarUsuario = new System.Windows.Forms.GroupBox();
            this.cboTipoAcesso = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.gpbNomeUsuario = new System.Windows.Forms.GroupBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gpbCadastrarUsuario.SuspendLayout();
            this.gpbNomeUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadastrarUsuario
            // 
            this.gpbCadastrarUsuario.Controls.Add(this.cboTipoAcesso);
            this.gpbCadastrarUsuario.Controls.Add(this.lblUsuario);
            this.gpbCadastrarUsuario.Controls.Add(this.lblNivelAcesso);
            this.gpbCadastrarUsuario.Controls.Add(this.txtUsuario);
            this.gpbCadastrarUsuario.Controls.Add(this.txtCodFunc);
            this.gpbCadastrarUsuario.Controls.Add(this.lblSenha);
            this.gpbCadastrarUsuario.Controls.Add(this.lblCodFunc);
            this.gpbCadastrarUsuario.Controls.Add(this.txtSenha);
            this.gpbCadastrarUsuario.Enabled = false;
            this.gpbCadastrarUsuario.Location = new System.Drawing.Point(29, 172);
            this.gpbCadastrarUsuario.Name = "gpbCadastrarUsuario";
            this.gpbCadastrarUsuario.Size = new System.Drawing.Size(956, 166);
            this.gpbCadastrarUsuario.TabIndex = 12;
            this.gpbCadastrarUsuario.TabStop = false;
            this.gpbCadastrarUsuario.Text = "Alterar Usuário";
            // 
            // cboTipoAcesso
            // 
            this.cboTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAcesso.FormattingEnabled = true;
            this.cboTipoAcesso.Items.AddRange(new object[] {
            "Funcionario",
            "Administrador"});
            this.cboTipoAcesso.Location = new System.Drawing.Point(230, 132);
            this.cboTipoAcesso.Name = "cboTipoAcesso";
            this.cboTipoAcesso.Size = new System.Drawing.Size(178, 21);
            this.cboTipoAcesso.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "*Usuario:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcesso.Location = new System.Drawing.Point(225, 96);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(151, 25);
            this.lblNivelAcesso.TabIndex = 9;
            this.lblNivelAcesso.Text = "*Nivel Acesso:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(20, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(20, 132);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(178, 20);
            this.txtCodFunc.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(225, 16);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(88, 25);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "*Senha:";
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFunc.Location = new System.Drawing.Point(15, 96);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(184, 25);
            this.lblCodFunc.TabIndex = 7;
            this.lblCodFunc.Text = "*Cod Funcionario:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(230, 44);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(349, 39);
            this.lblMessage1.TabIndex = 13;
            this.lblMessage1.Text = "Alteração  de Usuário";
            // 
            // gpbNomeUsuario
            // 
            this.gpbNomeUsuario.Controls.Add(this.txtNomeUsuario);
            this.gpbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomeUsuario.Location = new System.Drawing.Point(29, 80);
            this.gpbNomeUsuario.Name = "gpbNomeUsuario";
            this.gpbNomeUsuario.Size = new System.Drawing.Size(141, 76);
            this.gpbNomeUsuario.TabIndex = 29;
            this.gpbNomeUsuario.TabStop = false;
            this.gpbNomeUsuario.Text = "Digite o Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(25, 33);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(96, 20);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(177, 110);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarUsuario.TabIndex = 28;
            this.btnBuscarUsuario.Text = "Buscar Usuário";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(840, 543);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(207, 44);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(29, 360);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(956, 150);
            this.dgvUsuario.TabIndex = 31;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(655, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 32;
            this.txtCodigo.Visible = false;
            // 
            // FrmAlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpbNomeUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.gpbCadastrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarUsuario";
            this.Text = "FrmAlterarUsuario";
            this.Load += new System.EventHandler(this.FrmAlterarUsuario_Load);
            this.gpbCadastrarUsuario.ResumeLayout(false);
            this.gpbCadastrarUsuario.PerformLayout();
            this.gpbNomeUsuario.ResumeLayout(false);
            this.gpbNomeUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastrarUsuario;
        private System.Windows.Forms.ComboBox cboTipoAcesso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.GroupBox gpbNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}