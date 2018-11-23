using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador.Funcionário
{
    class ControladorFrmConsultaFuncionario
    {
        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();

        private TextBox txtCodigo;
        private TextBox txtNome;
        private DataGridView dgvFuncionario;

        //Construtores

        public ControladorFrmConsultaFuncionario()
        {
        }

        public ControladorFrmConsultaFuncionario(TextBox txtCodigo, TextBox txtNome, DataGridView dgvFuncionario)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.DgvFuncionario = dgvFuncionario;
        }

        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public DataGridView DgvFuncionario { get => dgvFuncionario; set => dgvFuncionario = value; }

        //Codigo

        public DataTable ConsultaPorCodigo(int codigo)
        {
            return repositorioFuncionario.ConsultaPorCodigo(codigo);
        }


        public DataTable ListarTodos()
        {
            return repositorioFuncionario.ListarTodos();
        }

        public DataTable ConsultaPorNome(string nome)
        {
            return repositorioFuncionario.ConsultarPorNome(nome);
        }
    }
}
