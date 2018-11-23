using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador.ControladorLivro
{
    class ControladorFrmConsultaLivro
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private ComboBox cboGenero;
        private DataGridView dgvLivro;

        //Instancias
        RepositorioLivro repositorioLivro = new RepositorioLivro();

        //Construtores

        public ControladorFrmConsultaLivro()
        {

        }

        public ControladorFrmConsultaLivro(TextBox txtCodigo, TextBox txtNome, ComboBox cboGenero, DataGridView dgvLivro)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.CboGenero = cboGenero;
            this.DgvLivro = dgvLivro;
        }

        //Getters And Setters
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public DataGridView DgvLivro { get => dgvLivro; set => dgvLivro = value; }
        public ComboBox CboGenero { get => cboGenero; set => cboGenero = value; }

        //Codigo

        public DataTable ConsultaPorCodigo(int codigo)
        {
            return repositorioLivro.ConsultaPorCodigo(codigo);
        }


        public DataTable ListarTodos()
        {
            return repositorioLivro.ListarTodos();
        }

        public DataTable ConsultaPorGenero(string genero)
        {

            return repositorioLivro.ConsultaPorGenero(genero);
        }

        public DataTable ConsultaPorNome(string nome)
        {

            return repositorioLivro.ConsultaPorNome(nome);
        }



    }



}

