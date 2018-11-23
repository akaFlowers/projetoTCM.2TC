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
    class RepositorioCliente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adp;
        public bool Incluir(Cliente cliente)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("INSERT INTO Cliente VALUES(@nome, @sexo, @data_nascimento, @cpf, @estado_civil, @email, @telefone, @celular, @cep, @endereco, @numero, @estado, @cidade, @bairro, @complemento, @referencia, @genero1, @genero2, @genero3, @genero4, @genero5)", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", cliente._nome);
                cmd.Parameters.AddWithValue("@sexo", cliente._sexo);
                cmd.Parameters.AddWithValue("@data_nascimento", cliente._dataNascimento);
                cmd.Parameters.AddWithValue("@cpf", cliente._cpf);
                cmd.Parameters.AddWithValue("@estado_civil", cliente._estadoCivil);
                cmd.Parameters.AddWithValue("@email", cliente._email);
                cmd.Parameters.AddWithValue("@telefone", cliente._telefone);
                cmd.Parameters.AddWithValue("@celular", cliente._celular);
                cmd.Parameters.AddWithValue("@cep", cliente._cep);
                cmd.Parameters.AddWithValue("@endereco", cliente._endereco);
                cmd.Parameters.AddWithValue("@numero", cliente._numero);
                cmd.Parameters.AddWithValue("@estado", cliente._estado);
                cmd.Parameters.AddWithValue("@cidade", cliente._cidade);
                cmd.Parameters.AddWithValue("@bairro", cliente._bairro);
                cmd.Parameters.AddWithValue("@complemento", cliente._complemento);
                cmd.Parameters.AddWithValue("@referencia", cliente._referencia);
                cmd.Parameters.AddWithValue("@genero1", cliente._genero1);
                cmd.Parameters.AddWithValue("@genero2", cliente._genero2);
                cmd.Parameters.AddWithValue("@genero3", cliente._genero3);
                cmd.Parameters.AddWithValue("@genero4", cliente._genero4);
                cmd.Parameters.AddWithValue("@genero5", cliente._genero5);
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

        public bool Alterar(Cliente cliente)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("UPDATE Cliente SET NOME = @NOME, SEXO = @SEXO, DATA_NASCIMENTO = @dataNascimento, CPF = @CPF, ESTADO_CIVIL = @estCIVIL, EMAIL = @EMAIL, TELEFONE = @TELEFONE, CELULAR = @CELULAR, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO, ESTADO = @ESTADO, CIDADE = @CIDADE, BAIRRO = @BAIRRO, COMPLEMENTO = @COMPLEMENTO, REFERENCIA = @REFERENCIA, GENERO1 = @GENERO1, GENERO2 = @GENERO2, GENERO3 = @GENERO3, GENERO4 = @GENERO4, GENERO5 = @GENERO5 WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@NOME", cliente._nome);
                cmd.Parameters.AddWithValue("@SEXO", cliente._sexo);
                cmd.Parameters.AddWithValue("@dataNascimento", cliente._dataNascimento);
                cmd.Parameters.AddWithValue("@CPF", cliente._cpf);
                cmd.Parameters.AddWithValue("estCIVIL", cliente._estadoCivil);
                cmd.Parameters.AddWithValue("@EMAIL", cliente._email);
                cmd.Parameters.AddWithValue("@TELEFONE", cliente._telefone);
                cmd.Parameters.AddWithValue("@CELULAR", cliente._celular);
                cmd.Parameters.AddWithValue("@CEP", cliente._cep);
                cmd.Parameters.AddWithValue("@ENDERECO", cliente._endereco);
                cmd.Parameters.AddWithValue("@NUMERO", cliente._numero);
                cmd.Parameters.AddWithValue("@ESTADO", cliente._estado);
                cmd.Parameters.AddWithValue("@CIDADE", cliente._cidade);
                cmd.Parameters.AddWithValue("@BAIRRO", cliente._bairro);
                cmd.Parameters.AddWithValue("@COMPLEMENTO", cliente._complemento);
                cmd.Parameters.AddWithValue("@REFERENCIA", cliente._referencia);
                cmd.Parameters.AddWithValue("@CODIGO", cliente._codigo);
                cmd.Parameters.AddWithValue("@GENERO1", cliente._genero1);
                cmd.Parameters.AddWithValue("@GENERO2", cliente._genero2);
                cmd.Parameters.AddWithValue("@GENERO3", cliente._genero3);
                cmd.Parameters.AddWithValue("@GENERO4", cliente._genero4);
                cmd.Parameters.AddWithValue("@GENERO5", cliente._genero5);
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

                    cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Cliente", conexao._conexao);
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
                cmd = new SqlCommand("SELECT * FROM Cliente WHERE Codigo = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }catch(Exception e)
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
                cmd = new SqlCommand("SELECT * FROM Cliente", conexao._conexao);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }catch(Exception e)
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
                cmd = new SqlCommand("SELECT * FROM Cliente WHERE NOME LIKE '%"+nome+"%'", conexao._conexao);
               
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
