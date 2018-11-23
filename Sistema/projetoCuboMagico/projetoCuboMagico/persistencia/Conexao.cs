using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.persistencia
{
    class Conexao
    {
        private SqlConnection conexao = new SqlConnection("User ID = sa; Initial Catalog = bdCuboMagico; Data Source = (local); password = 1234567");

        //Construtor
        public Conexao()
        {

        }

        //Getters And Setters
        public SqlConnection _conexao
        {
            get { return this.conexao; }
            set { this.conexao = value; }
        }

        //Codigo

        public bool abrirConexao()
        {

            try
            {
                if (this.conexao.State == ConnectionState.Closed)
                {
                    this.conexao.Open();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }

        public void fecharConexao()
        {
            if (this.conexao.State == ConnectionState.Closed)
            {
                this.conexao.Close();
            }

        }

        public bool testarConexao()
        {
            if (this.conexao != null && conexao.State != ConnectionState.Closed)
                return true;
            else
                return false;


        }
    }
}
