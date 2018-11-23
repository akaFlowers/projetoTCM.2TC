namespace projetoCuboMagico.tela.Cadastro
{
    partial class FrmCadastroUsuario
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.cboTipoAcesso = new System.Windows.Forms.ComboBox();
            this.gpbCadastrarUsuario = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ckbExibirSenha = new System.Windows.Forms.CheckBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblUsuarioCadastrado = new System.Windows.Forms.Label();
            this.lblFuncionariosCadastrados = new System.Windows.Forms.Label();
            this.gpbCadastrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(334, 39);
            this.lblMessage1.TabIndex = 0;
            this.lblMessage1.Text = "Cadastro de Usuário";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(840, 543);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(207, 44);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(96, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "*Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(101, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(306, 16);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(88, 25);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "*Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(311, 44);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFunc.Location = new System.Drawing.Point(96, 96);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(184, 25);
            this.lblCodFunc.TabIndex = 7;
            this.lblCodFunc.Text = "*Cod Funcionario:";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(101, 132);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(178, 20);
            this.txtCodFunc.TabIndex = 2;
            this.txtCodFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFunc_KeyPress);
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcesso.Location = new System.Drawing.Point(306, 96);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(151, 25);
            this.lblNivelAcesso.TabIndex = 9;
            this.lblNivelAcesso.Text = "*Nivel Acesso:";
            // 
            // cboTipoAcesso
            // 
            this.cboTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAcesso.FormattingEnabled = true;
            this.cboTipoAcesso.Items.AddRange(new object[] {
            "Funcionario",
            "Administrador"});
            this.cboTipoAcesso.Location = new System.Drawing.Point(311, 132);
            this.cboTipoAcesso.Name = "cboTipoAcesso";
            this.cboTipoAcesso.Size = new System.Drawing.Size(178, 21);
            this.cboTipoAcesso.TabIndex = 3;
            // 
            // gpbCadastrarUsuario
            // 
            this.gpbCadastrarUsuario.Controls.Add(this.lblCodigo);
            this.gpbCadastrarUsuario.Controls.Add(this.txtCodigo);
            this.gpbCadastrarUsuario.Controls.Add(this.ckbExibirSenha);
            this.gpbCadastrarUsuario.Controls.Add(this.cboTipoAcesso);
            this.gpbCadastrarUsuario.Controls.Add(this.lblUsuario);
            this.gpbCadastrarUsuario.Controls.Add(this.lblNivelAcesso);
            this.gpbCadastrarUsuario.Controls.Add(this.txtUsuario);
            this.gpbCadastrarUsuario.Controls.Add(this.txtCodFunc);
            this.gpbCadastrarUsuario.Controls.Add(this.lblSenha);
            this.gpbCadastrarUsuario.Controls.Add(this.lblCodFunc);
            this.gpbCadastrarUsuario.Controls.Add(this.txtSenha);
            this.gpbCadastrarUsuario.Location = new System.Drawing.Point(39, 150);
            this.gpbCadastrarUsuario.Name = "gpbCadastrarUsuario";
            this.gpbCadastrarUsuario.Size = new System.Drawing.Size(1008, 166);
            this.gpbCadastrarUsuario.TabIndex = 11;
            this.gpbCadastrarUsuario.TabStop = false;
            this.gpbCadastrarUsuario.Text = "Cadastrar Usuário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // ckbExibirSenha
            // 
            this.ckbExibirSenha.AutoSize = true;
            this.ckbExibirSenha.Location = new System.Drawing.Point(495, 46);
            this.ckbExibirSenha.Name = "ckbExibirSenha";
            this.ckbExibirSenha.Size = new System.Drawing.Size(83, 17);
            this.ckbExibirSenha.TabIndex = 4;
            this.ckbExibirSenha.Text = "Exibir senha";
            this.ckbExibirSenha.UseVisualStyleBackColor = true;
            this.ckbExibirSenha.CheckedChanged += new System.EventHandler(this.ckbExibirSenha_CheckedChanged);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(534, 380);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(518, 144);
            this.dgvFuncionarios.TabIndex = 12;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(39, 380);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(472, 144);
            this.dgvUsuarios.TabIndex = 15;
            // 
            // lblUsuarioCadastrado
            // 
            this.lblUsuarioCadastrado.AutoSize = true;
            this.lblUsuarioCadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCadastrado.Location = new System.Drawing.Point(36, 359);
            this.lblUsuarioCadastrado.Name = "lblUsuarioCadastrado";
            this.lblUsuarioCadastrado.Size = new System.Drawing.Size(154, 18);
            this.lblUsuarioCadastrado.TabIndex = 16;
            this.lblUsuarioCadastrado.Text = "Usuarios cadastrados";
            // 
            // lblFuncionariosCadastrados
            // 
            this.lblFuncionariosCadastrados.AutoSize = true;
            this.lblFuncionariosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionariosCadastrados.Location = new System.Drawing.Point(531, 359);
            this.lblFuncionariosCadastrados.Name = "lblFuncionariosCadastrados";
            this.lblFuncionariosCadastrados.Size = new System.Drawing.Size(180, 18);
            this.lblFuncionariosCadastrados.TabIndex = 17;
            this.lblFuncionariosCadastrados.Text = "Funcionários cadastrados";
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.lblFuncionariosCadastrados);
            this.Controls.Add(this.lblUsuarioCadastrado);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.gpbCadastrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroUsuario";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            this.gpbCadastrarUsuario.ResumeLayout(false);
            this.gpbCadastrarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.ComboBox cboTipoAcesso;
        private System.Windows.Forms.GroupBox gpbCadastrarUsuario;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.CheckBox ckbExibirSenha;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblUsuarioCadastrado;
        private System.Windows.Forms.Label lblFuncionariosCadastrados;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}