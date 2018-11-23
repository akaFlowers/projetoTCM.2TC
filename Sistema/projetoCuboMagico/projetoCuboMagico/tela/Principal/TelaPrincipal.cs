using projetoCuboMagico.Controlador;
using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using projetoCuboMagico.tela.Alterar;
using projetoCuboMagico.tela.Cadastro;
using projetoCuboMagico.tela.Cadastro.Livro;
using projetoCuboMagico.tela.Caixa;
using projetoCuboMagico.tela.Consulta;
using projetoCuboMagico.tela.Login;
using projetoCuboMagico.tela.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico
{
    public partial class TelaPrincipal : Form
    {
        FrmCadastroUsuario frmCadastroUsuario;
        FrmCadastroFuncionario frmCadastroFuncionario;
        FrmConsultaCliente frmConsultaCliente;
        FrmAlterarProduto frmAlterarProduto;
        FrmConsultaFuncionario frmConsultaFuncionario;
        FrmConsultaUsuario frmConsultaUsuario;
        FrmCadastroEditora frmCadastroEditora;
        FrmInicio frmInicio;
        FrmConsultaProduto frmConsultaProduto;
        FrmCaixa frmCaixa;
        FrmCadastroProduto frmCadastroProduto;
        FrmConsultaEditora frmConsultaEditora;
        FrmAlterarUsuario frmAlterarUsuario;
        FrmConsultaLivro frmConsultaLivro;
        FrmAlterarCliente frmAlterarCliente;
        FrmCadastroLivro frmCadastroLivro;
        FrmAlterarFuncionario frmAlterarFuncionario;
        FrmAlterarLivro frmAlterarLivro;
        FrmAlterarEditora frmAlterarEditora;
        FrmCadastroCliente frmCadastroCliente;
        TelaLogin telaLogin;

        public TelaPrincipal()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = true;
            pnlConsultar.Visible = false;
            pnlAlterar.Visible = false;
            pnlCadastrar.BringToFront();
        }

        private void btnConsultar_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            pnlConsultar.Visible = true;
            pnlAlterar.Visible = false;
            pnlConsultar.BringToFront();
        }


        private void pnlCadastrar_MouseLeave(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

            RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            Point pointConsultar = new Point(205, 437);
            Point pointAlterar = new Point(205, 488);
            pnlConsultar.Location = pointConsultar;
            pnlAlterar.Location = pointAlterar;

            //Buscar usuario conectado
            lblUsuario.Text = repositorioUsuario.BuscarNomeFuncionario(Usuario.codFun.ToString());
            //Settando data
            timerHora.Start();

            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Abrindo form inicial
            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmInicio = new FrmInicio { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmInicio);
            frmInicio.Show();


        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

            if(TipoDeAcesso.cargo == "Funcionario")
            {
                MessageBox.Show("Sem Permissão");
            }
            else
            {
                pnlCadastrar.Visible = false;
                //Mudando Cor Menu
                //btnInicio
                btnInicio.BackColor = Color.FromArgb(34, 34, 34);
                btnInicio.ForeColor = Color.White;
                //btnCadastrar
                btnCadastrar.BackColor = Color.SpringGreen;
                btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
                //btnCosultar
                btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
                btnConsultar.ForeColor = Color.White;
                //btnAlterar
                btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
                btnAlterar.ForeColor = Color.White;
                //btnCaixa
                btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
                btnCaixa.ForeColor = Color.White;

                //Abrindo Form
                if (pnlBase.Controls.Count != 0)
                {
                    pnlBase.Controls.RemoveAt(0);
                }
                frmCadastroUsuario = new FrmCadastroUsuario { TopLevel = false, Dock = DockStyle.Fill };
                pnlBase.Controls.Add(frmCadastroUsuario);
                frmCadastroUsuario.Show();
            }

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Mudando Cor Menu
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            //btnInicio
            btnInicio.BackColor = Color.SpringGreen;
            btnInicio.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form
            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmInicio = new FrmInicio { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmInicio);
            frmInicio.Show();

        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.SpringGreen;
            btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroFuncionario = new FrmCadastroFuncionario { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroFuncionario);
            frmCadastroFuncionario.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            telaLogin = new TelaLogin();
            DialogResult resposta = MessageBox.Show("Encerrar sessão?","Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            {
                this.Hide();
                telaLogin.ShowDialog();
            }      
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.SpringGreen;
            btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroProduto = new FrmCadastroProduto { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroProduto);
            frmCadastroProduto.Show();
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlConsultar.Visible = false;
        }

        private void btnCaixa_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlAlterar.Visible = false;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.SpringGreen;
            btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroCliente = new FrmCadastroCliente { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroCliente);
            frmCadastroCliente.Show();
        }

        private void pnlConsultar_MouseLeave(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmConsultaCliente = new FrmConsultaCliente{ TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmConsultaCliente);
            frmConsultaCliente.Show();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmConsultaFuncionario = new FrmConsultaFuncionario { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmConsultaFuncionario);
            frmConsultaFuncionario.Show();
        }

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlAlterar.Visible = true;
        }

        private void btnConfiguracoes_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlAlterar.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = true;  
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = true;
        }

        private void btnCadastrarEditora_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.SpringGreen;
            btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroEditora = new FrmCadastroEditora { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroEditora);
            frmCadastroEditora.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.SpringGreen;
            btnCaixa.ForeColor = Color.FromArgb(34, 34, 34);

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCaixa = new FrmCaixa { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCaixa);
            frmCaixa.Show();
        }

        private void btnConsultarEditora_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmConsultaEditora = new FrmConsultaEditora { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmConsultaEditora);
            frmConsultaEditora.Show();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.SpringGreen;
            btnCadastrar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroLivro = new FrmCadastroLivro { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroLivro);
            frmCadastroLivro.Show();
        }

        private void btnConsultarLivro_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;

            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmConsultaLivro = new FrmConsultaLivro { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmConsultaLivro);
            frmConsultaLivro.Show();
        }

        private void pnlAlterar_MouseLeave(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //BtnAlterar
            btnAlterar.BackColor = Color.SpringGreen;
            btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmAlterarCliente = new FrmAlterarCliente { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmAlterarCliente);
            frmAlterarCliente.Show();
        }

        private void btnAlterarLivro_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //BtnAlterar
            btnAlterar.BackColor = Color.SpringGreen;
            btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmAlterarLivro = new FrmAlterarLivro { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmAlterarLivro);
            frmAlterarLivro.Show();
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //BtnAlterar
            btnAlterar.BackColor = Color.SpringGreen;
            btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmAlterarFuncionario = new FrmAlterarFuncionario { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmAlterarFuncionario);
            frmAlterarFuncionario.Show();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            if(TipoDeAcesso.cargo == "Funcionario")
            {
                MessageBox.Show("Sem permissão");
            }
            else
            {
                pnlAlterar.Visible = false;
                //Mudando Cor Menu
                //btnInicio
                btnInicio.BackColor = Color.FromArgb(34, 34, 34);
                btnInicio.ForeColor = Color.White;
                //btnCadastrar
                btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
                btnCadastrar.ForeColor = Color.White;
                //btnCosultar
                btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
                btnConsultar.ForeColor = Color.White;
                //BtnAlterar
                btnAlterar.BackColor = Color.SpringGreen;
                btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
                //btnCaixa
                btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
                btnCaixa.ForeColor = Color.White;


                //Abrindo Form

                if (pnlBase.Controls.Count != 0)
                {
                    pnlBase.Controls.RemoveAt(0);
                }
                frmAlterarUsuario = new FrmAlterarUsuario { TopLevel = false, Dock = DockStyle.Fill };
                pnlBase.Controls.Add(frmAlterarUsuario);
                frmAlterarUsuario.Show();
            }
        }

        private void btnAlterarEditora_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //BtnAlterar
            btnAlterar.BackColor = Color.SpringGreen;
            btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmAlterarEditora = new FrmAlterarEditora { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmAlterarEditora);
            frmAlterarEditora.Show();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnAlterar
            btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
            btnAlterar.ForeColor = Color.White;
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmConsultaProduto = new FrmConsultaProduto { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmConsultaProduto);
            frmConsultaProduto.Show();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            //Mudando Cor Menu
            //btnInicio
            btnInicio.BackColor = Color.FromArgb(34, 34, 34);
            btnInicio.ForeColor = Color.White;
            //btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
            btnCadastrar.ForeColor = Color.White;
            //btnCosultar
            btnConsultar.BackColor = Color.FromArgb(34, 34, 34);
            btnConsultar.ForeColor = Color.White;
            //BtnAlterar
            btnAlterar.BackColor = Color.SpringGreen;
            btnAlterar.ForeColor = Color.FromArgb(34, 34, 34);
            //btnCaixa
            btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
            btnCaixa.ForeColor = Color.White;


            //Abrindo Form

            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmAlterarProduto = new FrmAlterarProduto { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmAlterarProduto);
            frmAlterarProduto.Show();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            if(TipoDeAcesso.cargo == "Funcionario")
            {
                MessageBox.Show("Sem permissão");
            }
            else
            {
                pnlConsultar.Visible = false;
                //Mudando Cor Menu
                //btnInicio
                btnInicio.BackColor = Color.FromArgb(34, 34, 34);
                btnInicio.ForeColor = Color.White;
                //btnCadastrar
                btnCadastrar.BackColor = Color.FromArgb(34, 34, 34);
                btnCadastrar.ForeColor = Color.White;
                //btnCosultar
                btnConsultar.BackColor = Color.SpringGreen;
                btnConsultar.ForeColor = Color.FromArgb(34, 34, 34);
                //btnAlterar
                btnAlterar.BackColor = Color.FromArgb(34, 34, 34);
                btnAlterar.ForeColor = Color.White;
                //btnCaixa
                btnCaixa.BackColor = Color.FromArgb(34, 34, 34);
                btnCaixa.ForeColor = Color.White;

                //Abrindo Form

                if (pnlBase.Controls.Count != 0)
                {
                    pnlBase.Controls.RemoveAt(0);
                }
                frmConsultaUsuario = new FrmConsultaUsuario { TopLevel = false, Dock = DockStyle.Fill };
                pnlBase.Controls.Add(frmConsultaUsuario);
                frmConsultaUsuario.Show();
            }  
        }
    }
}
