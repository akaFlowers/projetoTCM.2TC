using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador.ControladorEditora
{
    class ControladorFrmConsultaEditora
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private DataGridView dgvEditora;

        //Instancias
        RepositorioEditora repositorioEditora = new RepositorioEditora();

        //Construtores

        public ControladorFrmConsultaEditora()
        {

        }

        public ControladorFrmConsultaEditora(TextBox txtCodigo, TextBox txtNome, DataGridView dgvEditora)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.DgvEditora = dgvEditora;
        }

        //Getters And Setters
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public DataGridView DgvEditora { get => dgvEditora; set => dgvEditora = value; }

        //Codigo

        public DataTable ConsultaPorCodigo(int codigo)
        {
            return repositorioEditora.ConsultaPorCodigo(codigo);
        }


        public DataTable ListarTodos()
        {
            return repositorioEditora.ListarTodos();
        }

        public DataTable ConsultaPorNome(string nome)
        {
            return repositorioEditora.ConsultarPorNome(nome);
        }


    }
}
