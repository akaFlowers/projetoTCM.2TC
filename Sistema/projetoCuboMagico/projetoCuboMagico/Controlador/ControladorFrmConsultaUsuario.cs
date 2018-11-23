using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.Controlador
{
    class ControladorFrmConsultaUsuario
    {
        private TextBox txtCodigo;
        private TextBox txtUsuario;
        private DataGridView dgvUsuario;

        //Construtores

        public ControladorFrmConsultaUsuario()
        {

        }

        public ControladorFrmConsultaUsuario(TextBox txtCodigo, TextBox txtUsuario, DataGridView dgvUsuario)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtUsuario = txtUsuario;
            this.DgvUsuario = dgvUsuario;
        }


        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtUsuario { get => txtUsuario; set => txtUsuario = value; }
        public DataGridView DgvUsuario { get => dgvUsuario; set => dgvUsuario = value; }


        //Instancias
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        

        //Codigo

        public void ListarTodos()
        {
            dgvUsuario.DataSource = repositorioUsuario.ListarTodos();
        }

        public void ConsultaPorUsuario()
        {
            dgvUsuario.DataSource = repositorioUsuario.ConsultarPorUsuario(txtUsuario.Text);
        }

        public void ConsultaPorCodigo()
        {
            dgvUsuario.DataSource = repositorioUsuario.ConsultarPorCodigo(txtCodigo.Text);
        }


    }
}
