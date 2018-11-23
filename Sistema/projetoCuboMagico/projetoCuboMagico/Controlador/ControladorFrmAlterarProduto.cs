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
    class ControladorFrmAlterarProduto
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtDescricao;
        private TextBox txtValor;


        //Construtores

        public ControladorFrmAlterarProduto()
        {

        }

        public ControladorFrmAlterarProduto(TextBox txtCodigo, TextBox txtNome, TextBox txtQuantidade, TextBox txtDescricao, TextBox txtValor)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.TxtQuantidade = txtQuantidade;
            this.TxtDescricao = txtDescricao;
            this.TxtValor = txtValor;
        }

        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public TextBox TxtQuantidade { get => txtQuantidade; set => txtQuantidade = value; }
        public TextBox TxtDescricao { get => txtDescricao; set => txtDescricao = value; }
        public TextBox TxtValor { get => txtValor; set => txtValor = value; }

        //Instancias
        Produto produto = new Produto();
        DataTable dt = new DataTable();
        RepositorioProduto repositorioProduto = new RepositorioProduto();
        //Codigo


        public void InicializarObjetos()
        {
            produto._codigo = Convert.ToInt32(txtCodigo.Text);
            produto._nome = txtNome.Text;
            produto._quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto._descricao = txtDescricao.Text;
            produto._valor = Convert.ToDecimal(txtValor.Text);
        }


        public bool AlterarProduto()
        {
            InicializarObjetos();
            DialogResult result = MessageBox.Show("Alterar Produto?\n" + produto.ToString(), "Alteração de Produto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (repositorioProduto.Alterar(produto) == true)
                {
                    MessageBox.Show("Produto alterado com sucesso", "Alteração de Produto");
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
        }

        public void Limpar()
        {
            txtCodigo.Text = null;
            txtNome.Text = null;
            txtQuantidade.Text = null;
            txtDescricao.Text = null;
            txtValor.Text = null;
        }

        public bool BuscarProduto(string codigo)
        {
            try
            {
                dt = repositorioProduto.ConsultaPorCodigo(codigo);
                txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtQuantidade.Text = dt.Rows[0]["QUANTIDADE"].ToString();
                txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                txtValor.Text = dt.Rows[0]["VALOR"].ToString();
                
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Codigo Inexistente!");
                return false;
            }
        }
    }
}
