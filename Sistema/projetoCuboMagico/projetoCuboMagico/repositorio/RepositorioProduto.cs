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
    class RepositorioProduto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adp;
        public bool Incluir(Produto produto)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("INSERT INTO Produto VALUES(@NOME, @QTD, @DESC, @VALOR )", conexao._conexao);
                cmd.Parameters.AddWithValue("@NOME", produto._nome);
                cmd.Parameters.AddWithValue("@QTD", produto._quantidade);
                cmd.Parameters.AddWithValue("@DESC", produto._descricao);
                cmd.Parameters.AddWithValue("@VALOR", produto._valor);
                if (conexao.abrirConexao() == true)
                {
                    //Realiza o insert
                    cmd.ExecuteScalar();
                    retorno = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retorno = false;
                    conexao.fecharConexao();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorno = false;
                conexao.fecharConexao();
            }
            return retorno;
        }
        public bool Alterar(Produto produto)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("UPDATE Produto SET NOME = @NOME, QUANTIDADE = @QUANTIDADE, DESCRICAO = @DESCRICAO, VALOR = @VALOR WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@NOME", produto._nome);
                cmd.Parameters.AddWithValue("@QUANTIDADE", produto._quantidade);
                cmd.Parameters.AddWithValue("@DESCRICAO", produto._descricao);
                cmd.Parameters.AddWithValue("@VALOR", produto._valor);
                cmd.Parameters.AddWithValue("@CODIGO", produto._codigo);
                if (conexao.abrirConexao() == true)
                {
                    //Realiza o insert
                    cmd.ExecuteScalar();
                    retorno = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retorno = false;
                    conexao.fecharConexao();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorno = false;
                conexao.fecharConexao();
            }
            return retorno;
        }

        public int BuscarCodidoProduto()
        {
            int codigo;
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Produto", conexao._conexao);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    codigo = Convert.ToInt32(dr["QTD"]);
                    codigo++;
                }
                else
                {
                    codigo = 0;
                }

                return codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return codigo = 0;
            }
            finally
            {
                dr.Close();
            }
        }

        public DataTable ConsultaPorCodigo(string codigo)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Produto WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
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

        public DataTable ConsultaPorNome(string nome)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Produto WHERE NOME LIKE '%" +nome+"%'" , conexao._conexao);
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

        public DataTable ListarTodos()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Produto", conexao._conexao);
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
    }
}
