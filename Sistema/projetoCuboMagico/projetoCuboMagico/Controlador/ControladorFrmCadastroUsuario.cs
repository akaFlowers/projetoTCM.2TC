using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador
{
    class ControladorFrmCadastroUsuario
    {
        private TextBox txtCodigo;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtCodFunc;
        private ComboBox cboTipoAcesso;
        private DataGridView dgvFuncionarios;

        //Instancias
        Usuario usuario = new Usuario();
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();

        //Construtores

        public ControladorFrmCadastroUsuario()
        {

        }

        public ControladorFrmCadastroUsuario(TextBox txtCodigo, TextBox txtUsuario, TextBox txtSenha, TextBox txtCodFunc, ComboBox cboTipoAcesso, DataGridView dgvFuncionarios)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtUsuario = txtUsuario;
            this.TxtSenha = txtSenha;
            this.TxtCodFunc = txtCodFunc;
            this.CboTipoAcesso = cboTipoAcesso;
            this.DgvFuncionarios = dgvFuncionarios;
        }

        //Getters And Setters
        public TextBox TxtUsuario { get => txtUsuario; set => txtUsuario = value; }
        public TextBox TxtSenha { get => txtSenha; set => txtSenha = value; }
        public TextBox TxtCodFunc { get => txtCodFunc; set => txtCodFunc = value; }
        public ComboBox CboTipoAcesso { get => cboTipoAcesso; set => cboTipoAcesso = value; }
        public DataGridView DgvFuncionarios { get => dgvFuncionarios; set => dgvFuncionarios = value; }
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }


        //Codigo

        public void InicializarObjetosUsuario()
        {
            Usuario.codFun = Convert.ToInt32(txtCodFunc.Text);
            usuario._usuario = txtUsuario.Text;
            usuario._senha = txtSenha.Text;
            
        }

        public bool IncluirUsuario()
        {
            InicializarObjetosUsuario();
            try
            {
                DialogResult result = MessageBox.Show("Cadastrar Usuario?" + "\nUsuário: " + txtUsuario.Text + "\nSenha: " + txtSenha.Text + "\nNivel Acesso: " + cboTipoAcesso.SelectedItem.ToString() + "\nCodigo Func: " + txtCodFunc.Text, "Cadastrar Usuario", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if(repositorioUsuario.Incluir(usuario) == true)
                    {
                        IncluirTipoDeAcesso();
                        MessageBox.Show("Usuario cadastrado com sucesso");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public void IncluirTipoDeAcesso()
        {
            //Atribuindo Valor
            int codUser;
            string cargo;
            codUser = Convert.ToInt32(txtCodigo.Text);
            cargo = cboTipoAcesso.SelectedItem.ToString();
            //Incluindo
            repositorioUsuario.IncluirTipoDeAcesso(codUser, cargo);
        }

        public void Limpar()
        {
            TxtUsuario.Text = null;
            TxtSenha.Text = null;
            TxtCodFunc.Text = null;
            CboTipoAcesso.SelectedItem = null;

        }

        public DataTable ListarTodosFuncionarios()
        {
            return repositorioFuncionario.ListarTodos();
        }

        public DataTable ListarTodosUsuario()
        {
            return repositorioUsuario.ListarTodos();
        }

        public int BuscarCodigoUsuario()
        {
            return repositorioUsuario.BuscarCodidoUsuario();
        }
    }
}
