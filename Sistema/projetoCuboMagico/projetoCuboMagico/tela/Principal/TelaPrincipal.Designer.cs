namespace projetoCuboMagico
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.btnConsultarLivro = new System.Windows.Forms.Button();
            this.btnConsultarEditora = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblLogo2 = new System.Windows.Forms.Label();
            this.lblLogo1 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlCadastrar = new System.Windows.Forms.Panel();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnCadastrarEditora = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.lblUsuarioConectado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnAlterarLivro = new System.Windows.Forms.Button();
            this.btnAlterarEditora = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.pnlConsultar.SuspendLayout();
            this.pnlEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlCadastrar.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBase.Location = new System.Drawing.Point(263, 75);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1084, 610);
            this.pnlBase.TabIndex = 1;
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlConsultar.Controls.Add(this.btnConsultarLivro);
            this.pnlConsultar.Controls.Add(this.btnConsultarEditora);
            this.pnlConsultar.Controls.Add(this.btnConsultarFuncionario);
            this.pnlConsultar.Controls.Add(this.btnConsultarProduto);
            this.pnlConsultar.Controls.Add(this.btnConsultarCliente);
            this.pnlConsultar.Controls.Add(this.btnConsultarUsuario);
            this.pnlConsultar.Location = new System.Drawing.Point(677, 40);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(204, 241);
            this.pnlConsultar.TabIndex = 11;
            this.pnlConsultar.Visible = false;
            this.pnlConsultar.MouseLeave += new System.EventHandler(this.pnlConsultar_MouseLeave);
            // 
            // btnConsultarLivro
            // 
            this.btnConsultarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarLivro.FlatAppearance.BorderSize = 0;
            this.btnConsultarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLivro.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLivro.Image = global::projetoCuboMagico.Properties.Resources._1055107_24_1_;
            this.btnConsultarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarLivro.Location = new System.Drawing.Point(0, 42);
            this.btnConsultarLivro.Name = "btnConsultarLivro";
            this.btnConsultarLivro.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarLivro.TabIndex = 14;
            this.btnConsultarLivro.Text = " &Livro";
            this.btnConsultarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarLivro.UseVisualStyleBackColor = false;
            this.btnConsultarLivro.Click += new System.EventHandler(this.btnConsultarLivro_Click);
            // 
            // btnConsultarEditora
            // 
            this.btnConsultarEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarEditora.FlatAppearance.BorderSize = 0;
            this.btnConsultarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEditora.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEditora.Image = global::projetoCuboMagico.Properties.Resources._1054976_24;
            this.btnConsultarEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEditora.Location = new System.Drawing.Point(0, 198);
            this.btnConsultarEditora.Name = "btnConsultarEditora";
            this.btnConsultarEditora.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarEditora.TabIndex = 11;
            this.btnConsultarEditora.Text = " &Editora";
            this.btnConsultarEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarEditora.UseVisualStyleBackColor = false;
            this.btnConsultarEditora.Click += new System.EventHandler(this.btnConsultarEditora_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnConsultarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Image = global::projetoCuboMagico.Properties.Resources._1055019_24;
            this.btnConsultarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(0, 120);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarFuncionario.TabIndex = 10;
            this.btnConsultarFuncionario.Text = " &Funcionário";
            this.btnConsultarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarProduto.FlatAppearance.BorderSize = 0;
            this.btnConsultarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProduto.Image = global::projetoCuboMagico.Properties.Resources.if_dolly_1055070;
            this.btnConsultarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProduto.Location = new System.Drawing.Point(0, 81);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarProduto.TabIndex = 9;
            this.btnConsultarProduto.Text = " &Produto";
            this.btnConsultarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarProduto.UseVisualStyleBackColor = false;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCliente.Image = global::projetoCuboMagico.Properties.Resources._1054988_241;
            this.btnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.Location = new System.Drawing.Point(0, 3);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarCliente.TabIndex = 8;
            this.btnConsultarCliente.Text = " &Cliente";
            this.btnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultarUsuario.FlatAppearance.BorderSize = 0;
            this.btnConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarUsuario.Image = global::projetoCuboMagico.Properties.Resources._1055000_24;
            this.btnConsultarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(0, 159);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(200, 39);
            this.btnConsultarUsuario.TabIndex = 7;
            this.btnConsultarUsuario.Text = " &Usuário";
            this.btnConsultarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarUsuario.UseVisualStyleBackColor = false;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlTopo.Location = new System.Drawing.Point(205, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1163, 17);
            this.pnlTopo.TabIndex = 2;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlEsquerda.Controls.Add(this.btnAlterar);
            this.pnlEsquerda.Controls.Add(this.lblLogo2);
            this.pnlEsquerda.Controls.Add(this.lblLogo1);
            this.pnlEsquerda.Controls.Add(this.pcbLogo);
            this.pnlEsquerda.Controls.Add(this.btnAjuda);
            this.pnlEsquerda.Controls.Add(this.btnCaixa);
            this.pnlEsquerda.Controls.Add(this.btnInicio);
            this.pnlEsquerda.Controls.Add(this.btnConsultar);
            this.pnlEsquerda.Controls.Add(this.btnCadastrar);
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(206, 730);
            this.pnlEsquerda.TabIndex = 4;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = global::projetoCuboMagico.Properties.Resources.if_brush_pencil_1055103;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(0, 489);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(206, 52);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "   &Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.MouseEnter += new System.EventHandler(this.btnAlterar_MouseEnter);
            // 
            // lblLogo2
            // 
            this.lblLogo2.AutoSize = true;
            this.lblLogo2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogo2.Location = new System.Drawing.Point(64, 153);
            this.lblLogo2.Name = "lblLogo2";
            this.lblLogo2.Size = new System.Drawing.Size(81, 21);
            this.lblLogo2.TabIndex = 7;
            this.lblLogo2.Text = "SISTEMA";
            // 
            // lblLogo1
            // 
            this.lblLogo1.AutoSize = true;
            this.lblLogo1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogo1.Location = new System.Drawing.Point(45, 175);
            this.lblLogo1.Name = "lblLogo1";
            this.lblLogo1.Size = new System.Drawing.Size(122, 25);
            this.lblLogo1.TabIndex = 6;
            this.lblLogo1.Text = "Cubo Mágico";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::projetoCuboMagico.Properties.Resources.if_Rubics_Cube_toy_magic_cube_geek_3108922;
            this.pcbLogo.Location = new System.Drawing.Point(39, 23);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(128, 127);
            this.pcbLogo.TabIndex = 5;
            this.pcbLogo.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(0, 704);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(36, 24);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "?";
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = global::projetoCuboMagico.Properties.Resources.if_present_1055001;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 333);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(206, 52);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "   &Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            this.btnCaixa.MouseEnter += new System.EventHandler(this.btnCaixa_MouseEnter);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 281);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(206, 52);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "   &Ínicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::projetoCuboMagico.Properties.Resources.if_zoomin_1054932;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(0, 437);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 52);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "   &Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.MouseEnter += new System.EventHandler(this.btnConsultar_MouseEnter);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = global::projetoCuboMagico.Properties.Resources.if_compose_1055085__1_;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 385);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(223, 52);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "   &Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCadastrar.Controls.Add(this.btnCadastrarLivro);
            this.pnlCadastrar.Controls.Add(this.btnCadastrarEditora);
            this.pnlCadastrar.Controls.Add(this.btnCadastrarUsuario);
            this.pnlCadastrar.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlCadastrar.Controls.Add(this.btnCadastrarProduto);
            this.pnlCadastrar.Controls.Add(this.btnCadastrarCliente);
            this.pnlCadastrar.Location = new System.Drawing.Point(205, 384);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Size = new System.Drawing.Size(205, 242);
            this.pnlCadastrar.TabIndex = 5;
            this.pnlCadastrar.Visible = false;
            this.pnlCadastrar.MouseLeave += new System.EventHandler(this.pnlCadastrar_MouseLeave);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarLivro.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLivro.Image = global::projetoCuboMagico.Properties.Resources._1055107_24_1_;
            this.btnCadastrarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(0, 42);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarLivro.TabIndex = 13;
            this.btnCadastrarLivro.Text = " &Livro";
            this.btnCadastrarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarLivro.UseVisualStyleBackColor = false;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnCadastrarEditora
            // 
            this.btnCadastrarEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarEditora.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEditora.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEditora.Image = global::projetoCuboMagico.Properties.Resources._1054976_24;
            this.btnCadastrarEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEditora.Location = new System.Drawing.Point(0, 198);
            this.btnCadastrarEditora.Name = "btnCadastrarEditora";
            this.btnCadastrarEditora.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarEditora.TabIndex = 12;
            this.btnCadastrarEditora.Text = " &Editora";
            this.btnCadastrarEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarEditora.UseVisualStyleBackColor = false;
            this.btnCadastrarEditora.Click += new System.EventHandler(this.btnCadastrarEditora_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUsuario.Image = global::projetoCuboMagico.Properties.Resources._1055000_24;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(0, 159);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarUsuario.TabIndex = 5;
            this.btnCadastrarUsuario.Text = " &Usuário";
            this.btnCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Image = global::projetoCuboMagico.Properties.Resources._1055019_24;
            this.btnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(0, 120);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarFuncionario.TabIndex = 4;
            this.btnCadastrarFuncionario.Text = " &Funcionário";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Image = global::projetoCuboMagico.Properties.Resources.if_dolly_1055070;
            this.btnCadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(0, 81);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarProduto.TabIndex = 3;
            this.btnCadastrarProduto.Text = " &Produto";
            this.btnCadastrarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Image = global::projetoCuboMagico.Properties.Resources._1054988_24;
            this.btnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(0, 3);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = " &Cliente";
            this.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // lblUsuarioConectado
            // 
            this.lblUsuarioConectado.AutoSize = true;
            this.lblUsuarioConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioConectado.Location = new System.Drawing.Point(216, 706);
            this.lblUsuarioConectado.Name = "lblUsuarioConectado";
            this.lblUsuarioConectado.Size = new System.Drawing.Size(134, 18);
            this.lblUsuarioConectado.TabIndex = 6;
            this.lblUsuarioConectado.Text = "Usuario conectato:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(346, 706);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(132, 18);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Algum ser humano";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(1284, 706);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(80, 18);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1221, 706);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 18);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "00:00:00";
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::projetoCuboMagico.Properties.Resources.Logout_32x32;
            this.btnLogout.Location = new System.Drawing.Point(1274, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(45, 42);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::projetoCuboMagico.Properties.Resources.Fechar_32x32;
            this.btnFechar.Location = new System.Drawing.Point(1321, 17);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 46);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlAlterar.Controls.Add(this.btnAlterarLivro);
            this.pnlAlterar.Controls.Add(this.btnAlterarEditora);
            this.pnlAlterar.Controls.Add(this.btnAlterarFuncionario);
            this.pnlAlterar.Controls.Add(this.btnAlterarProduto);
            this.pnlAlterar.Controls.Add(this.btnAlterarCliente);
            this.pnlAlterar.Controls.Add(this.btnAlterarUsuario);
            this.pnlAlterar.Location = new System.Drawing.Point(362, 40);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(205, 241);
            this.pnlAlterar.TabIndex = 15;
            this.pnlAlterar.Visible = false;
            this.pnlAlterar.MouseLeave += new System.EventHandler(this.pnlAlterar_MouseLeave);
            // 
            // btnAlterarLivro
            // 
            this.btnAlterarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarLivro.FlatAppearance.BorderSize = 0;
            this.btnAlterarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarLivro.ForeColor = System.Drawing.Color.White;
            this.btnAlterarLivro.Image = global::projetoCuboMagico.Properties.Resources._1055107_24_1_;
            this.btnAlterarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarLivro.Location = new System.Drawing.Point(0, 42);
            this.btnAlterarLivro.Name = "btnAlterarLivro";
            this.btnAlterarLivro.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarLivro.TabIndex = 14;
            this.btnAlterarLivro.Text = " &Livro";
            this.btnAlterarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarLivro.UseVisualStyleBackColor = false;
            this.btnAlterarLivro.Click += new System.EventHandler(this.btnAlterarLivro_Click);
            // 
            // btnAlterarEditora
            // 
            this.btnAlterarEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarEditora.FlatAppearance.BorderSize = 0;
            this.btnAlterarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEditora.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEditora.Image = global::projetoCuboMagico.Properties.Resources._1054976_24;
            this.btnAlterarEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEditora.Location = new System.Drawing.Point(0, 198);
            this.btnAlterarEditora.Name = "btnAlterarEditora";
            this.btnAlterarEditora.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarEditora.TabIndex = 11;
            this.btnAlterarEditora.Text = " &Editora";
            this.btnAlterarEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarEditora.UseVisualStyleBackColor = false;
            this.btnAlterarEditora.Click += new System.EventHandler(this.btnAlterarEditora_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFuncionario.Image = global::projetoCuboMagico.Properties.Resources._1055019_24;
            this.btnAlterarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(0, 120);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarFuncionario.TabIndex = 10;
            this.btnAlterarFuncionario.Text = " &Funcionário";
            this.btnAlterarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarFuncionario.UseVisualStyleBackColor = false;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarProduto.FlatAppearance.BorderSize = 0;
            this.btnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAlterarProduto.Image = global::projetoCuboMagico.Properties.Resources.if_dolly_1055070;
            this.btnAlterarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarProduto.Location = new System.Drawing.Point(0, 81);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarProduto.TabIndex = 9;
            this.btnAlterarProduto.Text = " &Produto";
            this.btnAlterarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarProduto.UseVisualStyleBackColor = false;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarCliente.FlatAppearance.BorderSize = 0;
            this.btnAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAlterarCliente.Image = global::projetoCuboMagico.Properties.Resources._1054988_241;
            this.btnAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCliente.Location = new System.Drawing.Point(0, 3);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarCliente.TabIndex = 8;
            this.btnAlterarCliente.Text = " &Cliente";
            this.btnAlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarCliente.UseVisualStyleBackColor = false;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAlterarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarUsuario.Image = global::projetoCuboMagico.Properties.Resources._1055000_24;
            this.btnAlterarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarUsuario.Location = new System.Drawing.Point(0, 159);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(200, 39);
            this.btnAlterarUsuario.TabIndex = 7;
            this.btnAlterarUsuario.Text = " &Usuário";
            this.btnAlterarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.pnlCadastrar);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.pnlConsultar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUsuarioConectado);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 730);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.pnlConsultar.ResumeLayout(false);
            this.pnlEsquerda.ResumeLayout(false);
            this.pnlEsquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlCadastrar;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label lblUsuarioConectado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Panel pnlConsultar;
        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblLogo2;
        private System.Windows.Forms.Label lblLogo1;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnConsultarEditora;
        private System.Windows.Forms.Button btnCadastrarEditora;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnConsultarLivro;
        private System.Windows.Forms.Panel pnlAlterar;
        private System.Windows.Forms.Button btnAlterarLivro;
        private System.Windows.Forms.Button btnAlterarEditora;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnAlterarUsuario;
    }
}

