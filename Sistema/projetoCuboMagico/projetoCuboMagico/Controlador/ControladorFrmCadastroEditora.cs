using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador.ControladorEditora
{
    class ControladorFrmCadastroEditora
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mkdCnpj;
        private MaskedTextBox mkdTelefone;
        private ComboBox cboPais;


        //Instancias
        RepositorioEditora repositorioEditora = new RepositorioEditora();
        Editora editora = new Editora();

        //Construtores

        public ControladorFrmCadastroEditora()
        {

        }

        public ControladorFrmCadastroEditora(TextBox txtCodigo, TextBox txtNome, TextBox txtEmail ,MaskedTextBox mkdCnpj, MaskedTextBox mkdTelefone, ComboBox cboPais)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.TxtEmail = txtEmail;
            this.MkdCnpj = mkdCnpj;
            this.MkdTelefone = mkdTelefone;
            this.CboPais = cboPais;
        }

        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public MaskedTextBox MkdCnpj { get => mkdCnpj; set => mkdCnpj = value; }
        public MaskedTextBox MkdTelefone { get => mkdTelefone; set => mkdTelefone = value; }
        public ComboBox CboPais { get => cboPais; set => cboPais = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }


        //Codigo    

        public void InicializarObjetos()
        {
            editora._codigo = Convert.ToInt32(txtCodigo.Text);
            editora._nome = txtNome.Text;
            editora._email = txtEmail.Text;
            editora._cnpj = mkdCnpj.Text;
            editora._telefone = mkdTelefone.Text;
            editora._pais = cboPais.SelectedItem.ToString();
        }

        public bool IncluirEditora()
        {
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Cadastrar Editora??\n" + editora.ToString(), "Cadastrar Editora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioEditora.Incluir(editora) == true)
                {
                    MessageBox.Show("Editora cadastrado com sucesso!!");
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
            txtNome.Text = null;
            txtEmail.Text = null;
            mkdCnpj.Text = null;
            mkdTelefone.Text = null;
            cboPais.SelectedItem = null;
        }

        public int BuscarID()
        {
            return repositorioEditora.BuscarID();
        }

    }
}
