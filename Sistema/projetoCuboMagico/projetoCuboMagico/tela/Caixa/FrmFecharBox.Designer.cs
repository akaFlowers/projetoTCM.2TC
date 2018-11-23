namespace projetoCuboMagico.tela.Caixa
{
    partial class FrmFecharBox
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
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.colunaCodLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFecharBox = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecharCaixa = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodLivro,
            this.colunaNomeLivro,
            this.colunaGenero});
            this.dgvCaixa.Location = new System.Drawing.Point(16, 166);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(546, 150);
            this.dgvCaixa.TabIndex = 0;
            // 
            // colunaCodLivro
            // 
            this.colunaCodLivro.HeaderText = "ID";
            this.colunaCodLivro.Name = "colunaCodLivro";
            this.colunaCodLivro.Width = 50;
            // 
            // colunaNomeLivro
            // 
            this.colunaNomeLivro.HeaderText = "NOME LIVRO";
            this.colunaNomeLivro.Name = "colunaNomeLivro";
            this.colunaNomeLivro.Width = 252;
            // 
            // colunaGenero
            // 
            this.colunaGenero.HeaderText = "GÊNERO";
            this.colunaGenero.Name = "colunaGenero";
            this.colunaGenero.Width = 200;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(16, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 43);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFecharBox
            // 
            this.btnFecharBox.BackColor = System.Drawing.Color.SpringGreen;
            this.btnFecharBox.FlatAppearance.BorderSize = 0;
            this.btnFecharBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharBox.Location = new System.Drawing.Point(453, 338);
            this.btnFecharBox.Name = "btnFecharBox";
            this.btnFecharBox.Size = new System.Drawing.Size(110, 43);
            this.btnFecharBox.TabIndex = 6;
            this.btnFecharBox.Text = "Fechar Caixa";
            this.btnFecharBox.UseVisualStyleBackColor = false;
            this.btnFecharBox.Click += new System.EventHandler(this.btnFecharBox_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(16, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(16, 68);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF: ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(16, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(12, 143);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(139, 20);
            this.lblCaixa.TabIndex = 11;
            this.lblCaixa.Text = "Caixa aleatorizada";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(74, 47);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(52, 16);
            this.lblNomeCliente.TabIndex = 12;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCpfCliente.Location = new System.Drawing.Point(57, 69);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(26, 16);
            this.lblCpfCliente.TabIndex = 13;
            this.lblCpfCliente.Text = "cpf";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(88, 91);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(56, 16);
            this.lblTelefoneCliente.TabIndex = 14;
            this.lblTelefoneCliente.Text = "telefone";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pnlTop.Controls.Add(this.lblFecharCaixa);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(575, 27);
            this.pnlTop.TabIndex = 15;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblFecharCaixa
            // 
            this.lblFecharCaixa.AutoSize = true;
            this.lblFecharCaixa.ForeColor = System.Drawing.Color.White;
            this.lblFecharCaixa.Location = new System.Drawing.Point(11, 7);
            this.lblFecharCaixa.Name = "lblFecharCaixa";
            this.lblFecharCaixa.Size = new System.Drawing.Size(69, 13);
            this.lblFecharCaixa.TabIndex = 0;
            this.lblFecharCaixa.Text = "Fechar Caixa";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(524, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireito.Location = new System.Drawing.Point(574, 27);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(1, 369);
            this.pnlDireito.TabIndex = 16;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 27);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(1, 369);
            this.pnlEsquerda.TabIndex = 17;
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBaixo.Location = new System.Drawing.Point(1, 395);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(573, 1);
            this.pnlBaixo.TabIndex = 18;
            // 
            // FrmFecharBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(575, 396);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlBaixo);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlDireito);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnFecharBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFecharBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Box";
            this.Load += new System.EventHandler(this.FrmFecharBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFecharBox;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaGenero;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlBaixo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblFecharCaixa;
    }
}