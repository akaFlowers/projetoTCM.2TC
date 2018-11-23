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
    class ControladorFrmFecharCaixa
    {
        private int codigo;
        private DataGridView dgvCaixa;
        private Label lblCliente;
        private Label lblCpf;
        private Label lblTelefone;


        public ControladorFrmFecharCaixa()
        {

        }

        public ControladorFrmFecharCaixa(int codigo, DataGridView dgvCaixa, Label lblCliente, Label lblCpf, Label lblTelefone)
        {
            this.codigo = codigo;
            this.dgvCaixa = dgvCaixa;
            this.lblCliente = lblCliente;
            this.lblCpf = lblCpf;
            this.lblTelefone = lblTelefone;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DataGridView DgvCaixa { get => dgvCaixa; set => dgvCaixa = value; }
        public Label LblCliente { get => lblCliente; set => lblCliente = value; }
        public Label LblCpf { get => lblCpf; set => lblCpf = value; }
        public Label LblTelefone { get => lblTelefone; set => lblTelefone = value; }

        //Instancias
        Cliente cliente = new Cliente();
        DataTable dt, dtCaixa;
        RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        RepositorioCliente repositorioCliente = new RepositorioCliente();


        //Codigo

        string livroCadastrar1, livroCadastrar2, livroCadastrar3;

        public void InicializarObjetos()
        {
            cliente._codigo = codigo;
        }

        public void RandomizarTodos()
        {
            InicializarObjetos();

            dt = new DataTable();
            dtCaixa = new DataTable();
            int indexDataTable;
            InicializarObjetos();
            dt = repositorioCaixa.RandomizarEspecificos(cliente);
            indexDataTable = dt.Rows.Count;



            int[] aleatorio = new int[3];


            Random rd = new Random();

            aleatorio[0] = rd.Next(1, indexDataTable);

            do
            {
                aleatorio[1] = rd.Next(1, indexDataTable);
            } while (aleatorio[1] == aleatorio[0]);


            do
            {
                aleatorio[2] = rd.Next(1, indexDataTable);
            } while ((aleatorio[2] == aleatorio[1]) || (aleatorio[2] == aleatorio[0]));
            //ATRIBUINDO VALOR
            string[] livro1 = new string[] { dt.Rows[aleatorio[0]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[0]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[0]]["GENERO"].ToString() };
            string[] livro2 = new string[] { dt.Rows[aleatorio[1]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[1]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[1]]["GENERO"].ToString() };
            string[] livro3 = new string[] { dt.Rows[aleatorio[2]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[2]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[2]]["GENERO"].ToString() };
            livroCadastrar1 = aleatorio[0].ToString();
            livroCadastrar2 = aleatorio[1].ToString();
            livroCadastrar3 = aleatorio[2].ToString();
            dgvCaixa.Rows.Add(livro1);
            dgvCaixa.Rows.Add(livro2);
            dgvCaixa.Rows.Add(livro3);
        }

        public void RandomizarEspecificos()
        {
            dt = new DataTable();
            dtCaixa = new DataTable();
            int indexDataTable;
            InicializarObjetos();
            dt = repositorioCaixa.RandomizarEspecificos(cliente);
            indexDataTable = dt.Rows.Count;



            int[] aleatorio = new int[3];


            Random rd = new Random();

            aleatorio[0] = rd.Next(0, indexDataTable);

            do
            {
                aleatorio[1] = rd.Next(0, indexDataTable);
            } while (aleatorio[1] == aleatorio[0]);


            do
            {
                aleatorio[2] = rd.Next(0, indexDataTable);
            } while ((aleatorio[2] == aleatorio[1]) || (aleatorio[2] == aleatorio[0]));

            //ATRIBUINDO VALOR
            string[] livro1 = new string[] { dt.Rows[aleatorio[0]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[0]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[0]]["GENERO"].ToString() };
            string[] livro2 = new string[] { dt.Rows[aleatorio[1]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[1]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[1]]["GENERO"].ToString() };
            string[] livro3 = new string[] { dt.Rows[aleatorio[2]]["ID LIVRO"].ToString(), dt.Rows[aleatorio[2]]["NOME_LIVRO"].ToString(), dt.Rows[aleatorio[2]]["GENERO"].ToString() };
            livroCadastrar1 = aleatorio[0].ToString();
            livroCadastrar2 = aleatorio[1].ToString();
            livroCadastrar3 = aleatorio[2].ToString();
            dgvCaixa.Rows.Add(livro1);
            dgvCaixa.Rows.Add(livro2);
            dgvCaixa.Rows.Add(livro3);
        }



        public void VerificarCliente()
        {
            InicializarObjetos();
            dt = new DataTable();
            dt = repositorioCliente.ConsultaPorCodigo(codigo);

            string genero1 = dt.Rows[0]["GENERO1"].ToString();
            string genero2 = dt.Rows[0]["GENERO2"].ToString();
            string genero3 = dt.Rows[0]["GENERO3"].ToString();
            string genero4 = dt.Rows[0]["GENERO4"].ToString();
            string genero5 = dt.Rows[0]["GENERO5"].ToString();

            if ((genero1 == "Infanto-juvenil") && (genero2 == "Romance") && (genero3 == "Terror") && (genero4 == "Historia") && (genero5 == "Aventura"))
            {
                RandomizarTodos();
            }
            else
            {
                RandomizarEspecificos();
            }


        }

        public void BuscarInformacoesCliente()
        {
            dt = new DataTable();
            dt = repositorioCliente.ConsultaPorCodigo(codigo);
            lblCliente.Text = dt.Rows[0]["NOME"].ToString();
            lblCpf.Text =dt.Rows[0]["CPF"].ToString();
            lblTelefone.Text = dt.Rows[0]["TELEFONE"].ToString();
        }


        public bool CadastrarLivrosSorteados()
        {

            if (repositorioCaixa.CadastrarLivrosSorteados(codigo, livroCadastrar1) == true)
            {
                if(repositorioCaixa.CadastrarLivrosSorteados(codigo, livroCadastrar2) == true)
                {
                    if(repositorioCaixa.CadastrarLivrosSorteados(codigo, livroCadastrar3) == true)
                    {
                        MessageBox.Show("Caixa confeccionada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                return false;
            }
        }
    }
}
