using projetoCuboMagico.domínio;
using projetoCuboMagico.persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.repositorio
{
    class RepositorioCaixa
    {
        Conexao conexao = new Conexao();
        DataTable dt;
        SqlCommand cmd;
        SqlDataAdapter adp;

        public DataTable BuscarCliente()
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT CODIGO, NOME, CPF, TELEFONE FROM Cliente", conexao._conexao);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
           

        }

        public DataTable BuscarClientePorCodigo(string codigo)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT CODIGO, NOME, CPF, TELEFONE FROM Cliente WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }


        }

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT CODIGO, NOME, CPF, TELEFONE FROM Cliente WHERE NOME LIKE '%"+nome+"%'" , conexao._conexao);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }


        }

        public DataTable RandomizarTodosGeneros(Cliente cliente)
        {
            try
            {
                string query = "SELECT CLIENTE.NOME, LIVRO.CODIGO AS [ID LIVRO], LIVRO.NOME, LIVRO.GENERO FROM Cliente, LIVRO WHERE LIVRO.CODIGO NOT IN (SELECT ID_LIVRO FROM ((USER_LIVROS_SORTEADOS INNER JOIN LIVRO ON ID_LIVRO = LIVRO.CODIGO) INNER JOIN CLIENTE ON ID_USER = CLIENTE.CODIGO) WHERE CLIENTE.CODIGO = @CODIGO) AND CLIENTE.CODIGO = @CODIGO;";
                conexao.abrirConexao();
                cmd = new SqlCommand(query, conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", cliente._codigo);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public DataTable RandomizarEspecificos(Cliente cliente)
        {
            try
            {
                string query = "SELECT CLIENTE.NOME, LIVRO.CODIGO AS [ID LIVRO], LIVRO.NOME as [NOME_LIVRO], LIVRO.GENERO FROM CLIENTE, Livro WHERE LIVRO.CODIGO NOT IN (SELECT ID_LIVRO FROM ((USER_LIVROS_SORTEADOS INNER JOIN LIVRO ON ID_LIVRO = LIVRO.CODIGO) INNER JOIN CLIENTE ON ID_USER = CLIENTE.CODIGO) WHERE CLIENTE.CODIGO = @CODIGO) AND CLIENTE.CODIGO = @CODIGO AND LIVRO.GENERO IN (GENERO1, GENERO2, GENERO3, GENERO4, GENERO5) ORDER BY CLIENTE.NOME";
                conexao.abrirConexao();
                cmd = new SqlCommand(query, conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", cliente._codigo);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public bool CadastrarLivrosSorteados(int user, string livro)
        {
            conexao = new Conexao();

            try
            {

                cmd = new SqlCommand("INSERT INTO USER_LIVROS_SORTEADOS VALUES(@IDUSER, @IDLIVRO)", conexao._conexao);
                cmd.Parameters.AddWithValue("@IDUSER", user);
                cmd.Parameters.AddWithValue("@IDLIVRO", livro);
                if (conexao.abrirConexao() == true)
                {
                    //Realiza o insert
                    
                    cmd.ExecuteScalar();
                    return true;
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.fecharConexao();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexao.fecharConexao();
                return false;
            }
        }
    }
}
