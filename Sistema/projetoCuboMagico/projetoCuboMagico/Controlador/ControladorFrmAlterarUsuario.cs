using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.Controlador
{
    class ControladorFrmAlterarUsuario
    {
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtCodFunc;
        private TextBox txtCodigo;
        private ComboBox cboTipoAcesso;
        private DataGridView dgvUsuario;

        //Construtores

        public ControladorFrmAlterarUsuario()
        {

        }

        public ControladorFrmAlterarUsuario(TextBox txtUsuario, TextBox txtSenha, TextBox txtCodFunc, TextBox txtCodigo, ComboBox cboTipoAcesso, DataGridView dgvUsuario)
        {
            this.TxtUsuario = txtUsuario;
            this.TxtSenha = txtSenha;
            this.TxtCodFunc = txtCodFunc;
            this.CboTipoAcesso = cboTipoAcesso;
            this.DgvUsuario = dgvUsuario;
            this.TxtCodigo = txtCodigo;
        }

        //Getters And Setters
        public TextBox TxtUsuario { get => txtUsuario; set => txtUsuario = value; }
        public TextBox TxtSenha { get => txtSenha; set => txtSenha = value; }
        public TextBox TxtCodFunc { get => txtCodFunc; set => txtCodFunc = value; }
        public ComboBox CboTipoAcesso { get => cboTipoAcesso; set => cboTipoAcesso = value; }
        public DataGridView DgvUsuario { get => dgvUsuario; set => dgvUsuario = value; }
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }


        //Instancias
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        DataTable dt = new DataTable();
        Usuario usuario = new Usuario();

        //Codigo


        public void InicializarObjetos()
        {
            usuario._codigo = Convert.ToInt32(txtCodigo.Text);
            usuario._usuario = txtUsuario.Text;
            usuario._senha = txtSenha.Text;
            Usuario.codFun = Convert.ToInt32(txtCodFunc.Text);
        }

        public bool AlterarUsuario(string user)
        {
            bool retorno;
            string nivelAcesso;
            InicializarObjetos();
            if (cboTipoAcesso.Text == "Funcionario")
            {
                nivelAcesso = "Funcionario";
            }
            else
            {
                nivelAcesso = "Administrador";
            }
            DialogResult resposta = MessageBox.Show("Alterar Usuario??\n\n " + "\nUsuario: " + usuario._usuario + "\nSenha: " + usuario._senha + "\nNivel Acesso: " + nivelAcesso + "\nCod Func: " + Usuario.codFun.ToString()
                                                                                                , "Alterar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioUsuario.Alterar(usuario) == true)
                {
                    repositorioUsuario.AlterarNivelAcesso(usuario, nivelAcesso);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;

        }

        public void Limpar()
        {
            TxtUsuario.Text = null;
            TxtSenha.Text = null;
            TxtCodFunc.Text = null;
            CboTipoAcesso.SelectedItem = null;
           

        }


        public bool BuscarUsuario(string user)
        {
            try
            {
                dt = repositorioUsuario.ConsultarPorUsuario(user);
                txtCodFunc.Text = dt.Rows[0]["FUNCIONÁRIO"].ToString();
                txtUsuario.Text = dt.Rows[0]["USUARIO"].ToString();
                txtSenha.Text = dt.Rows[0]["SENHA"].ToString();
                cboTipoAcesso.Text = dt.Rows[0]["CARGO"].ToString();
                txtCodigo.Text = dt.Rows[0]["COD"].ToString();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Usuário não encontrado");
                return false;
            }

        }

        public DataTable ListarTodos()
        {

            return repositorioUsuario.ListarTodos();
        }



    }
}
