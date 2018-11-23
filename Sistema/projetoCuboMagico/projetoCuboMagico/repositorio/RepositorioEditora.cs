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
    class RepositorioEditora
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adp;
        public bool Incluir(Editora editora)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("INSERT INTO Editora VALUES(@nome, @email, @telefone, @cnpj, @pais)", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", editora._nome);
                cmd.Parameters.AddWithValue("@email", editora._email);
                cmd.Parameters.AddWithValue("@telefone", editora._telefone);
                cmd.Parameters.AddWithValue("@cnpj", editora._cnpj);
                cmd.Parameters.AddWithValue("@pais", editora._pais);

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

        public bool Alterar(Editora editora)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("UPDATE Editora SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone, CNPJ = @cnpj, PAIS =  @pais WHERE CODIGO = @codigo", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", editora._nome);
                cmd.Parameters.AddWithValue("@email", editora._email);
                cmd.Parameters.AddWithValue("@telefone", editora._telefone);
                cmd.Parameters.AddWithValue("@cnpj", editora._cnpj);
                cmd.Parameters.AddWithValue("@pais", editora._pais);
                cmd.Parameters.AddWithValue("@codigo", editora._codigo);

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

        public int BuscarID()
        {
            int retorno;
            int codigo;
            try
            {
                if (conexao.abrirConexao() == true)
                {

                    cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Editora", conexao._conexao);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        codigo = Convert.ToInt32(dr["QTD"]);
                        codigo++;
                    }
                    else
                    {
                        MessageBox.Show("Tabela de editoras não encontrada");
                        codigo = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível concectar com o banco de dados!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigo = 0;
                }
                retorno = codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                retorno = 0;
            }
            finally
            {
                dr.Close();
                conexao.fecharConexao();
            }
            return retorno;
        }

        public DataTable ConsultaPorCodigo(int codigo)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT * FROM Editora WHERE Codigo = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        public DataTable ListarTodos()
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT * FROM Editora", conexao._conexao);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        public DataTable ConsultarPorNome(string nome)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT * FROM Editora WHERE NOME LIKE '%" + nome + " %'", conexao._conexao);

                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.fecharConexao();
            }

        }
    }
}
