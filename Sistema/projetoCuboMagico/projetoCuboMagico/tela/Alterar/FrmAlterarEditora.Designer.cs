namespace projetoCuboMagico.tela.Alterar
{
    partial class FrmAlterarEditora
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscarEditora = new System.Windows.Forms.Button();
            this.gpbCodCliente = new System.Windows.Forms.GroupBox();
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.gpbCadastrarEditora = new System.Windows.Forms.GroupBox();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkdCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gpbCodCliente.SuspendLayout();
            this.gpbCadastrarEditora.SuspendLayout();
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
            this.lblMessage1.TabIndex = 101;
            this.lblMessage1.Text = "Alteração de Editora";
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
            this.btnAlterar.TabIndex = 102;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscarEditora
            // 
            this.btnBuscarEditora.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBuscarEditora.FlatAppearance.BorderSize = 0;
            this.btnBuscarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEditora.Location = new System.Drawing.Point(158, 114);
            this.btnBuscarEditora.Name = "btnBuscarEditora";
            this.btnBuscarEditora.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarEditora.TabIndex = 103;
            this.btnBuscarEditora.Text = "Buscar Editora";
            this.btnBuscarEditora.UseVisualStyleBackColor = false;
            this.btnBuscarEditora.Click += new System.EventHandler(this.btnBuscarEditora_Click);
            // 
            // gpbCodCliente
            // 
            this.gpbCodCliente.Controls.Add(this.txtCodEditora);
            this.gpbCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodCliente.Location = new System.Drawing.Point(38, 79);
            this.gpbCodCliente.Name = "gpbCodCliente";
            this.gpbCodCliente.Size = new System.Drawing.Size(112, 76);
            this.gpbCodCliente.TabIndex = 104;
            this.gpbCodCliente.TabStop = false;
            this.gpbCodCliente.Text = "Digite o codigo da Editora";
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Location = new System.Drawing.Point(15, 36);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.Size = new System.Drawing.Size(79, 20);
            this.txtCodEditora.TabIndex = 0;
            // 
            // gpbCadastrarEditora
            // 
            this.gpbCadastrarEditora.Controls.Add(this.mkdTelefone);
            this.gpbCadastrarEditora.Controls.Add(this.lblPais);
            this.gpbCadastrarEditora.Controls.Add(this.cboPais);
            this.gpbCadastrarEditora.Controls.Add(this.lblTelefone);
            this.gpbCadastrarEditora.Controls.Add(this.mkdCnpj);
            this.gpbCadastrarEditora.Controls.Add(this.lblCnpj);
            this.gpbCadastrarEditora.Controls.Add(this.txtEmail);
            this.gpbCadastrarEditora.Controls.Add(this.lblEmail);
            this.gpbCadastrarEditora.Controls.Add(this.lblNome);
            this.gpbCadastrarEditora.Controls.Add(this.txtNome);
            this.gpbCadastrarEditora.Controls.Add(this.lblCodigo);
            this.gpbCadastrarEditora.Controls.Add(this.txtCodigo);
            this.gpbCadastrarEditora.Enabled = false;
            this.gpbCadastrarEditora.Location = new System.Drawing.Point(38, 239);
            this.gpbCadastrarEditora.Name = "gpbCadastrarEditora";
            this.gpbCadastrarEditora.Size = new System.Drawing.Size(911, 134);
            this.gpbCadastrarEditora.TabIndex = 105;
            this.gpbCadastrarEditora.TabStop = false;
            this.gpbCadastrarEditora.Text = "Editora";
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Location = new System.Drawing.Point(728, 44);
            this.mkdTelefone.Mask = "(##)####-####";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(163, 20);
            this.mkdTelefone.TabIndex = 18;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(361, 71);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 20);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "País";
            // 
            // cboPais
            // 
            this.cboPais.BackColor = System.Drawing.Color.White;
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Items.AddRange(new object[] {
            "Brasil",
            "Estados Unidos",
            "China",
            "Japão",
            "Rússia ",
            "México",
            "Alemanha",
            "Portugal",
            "Espanha",
            "Reino Unidos",
            "Republica do Congo",
            "Angola"});
            this.cboPais.Location = new System.Drawing.Point(365, 94);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(169, 21);
            this.cboPais.TabIndex = 16;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(723, 21);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mkdCnpj
            // 
            this.mkdCnpj.Location = new System.Drawing.Point(541, 44);
            this.mkdCnpj.Mask = "##.###.###/####-##";
            this.mkdCnpj.Name = "mkdCnpj";
            this.mkdCnpj.Size = new System.Drawing.Size(180, 20);
            this.mkdCnpj.TabIndex = 13;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(537, 21);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(53, 20);
            this.lblCnpj.TabIndex = 12;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(347, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 70);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(69, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 21);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 45);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // FrmAlterarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.gpbCadastrarEditora);
            this.Controls.Add(this.btnBuscarEditora);
            this.Controls.Add(this.gpbCodCliente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblMessage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarEditora";
            this.Text = "FrmAlterarEditora";
            this.gpbCodCliente.ResumeLayout(false);
            this.gpbCodCliente.PerformLayout();
            this.gpbCadastrarEditora.ResumeLayout(false);
            this.gpbCadastrarEditora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscarEditora;
        private System.Windows.Forms.GroupBox gpbCodCliente;
        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.GroupBox gpbCadastrarEditora;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mkdCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}