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
    class RepositorioFuncionario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adp;
        public bool Incluir(Funcionario funcionario)
        {

            bool retorno = false;

            try
            {

                cmd = new SqlCommand("INSERT INTO Funcionarios VALUES(@nome, @sexo, @data_nascimento, @cpf, @cargo, @estado_civil, @email, @telefone, @celular, @cep, @endereco, @numero, @estado, @cidade, @bairro, @complemento, @referencias)", conexao._conexao);
                cmd.Parameters.AddWithValue("@nome", funcionario._nome);
                cmd.Parameters.AddWithValue("@sexo", funcionario._sexo);
                cmd.Parameters.AddWithValue("@data_nascimento", funcionario._dataNascimento);
                cmd.Parameters.AddWithValue("@cpf", funcionario._cpf);
                cmd.Parameters.AddWithValue("@cargo", funcionario._cargo);
                cmd.Parameters.AddWithValue("@estado_civil", funcionario._estadoCivil);
                cmd.Parameters.AddWithValue("@email", funcionario._email);
                cmd.Parameters.AddWithValue("@telefone", funcionario._telefone);
                cmd.Parameters.AddWithValue("@celular", funcionario._celular);
                cmd.Parameters.AddWithValue("@cep", funcionario._cep);
                cmd.Parameters.AddWithValue("@endereco", funcionario._endereco);
                cmd.Parameters.AddWithValue("@numero", funcionario._numero);
                cmd.Parameters.AddWithValue("@estado", funcionario._estado);
                cmd.Parameters.AddWithValue("@cidade", funcionario._cidade);
                cmd.Parameters.AddWithValue("@bairro", funcionario._bairro);
                cmd.Parameters.AddWithValue("@complemento", funcionario._complemento);
                cmd.Parameters.AddWithValue("@referencias", funcionario._referencia);
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

        public bool Alterar(Funcionario funcionario)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {

                cmd = new SqlCommand("UPDATE Funcionarios SET NOME = @NOME, SEXO = @SEXO, DATA_NASCIMENTO = @dataNascimento, CPF = @CPF, CARGO = @CARGO, ESTADO_CIVIL = @estCIVIL, EMAIL = @EMAIL, TELEFONE = @TELEFONE, CELULAR = @CELULAR, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO, ESTADO = @ESTADO, CIDADE = @CIDADE, BAIRRO = @BAIRRO, COMPLEMENTO = @COMPLEMENTO, REFERENCIA = @REFERENCIA WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@NOME", funcionario._nome);
                cmd.Parameters.AddWithValue("@SEXO", funcionario._sexo);
                cmd.Parameters.AddWithValue("@dataNascimento", funcionario._dataNascimento);
                cmd.Parameters.AddWithValue("@CPF", funcionario._cpf);
                cmd.Parameters.AddWithValue("@CARGO", funcionario._cargo);
                cmd.Parameters.AddWithValue("estCIVIL", funcionario._estadoCivil);
                cmd.Parameters.AddWithValue("@EMAIL", funcionario._email);
                cmd.Parameters.AddWithValue("@TELEFONE", funcionario._telefone);
                cmd.Parameters.AddWithValue("@CELULAR", funcionario._celular);
                cmd.Parameters.AddWithValue("@CEP", funcionario._cep);
                cmd.Parameters.AddWithValue("@ENDERECO", funcionario._endereco);
                cmd.Parameters.AddWithValue("@NUMERO", funcionario._numero);
                cmd.Parameters.AddWithValue("@ESTADO", funcionario._estado);
                cmd.Parameters.AddWithValue("@CIDADE", funcionario._cidade);
                cmd.Parameters.AddWithValue("@BAIRRO", funcionario._bairro);
                cmd.Parameters.AddWithValue("@COMPLEMENTO", funcionario._complemento);
                cmd.Parameters.AddWithValue("@REFERENCIA", funcionario._referencia);
                cmd.Parameters.AddWithValue("@CODIGO", funcionario._codigo);
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

                    cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Funcionarios", conexao._conexao);
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
                cmd = new SqlCommand("SELECT * FROM Funcionarios WHERE Codigo = @CODIGO", conexao._conexao);
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
                cmd = new SqlCommand("SELECT * FROM Funcionarios", conexao._conexao);
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
                cmd = new SqlCommand("SELECT * FROM Funcionarios WHERE NOME LIKE '%" + nome + "%'", conexao._conexao);

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
