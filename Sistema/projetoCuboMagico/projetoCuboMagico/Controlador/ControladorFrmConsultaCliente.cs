using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.ControladorCliente
{
    class ControladorFrmConsultaCliente
    {
        RepositorioCliente repositorioCliente = new RepositorioCliente();
        Cliente cliente = new Cliente();
        private TextBox txtCodigo;
        private DataGridView dgvCliente;


        //Construtores
        public ControladorFrmConsultaCliente()
        {
        }

        public ControladorFrmConsultaCliente(TextBox txtCodigo, DataGridView dgvCliente)
        {
            this.txtCodigo = txtCodigo;
            this.DgvCliente = dgvCliente;
        }


        //Getters And Setters
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public DataGridView DgvCliente { get => dgvCliente; set => dgvCliente = value; }


        //Codigo

        public DataTable ConsultaPorCodigo(int codigo)
        {
            return repositorioCliente.ConsultaPorCodigo(codigo);
        }
        

        public DataTable ListarTodos()
        {
            return repositorioCliente.ListarTodos();
        }

        public DataTable ConsultaPorNome(string nome)
        {
            return repositorioCliente.ConsultarPorNome(nome);
        }
    }
}
