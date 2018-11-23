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
    class RepositorioLivro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adp;
        public bool Incluir(Livro livro)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("INSERT INTO livro VALUES(@nome, @quantidade, @capa, @sinopse, @autor, @editora, @genero, @dataPublicacao, @qtdPaginas, @valor)", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", livro._nome);
                cmd.Parameters.AddWithValue("@quantidade", livro._quantidade);
                cmd.Parameters.AddWithValue("@capa", livro._capa);
                cmd.Parameters.AddWithValue("@sinopse", livro._sinopse);
                cmd.Parameters.AddWithValue("@autor", livro._autor);
                cmd.Parameters.AddWithValue("@editora", livro._editora);
                cmd.Parameters.AddWithValue("@genero", livro._genero);
                cmd.Parameters.AddWithValue("@dataPublicacao", livro._dataPublicacao);
                cmd.Parameters.AddWithValue("@qtdPaginas", livro._qtdPaginas);
                cmd.Parameters.AddWithValue("@valor", livro._valor);
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

        public bool Alterar(Livro livro)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("UPDATE Livro SET NOME = @nome, QUANTIDADE = @quantidade, CAPA = @capa, SINOPSE = @sinopse, AUTOR = @autor, EDITORA = @EDITORA, GENERO = @genero, DATA_PUBLICACAO = @dataPublicacao, QTD_PAGINAS = @qtdPaginas, VALOR = @valor WHERE CODIGO = @CODIGO  ", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", livro._nome);
                cmd.Parameters.AddWithValue("@quantidade", livro._quantidade);
                cmd.Parameters.AddWithValue("@capa", livro._capa);
                cmd.Parameters.AddWithValue("@sinopse", livro._sinopse);
                cmd.Parameters.AddWithValue("@autor", livro._autor);
                cmd.Parameters.AddWithValue("@editora", livro._editora);
                cmd.Parameters.AddWithValue("@genero", livro._genero);
                cmd.Parameters.AddWithValue("@dataPublicacao", livro._dataPublicacao);
                cmd.Parameters.AddWithValue("@qtdPaginas", livro._qtdPaginas);
                cmd.Parameters.AddWithValue("@valor", livro._valor);
                cmd.Parameters.AddWithValue("@CODIGO", livro._codigo);
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

                    cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Livro", conexao._conexao);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        codigo = Convert.ToInt32(dr["QTD"]);
                        codigo++;
                    }
                    else
                    {
                        MessageBox.Show("Tabela delivros não encontrada");
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
            catch(Exception ex)
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
                cmd = new SqlCommand("SELECT Livro.CODIGO AS [CODIGO], Livro.NOME, Livro.QUANTIDADE, Livro.CAPA , Livro.SINOPSE , Livro.AUTOR, EDITORA.NOME AS [EDITORA], Livro.GENERO, Livro.DATA_PUBLICACAO, Livro.QTD_PAGINAS, Livro.VALOR  FROM Livro JOIN Editora ON Livro.EDITORA = Editora.CODIGO WHERE Livro.CODIGO = @CODIGO",conexao._conexao);
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
                cmd = new SqlCommand("SELECT Livro.CODIGO AS [CODIGO], Livro.NOME, Livro.QUANTIDADE, Livro.CAPA , Livro.SINOPSE , Livro.AUTOR, EDITORA.NOME AS [EDITORA], Livro.GENERO, Livro.DATA_PUBLICACAO, Livro.QTD_PAGINAS, Livro.VALOR  FROM Livro JOIN Editora ON Livro.EDITORA = Editora.CODIGO", conexao._conexao);
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

        public void BuscarEditora(ComboBox box)
        {
            conexao.abrirConexao();
            try
            {
                cmd = new SqlCommand("SELECT CODIGO, NOME FROM Editora", conexao._conexao);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                box.DisplayMember = "NOME";
                box.ValueMember = "CODIGO";
                box.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.fecharConexao();
                dr.Close();
            }
    
        }

        public DataTable ConsultaPorGenero(string genero)
        {
            
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT Livro.CODIGO AS [CODIGO], Livro.NOME, Livro.QUANTIDADE, Livro.CAPA , Livro.SINOPSE , Livro.AUTOR, EDITORA.NOME AS [EDITORA], Livro.GENERO, Livro.DATA_PUBLICACAO, Livro.QTD_PAGINAS, Livro.VALOR  FROM Livro JOIN Editora ON Livro.EDITORA = Editora.CODIGO WHERE GENERO = @GENERO", conexao._conexao);
                cmd.Parameters.AddWithValue("@GENERO", genero);
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
            finally
            {
                conexao.fecharConexao();
            }

        }

        public DataTable ConsultaPorNome(string nome)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT Livro.CODIGO AS [CODIGO], Livro.NOME, Livro.QUANTIDADE, Livro.CAPA , Livro.SINOPSE , Livro.AUTOR, EDITORA.NOME AS [EDITORA], Livro.GENERO, Livro.DATA_PUBLICACAO, Livro.QTD_PAGINAS, Livro.VALOR  FROM Livro JOIN Editora ON Livro.EDITORA = Editora.CODIGO WHERE Livro.NOME LIKE '%" + nome +"%'", conexao._conexao);
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
            finally
            {
                conexao.fecharConexao();
            }
        }
    }
}
