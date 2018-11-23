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
    class ControladorFrmAlterarEditora
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
        DataTable dt = new DataTable();

        //Construtores

        public ControladorFrmAlterarEditora()
        {

        }

        public ControladorFrmAlterarEditora(TextBox txtCodigo, TextBox txtNome, TextBox txtEmail, MaskedTextBox mkdCnpj, MaskedTextBox mkdTelefone, ComboBox cboPais)
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

        public bool AlterarEditora()
        {
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Alterar Editora Editora??\n" + editora.ToString(), "Alterar Editora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioEditora.Alterar(editora) == true)
                {
                    MessageBox.Show("Editora alterada com sucesso!!");
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
            txtCodigo.Text = null;
            txtNome.Text = null;
            mkdCnpj.Text = null;
            txtEmail.Text = null;
            mkdTelefone.Text = null;
            cboPais.SelectedItem = null;
        }

        public bool BuscarEditora(int codigo)
        {
            try
            {
                dt = repositorioEditora.ConsultaPorCodigo(codigo);
                txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                mkdTelefone.Text = dt.Rows[0]["TELEFONE"].ToString();
                mkdCnpj.Text = dt.Rows[0]["CNPJ"].ToString();
                cboPais.Text = dt.Rows[0]["PAIS"].ToString();


                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Editora não encontrada");
                return false;
            }
        }





    }
}
