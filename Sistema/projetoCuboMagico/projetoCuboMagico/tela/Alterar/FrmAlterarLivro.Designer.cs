namespace projetoCuboMagico.tela.Alterar
{
    partial class FrmAlterarLivro
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.gpbCodLivro = new System.Windows.Forms.GroupBox();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.gpbInfoLivro = new System.Windows.Forms.GroupBox();
            this.lblDataPublicacao = new System.Windows.Forms.Label();
            this.mkdDataPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboEditora = new System.Windows.Forms.ComboBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCapa = new System.Windows.Forms.Label();
            this.cboCapa = new System.Windows.Forms.ComboBox();
            this.lblQtdPaginas = new System.Windows.Forms.Label();
            this.txtQtdPaginas = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gpbCodLivro.SuspendLayout();
            this.gpbInfoLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(840, 543);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(207, 44);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(3, 24);
            this.lblMessage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(296, 39);
            this.lblMessage1.TabIndex = 26;
            this.lblMessage1.Text = "Alteração de Livro";
            // 
            // gpbCodLivro
            // 
            this.gpbCodLivro.Controls.Add(this.txtCodLivro);
            this.gpbCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodLivro.Location = new System.Drawing.Point(29, 85);
            this.gpbCodLivro.Name = "gpbCodLivro";
            this.gpbCodLivro.Size = new System.Drawing.Size(141, 76);
            this.gpbCodLivro.TabIndex = 29;
            this.gpbCodLivro.TabStop = false;
            this.gpbCodLivro.Text = "Digite o codigo do Livro";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(35, 33);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(67, 20);
            this.txtCodLivro.TabIndex = 25;
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBuscarLivro.FlatAppearance.BorderSize = 0;
            this.btnBuscarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLivro.Location = new System.Drawing.Point(176, 115);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarLivro.TabIndex = 28;
            this.btnBuscarLivro.Text = "Buscar Livro";
            this.btnBuscarLivro.UseVisualStyleBackColor = false;
            this.btnBuscarLivro.Click += new System.EventHandler(this.btnBuscarLivro_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(886, 514);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(99, 20);
            this.txtValor.TabIndex = 32;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(883, 494);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(48, 16);
            this.lblValor.TabIndex = 34;
            this.lblValor.Text = "*Valor:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(786, 494);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 16);
            this.lblQuantidade.TabIndex = 33;
            this.lblQuantidade.Text = "*Quantidade:";
            this.lblQuantidade.Visible = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(789, 514);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(79, 20);
            this.txtQuantidade.TabIndex = 31;
            this.txtQuantidade.Visible = false;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // gpbInfoLivro
            // 
            this.gpbInfoLivro.Controls.Add(this.lblDataPublicacao);
            this.gpbInfoLivro.Controls.Add(this.mkdDataPublicacao);
            this.gpbInfoLivro.Controls.Add(this.txtSinopse);
            this.gpbInfoLivro.Controls.Add(this.lblSinopse);
            this.gpbInfoLivro.Controls.Add(this.lblGenero);
            this.gpbInfoLivro.Controls.Add(this.cboGenero);
            this.gpbInfoLivro.Controls.Add(this.cboEditora);
            this.gpbInfoLivro.Controls.Add(this.lblEditora);
            this.gpbInfoLivro.Controls.Add(this.txtAutor);
            this.gpbInfoLivro.Controls.Add(this.lblAutor);
            this.gpbInfoLivro.Controls.Add(this.lblCapa);
            this.gpbInfoLivro.Controls.Add(this.cboCapa);
            this.gpbInfoLivro.Controls.Add(this.lblQtdPaginas);
            this.gpbInfoLivro.Controls.Add(this.txtQtdPaginas);
            this.gpbInfoLivro.Controls.Add(this.lblNome);
            this.gpbInfoLivro.Controls.Add(this.txtNome);
            this.gpbInfoLivro.Controls.Add(this.lblCodigo);
            this.gpbInfoLivro.Controls.Add(this.txtCodigo);
            this.gpbInfoLivro.Enabled = false;
            this.gpbInfoLivro.Location = new System.Drawing.Point(30, 173);
            this.gpbInfoLivro.Name = "gpbInfoLivro";
            this.gpbInfoLivro.Size = new System.Drawing.Size(921, 318);
            this.gpbInfoLivro.TabIndex = 30;
            this.gpbInfoLivro.TabStop = false;
            this.gpbInfoLivro.Text = "Informações do livro";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPublicacao.Location = new System.Drawing.Point(344, 94);
            this.lblDataPublicacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(113, 16);
            this.lblDataPublicacao.TabIndex = 23;
            this.lblDataPublicacao.Text = "*Data Publicação";
            // 
            // mkdDataPublicacao
            // 
            this.mkdDataPublicacao.Location = new System.Drawing.Point(347, 113);
            this.mkdDataPublicacao.Mask = "##/##/####";
            this.mkdDataPublicacao.Name = "mkdDataPublicacao";
            this.mkdDataPublicacao.Size = new System.Drawing.Size(105, 20);
            this.mkdDataPublicacao.TabIndex = 6;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(7, 168);
            this.txtSinopse.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(904, 127);
            this.txtSinopse.TabIndex = 7;
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(6, 148);
            this.lblSinopse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(66, 16);
            this.lblSinopse.TabIndex = 11;
            this.lblSinopse.Text = "*Sinopse:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(221, 93);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 16);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "*Gênero";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "TERROR",
            "INFANTO-JUVENIL",
            "HISTORIA",
            "ROMANCE",
            "AVENTURA"});
            this.cboGenero.Location = new System.Drawing.Point(220, 112);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 5;
            // 
            // cboEditora
            // 
            this.cboEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.Items.AddRange(new object[] {
            "",
            ""});
            this.cboEditora.Location = new System.Drawing.Point(6, 111);
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(121, 21);
            this.cboEditora.TabIndex = 4;
            this.cboEditora.DropDown += new System.EventHandler(this.cboEditora_DropDown);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(3, 92);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(59, 16);
            this.lblEditora.TabIndex = 18;
            this.lblEditora.Text = "*Editora:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(669, 36);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(245, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(669, 17);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(47, 16);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "*Autor:";
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(538, 17);
            this.lblCapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(49, 16);
            this.lblCapa.TabIndex = 15;
            this.lblCapa.Text = "*Capa:";
            // 
            // cboCapa
            // 
            this.cboCapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapa.FormattingEnabled = true;
            this.cboCapa.Items.AddRange(new object[] {
            "Brochura",
            "Hardcover",
            "Jacket"});
            this.cboCapa.Location = new System.Drawing.Point(541, 36);
            this.cboCapa.Name = "cboCapa";
            this.cboCapa.Size = new System.Drawing.Size(121, 21);
            this.cboCapa.TabIndex = 2;
            // 
            // lblQtdPaginas
            // 
            this.lblQtdPaginas.AutoSize = true;
            this.lblQtdPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdPaginas.Location = new System.Drawing.Point(131, 93);
            this.lblQtdPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdPaginas.Name = "lblQtdPaginas";
            this.lblQtdPaginas.Size = new System.Drawing.Size(87, 16);
            this.lblQtdPaginas.TabIndex = 13;
            this.lblQtdPaginas.Text = "*Qtd Paginas";
            // 
            // txtQtdPaginas
            // 
            this.txtQtdPaginas.Location = new System.Drawing.Point(134, 112);
            this.txtQtdPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdPaginas.Name = "txtQtdPaginas";
            this.txtQtdPaginas.Size = new System.Drawing.Size(79, 20);
            this.txtQtdPaginas.TabIndex = 5;
            this.txtQtdPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdPaginas_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(70, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 16);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // FrmAlterarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.gpbInfoLivro);
            this.Controls.Add(this.gpbCodLivro);
            this.Controls.Add(this.btnBuscarLivro);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarLivro";
            this.Text = "FrmAlterarLivro";
            this.Load += new System.EventHandler(this.FrmAlterarLivro_Load);
            this.gpbCodLivro.ResumeLayout(false);
            this.gpbCodLivro.PerformLayout();
            this.gpbInfoLivro.ResumeLayout(false);
            this.gpbInfoLivro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.GroupBox gpbCodLivro;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Button btnBuscarLivro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox gpbInfoLivro;
        private System.Windows.Forms.Label lblDataPublicacao;
        private System.Windows.Forms.MaskedTextBox mkdDataPublicacao;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.ComboBox cboCapa;
        private System.Windows.Forms.Label lblQtdPaginas;
        private System.Windows.Forms.TextBox txtQtdPaginas;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}