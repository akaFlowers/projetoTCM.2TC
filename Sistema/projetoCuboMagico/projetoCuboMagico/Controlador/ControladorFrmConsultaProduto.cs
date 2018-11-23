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
    class ControladorFrmConsultaProduto
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private DataGridView dgvProduto;

        //Construtores
        public ControladorFrmConsultaProduto()
        {

        }

        public ControladorFrmConsultaProduto(TextBox txtCodigo, TextBox txtNome, DataGridView dgvProduto)
        {
            this.txtCodigo = txtCodigo;
            this.txtNome = txtNome;
            this.dgvProduto = dgvProduto;
        }
        //Getters And Setters
        public TextBox TxtCodigo { get => TxtCodigo1; set => TxtCodigo1 = value; }
        public TextBox TxtNome { get => TxtNome1; set => TxtNome1 = value; }
        public DataGridView DgvProduto { get => DgvProduto1; set => DgvProduto1 = value; }
        public TextBox TxtCodigo1 { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome1 { get => txtNome; set => txtNome = value; }
        public DataGridView DgvProduto1 { get => dgvProduto; set => dgvProduto = value; }

        //Instancias
        RepositorioProduto repositorioProduto = new RepositorioProduto();

        //Codigo

        public DataTable ConsultaPorCodigo(string codigo)
        {
            return repositorioProduto.ConsultaPorCodigo(codigo);
        }


        public DataTable ConsultaPorNome(string nome)
        {

            return repositorioProduto.ConsultaPorNome(nome);
        }

        public DataTable ListarTodos()
        {

            return repositorioProduto.ListarTodos();
        }

    }
}
