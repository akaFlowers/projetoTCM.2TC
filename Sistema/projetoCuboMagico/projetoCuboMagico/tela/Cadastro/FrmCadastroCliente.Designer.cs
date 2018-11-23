namespace projetoCuboMagico.tela.Cadastro
{
    partial class FrmCadastroCliente
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
            this.gbpInfoPessoal = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mkdCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.mkdDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mkdCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboEstCivil = new System.Windows.Forms.ComboBox();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.gpbEstado = new System.Windows.Forms.GroupBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mkdCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.ckbAventura = new System.Windows.Forms.CheckBox();
            this.ckbRomance = new System.Windows.Forms.CheckBox();
            this.ckbInfantoJuvenil = new System.Windows.Forms.CheckBox();
            this.ckbHistoria = new System.Windows.Forms.CheckBox();
            this.ckbTerror = new System.Windows.Forms.CheckBox();
            this.ckbTodos = new System.Windows.Forms.CheckBox();
            this.gbpInfoPessoal.SuspendLayout();
            this.gpbEstado.SuspendLayout();
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
            this.lblMessage1.Size = new System.Drawing.Size(322, 39);
            this.lblMessage1.TabIndex = 4;
            this.lblMessage1.Text = "Cadastro de Cliente";
            // 
            // gbpInfoPessoal
            // 
            this.gbpInfoPessoal.Controls.Add(this.lblCodigo);
            this.gbpInfoPessoal.Controls.Add(this.txtCodigo);
            this.gbpInfoPessoal.Controls.Add(this.lblNome);
            this.gbpInfoPessoal.Controls.Add(this.txtNome);
            this.gbpInfoPessoal.Controls.Add(this.lblCpf);
            this.gbpInfoPessoal.Controls.Add(this.mkdCpf);
            this.gbpInfoPessoal.Controls.Add(this.lblEmail);
            this.gbpInfoPessoal.Controls.Add(this.txtEmail);
            this.gbpInfoPessoal.Controls.Add(this.lblDataNascimento);
            this.gbpInfoPessoal.Controls.Add(this.mkdDataNascimento);
            this.gbpInfoPessoal.Controls.Add(this.lblTelefone);
            this.gbpInfoPessoal.Controls.Add(this.mkdTelefone);
            this.gbpInfoPessoal.Controls.Add(this.lblCelular);
            this.gbpInfoPessoal.Controls.Add(this.mkdCelular);
            this.gbpInfoPessoal.Controls.Add(this.lblSexo);
            this.gbpInfoPessoal.Controls.Add(this.cboSexo);
            this.gbpInfoPessoal.Controls.Add(this.cboEstCivil);
            this.gbpInfoPessoal.Controls.Add(this.lblEstCivil);
            this.gbpInfoPessoal.Location = new System.Drawing.Point(30, 108);
            this.gbpInfoPessoal.Name = "gbpInfoPessoal";
            this.gbpInfoPessoal.Size = new System.Drawing.Size(921, 164);
            this.gbpInfoPessoal.TabIndex = 0;
            this.gbpInfoPessoal.TabStop = false;
            this.gbpInfoPessoal.Text = "Informações pessoais";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(19, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(84, 39);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(553, 39);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 16);
            this.lblCpf.TabIndex = 14;
            this.lblCpf.Text = "*CPF:";
            // 
            // mkdCpf
            // 
            this.mkdCpf.Location = new System.Drawing.Point(556, 59);
            this.mkdCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mkdCpf.Mask = "###.###.###-##";
            this.mkdCpf.Name = "mkdCpf";
            this.mkdCpf.Size = new System.Drawing.Size(132, 20);
            this.mkdCpf.TabIndex = 2;
            this.mkdCpf.Click += new System.EventHandler(this.mkdCpf_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(693, 39);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "*Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(696, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(19, 98);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(88, 16);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "*Nascimento:";
            // 
            // mkdDataNascimento
            // 
            this.mkdDataNascimento.Location = new System.Drawing.Point(22, 118);
            this.mkdDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.mkdDataNascimento.Mask = "##/##/####";
            this.mkdDataNascimento.Name = "mkdDataNascimento";
            this.mkdDataNascimento.Size = new System.Drawing.Size(132, 20);
            this.mkdDataNascimento.TabIndex = 4;
            this.mkdDataNascimento.Click += new System.EventHandler(this.mkdDataNascimento_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(164, 98);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 16);
            this.lblTelefone.TabIndex = 19;
            this.lblTelefone.Text = "*Telefone:";
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Location = new System.Drawing.Point(162, 118);
            this.mkdTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mkdTelefone.Mask = "(##)####-####";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(132, 20);
            this.mkdTelefone.TabIndex = 5;
            this.mkdTelefone.Click += new System.EventHandler(this.mkdTelefone_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(305, 98);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 16);
            this.lblCelular.TabIndex = 21;
            this.lblCelular.Text = "*Celular:";
            // 
            // mkdCelular
            // 
            this.mkdCelular.Location = new System.Drawing.Point(302, 118);
            this.mkdCelular.Margin = new System.Windows.Forms.Padding(4);
            this.mkdCelular.Mask = "(##)#####-####";
            this.mkdCelular.Name = "mkdCelular";
            this.mkdCelular.Size = new System.Drawing.Size(132, 20);
            this.mkdCelular.TabIndex = 6;
            this.mkdCelular.Click += new System.EventHandler(this.mkdCelular_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(445, 98);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 16);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "*Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(442, 116);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(142, 21);
            this.cboSexo.TabIndex = 7;
            // 
            // cboEstCivil
            // 
            this.cboEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstCivil.FormattingEnabled = true;
            this.cboEstCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)",
            "Separado(a)"});
            this.cboEstCivil.Location = new System.Drawing.Point(599, 118);
            this.cboEstCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstCivil.Name = "cboEstCivil";
            this.cboEstCivil.Size = new System.Drawing.Size(300, 21);
            this.cboEstCivil.TabIndex = 8;
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(596, 98);
            this.lblEstCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(87, 16);
            this.lblEstCivil.TabIndex = 12;
            this.lblEstCivil.Text = "*Estado Civil:";
            // 
            // gpbEstado
            // 
            this.gpbEstado.Controls.Add(this.lblCidade);
            this.gpbEstado.Controls.Add(this.lblBairro);
            this.gpbEstado.Controls.Add(this.lblComplemento);
            this.gpbEstado.Controls.Add(this.txtComplemento);
            this.gpbEstado.Controls.Add(this.txtBairro);
            this.gpbEstado.Controls.Add(this.txtCidade);
            this.gpbEstado.Controls.Add(this.mkdCep);
            this.gpbEstado.Controls.Add(this.txtEndereco);
            this.gpbEstado.Controls.Add(this.txtNumero);
            this.gpbEstado.Controls.Add(this.cboEstado);
            this.gpbEstado.Controls.Add(this.txtReferencia);
            this.gpbEstado.Controls.Add(this.lblReferencia);
            this.gpbEstado.Controls.Add(this.lblCep);
            this.gpbEstado.Controls.Add(this.lblEndereco);
            this.gpbEstado.Controls.Add(this.lblNumero);
            this.gpbEstado.Controls.Add(this.lblEstado);
            this.gpbEstado.Location = new System.Drawing.Point(32, 275);
            this.gpbEstado.Name = "gpbEstado";
            this.gpbEstado.Size = new System.Drawing.Size(921, 163);
            this.gpbEstado.TabIndex = 9;
            this.gpbEstado.TabStop = false;
            this.gpbEstado.Text = "Endereço";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(24, 95);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 16);
            this.lblCidade.TabIndex = 30;
            this.lblCidade.Text = "*Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(164, 95);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 16);
            this.lblBairro.TabIndex = 32;
            this.lblBairro.Text = "*Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(306, 94);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(95, 16);
            this.lblComplemento.TabIndex = 34;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(309, 114);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(343, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(162, 115);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(132, 20);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(23, 115);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(132, 20);
            this.txtCidade.TabIndex = 14;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // mkdCep
            // 
            this.mkdCep.Location = new System.Drawing.Point(23, 50);
            this.mkdCep.Margin = new System.Windows.Forms.Padding(4);
            this.mkdCep.Mask = "#####-###";
            this.mkdCep.Name = "mkdCep";
            this.mkdCep.Size = new System.Drawing.Size(132, 20);
            this.mkdCep.TabIndex = 10;
            this.mkdCep.Click += new System.EventHandler(this.mkdCep_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(163, 51);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(461, 20);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(635, 51);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 20);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas\t",
            "Bahia",
            "Ceará",
            "Distrito Federal ",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe ",
            "Tocantins"});
            this.cboEstado.Location = new System.Drawing.Point(746, 50);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(153, 21);
            this.cboEstado.TabIndex = 13;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(660, 113);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(239, 20);
            this.txtReferencia.TabIndex = 17;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(657, 93);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(77, 16);
            this.lblReferencia.TabIndex = 36;
            this.lblReferencia.Text = "Referência:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(20, 28);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(43, 16);
            this.lblCep.TabIndex = 22;
            this.lblCep.Text = "*CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(163, 31);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(75, 16);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "*Endereço:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(632, 28);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(64, 16);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "*Número:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(747, 31);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "*Estado:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(665, 543);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 44);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.SpringGreen;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(840, 543);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(207, 44);
            this.btnProximo.TabIndex = 25;
            this.btnProximo.Text = "Cadastrar";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.ckbAventura);
            this.gpbGenero.Controls.Add(this.ckbRomance);
            this.gpbGenero.Controls.Add(this.ckbInfantoJuvenil);
            this.gpbGenero.Controls.Add(this.ckbHistoria);
            this.gpbGenero.Controls.Add(this.ckbTerror);
            this.gpbGenero.Controls.Add(this.ckbTodos);
            this.gpbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGenero.Location = new System.Drawing.Point(34, 454);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(919, 59);
            this.gpbGenero.TabIndex = 18;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "*Escolha o gênero dos livros";
            // 
            // ckbAventura
            // 
            this.ckbAventura.AutoSize = true;
            this.ckbAventura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAventura.Location = new System.Drawing.Point(454, 25);
            this.ckbAventura.Name = "ckbAventura";
            this.ckbAventura.Size = new System.Drawing.Size(92, 24);
            this.ckbAventura.TabIndex = 22;
            this.ckbAventura.Text = "Aventura";
            this.ckbAventura.UseVisualStyleBackColor = true;
            this.ckbAventura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbAventura_KeyPress);
            // 
            // ckbRomance
            // 
            this.ckbRomance.AutoSize = true;
            this.ckbRomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRomance.Location = new System.Drawing.Point(821, 25);
            this.ckbRomance.Name = "ckbRomance";
            this.ckbRomance.Size = new System.Drawing.Size(92, 22);
            this.ckbRomance.TabIndex = 24;
            this.ckbRomance.Text = "Romance";
            this.ckbRomance.UseVisualStyleBackColor = true;
            this.ckbRomance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbRomance_KeyPress);
            // 
            // ckbInfantoJuvenil
            // 
            this.ckbInfantoJuvenil.AutoSize = true;
            this.ckbInfantoJuvenil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbInfantoJuvenil.Location = new System.Drawing.Point(618, 25);
            this.ckbInfantoJuvenil.Name = "ckbInfantoJuvenil";
            this.ckbInfantoJuvenil.Size = new System.Drawing.Size(116, 22);
            this.ckbInfantoJuvenil.TabIndex = 23;
            this.ckbInfantoJuvenil.Text = "Infanto-juvenil";
            this.ckbInfantoJuvenil.UseVisualStyleBackColor = true;
            this.ckbInfantoJuvenil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbInfantoJuvenil_KeyPress);
            // 
            // ckbHistoria
            // 
            this.ckbHistoria.AutoSize = true;
            this.ckbHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHistoria.Location = new System.Drawing.Point(300, 23);
            this.ckbHistoria.Name = "ckbHistoria";
            this.ckbHistoria.Size = new System.Drawing.Size(82, 24);
            this.ckbHistoria.TabIndex = 21;
            this.ckbHistoria.Text = "Historia";
            this.ckbHistoria.UseVisualStyleBackColor = true;
            this.ckbHistoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbHistoria_KeyPress);
            // 
            // ckbTerror
            // 
            this.ckbTerror.AutoSize = true;
            this.ckbTerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTerror.Location = new System.Drawing.Point(167, 23);
            this.ckbTerror.Name = "ckbTerror";
            this.ckbTerror.Size = new System.Drawing.Size(70, 24);
            this.ckbTerror.TabIndex = 20;
            this.ckbTerror.Text = "Terror";
            this.ckbTerror.UseVisualStyleBackColor = true;
            this.ckbTerror.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbTerror_KeyPress);
            // 
            // ckbTodos
            // 
            this.ckbTodos.AutoSize = true;
            this.ckbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTodos.Location = new System.Drawing.Point(30, 23);
            this.ckbTodos.Name = "ckbTodos";
            this.ckbTodos.Size = new System.Drawing.Size(70, 22);
            this.ckbTodos.TabIndex = 19;
            this.ckbTodos.Text = "Todos";
            this.ckbTodos.UseVisualStyleBackColor = true;
            this.ckbTodos.CheckedChanged += new System.EventHandler(this.ckbTodos_CheckedChanged);
            this.ckbTodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbTodos_KeyPress);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.gbpInfoPessoal);
            this.Controls.Add(this.gpbEstado);
            this.Controls.Add(this.lblMessage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.gbpInfoPessoal.ResumeLayout(false);
            this.gbpInfoPessoal.PerformLayout();
            this.gpbEstado.ResumeLayout(false);
            this.gpbEstado.PerformLayout();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.GroupBox gbpInfoPessoal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mkdCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox mkdDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mkdCelular;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboEstCivil;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.GroupBox gpbEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mkdCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProximo;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.CheckBox ckbAventura;
        private System.Windows.Forms.CheckBox ckbRomance;
        private System.Windows.Forms.CheckBox ckbInfantoJuvenil;
        private System.Windows.Forms.CheckBox ckbHistoria;
        private System.Windows.Forms.CheckBox ckbTerror;
        private System.Windows.Forms.CheckBox ckbTodos;
    }
}