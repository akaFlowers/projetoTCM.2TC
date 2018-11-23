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
    class ControladorFrmAlterarLivro
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtAutor;
        private TextBox txtQtdPaginas;
        private TextBox txtSinopse;
        private TextBox txtQuantidade;
        private TextBox txtValor;
        private MaskedTextBox mkdDataPublicacao;
        private ComboBox cboCapa;
        private ComboBox cboEditora;
        private ComboBox cboGenero;

        //Instancias
        Livro livro = new Livro();
        RepositorioLivro repositorioLivro = new RepositorioLivro();
        DataTable dt = new DataTable();
        //Construtores

        public ControladorFrmAlterarLivro()
        {

        }

        public ControladorFrmAlterarLivro(TextBox txtCodigo, TextBox txtNome, TextBox txtAutor, TextBox txtQtdPaginas, TextBox txtSinopse, TextBox txtQuantidade, TextBox txtValor, MaskedTextBox mkdDataPublicacao, ComboBox cboCapa, ComboBox cboEditora, ComboBox cboGenero)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.TxtAutor = txtAutor;
            this.TxtQtdPaginas = txtQtdPaginas;
            this.TxtSinopse = txtSinopse;
            this.TxtQuantidade = txtQuantidade;
            this.TxtValor = txtValor;
            this.MkdDataPublicacao = mkdDataPublicacao;
            this.CboCapa = cboCapa;
            this.CboEditora = cboEditora;
            this.CboGenero = cboGenero;
        }

        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public TextBox TxtAutor { get => txtAutor; set => txtAutor = value; }
        public TextBox TxtQtdPaginas { get => txtQtdPaginas; set => txtQtdPaginas = value; }
        public TextBox TxtSinopse { get => txtSinopse; set => txtSinopse = value; }
        public TextBox TxtQuantidade { get => txtQuantidade; set => txtQuantidade = value; }
        public TextBox TxtValor { get => txtValor; set => txtValor = value; }
        public MaskedTextBox MkdDataPublicacao { get => mkdDataPublicacao; set => mkdDataPublicacao = value; }
        public ComboBox CboCapa { get => cboCapa; set => cboCapa = value; }
        public ComboBox CboEditora { get => cboEditora; set => cboEditora = value; }
        public ComboBox CboGenero { get => cboGenero; set => cboGenero = value; }

        //Codigo

        public void InicializarObjetos()
        {
            livro._codigo = Convert.ToInt32(txtCodigo.Text);
            livro._nome = txtNome.Text;
            livro._autor = txtAutor.Text;
            livro._qtdPaginas = Convert.ToInt32(txtQtdPaginas.Text);
            livro._sinopse = txtSinopse.Text;
            livro._quantidade = Convert.ToInt32(txtQuantidade.Text);
            livro._valor = Convert.ToDecimal(txtValor.Text);
            livro._dataPublicacao = mkdDataPublicacao.Text;
            livro._capa = cboCapa.SelectedItem.ToString();
            livro._editora = cboEditora.SelectedIndex + 1;
            livro._genero = cboGenero.SelectedItem.ToString();
        }

        public bool AlterarLivro()
        {
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Alterar Livro??\n" + livro.ToString(), "Alterar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioLivro.Alterar(livro) == true)
                {
                    MessageBox.Show("Livro alterado com sucesso!!");
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
            txtAutor.Text = null;
            txtQtdPaginas.Text = null;
            txtSinopse.Text = null;
            txtQuantidade.Text = null;
            txtValor.Text = null;
            mkdDataPublicacao.Text = null;
            cboCapa.SelectedItem = null;
            cboEditora.SelectedItem = null;
            cboEditora.SelectedItem = null;
            cboGenero.SelectedItem = null;
        }

        public bool BuscarLivro(int codigo)
        {
            try
            {
                dt = repositorioLivro.ConsultaPorCodigo(codigo);
                txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtQuantidade.Text = dt.Rows[0]["QUANTIDADE"].ToString();
                cboCapa.Text = dt.Rows[0]["CAPA"].ToString();
                txtSinopse.Text = dt.Rows[0]["SINOPSE"].ToString();
                txtAutor.Text = dt.Rows[0]["AUTOR"].ToString();
                cboEditora.Text = dt.Rows[0]["EDITORA"].ToString();
                cboGenero.Text = dt.Rows[0]["GENERO"].ToString();
                mkdDataPublicacao.Text = dt.Rows[0]["DATA_PUBLICACAO"].ToString();
                txtQtdPaginas.Text = dt.Rows[0]["QTD_PAGINAS"].ToString();
                txtValor.Text = dt.Rows[0]["VALOR"].ToString();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
