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
    class RepositorioUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt;
        SqlDataReader dr;
        public bool Incluir(Usuario usuario)
        {
            bool retorno = false;

            try
            {
                cmd = new SqlCommand("INSERT INTO Usuario VALUES(@codFunc, @usuario, @senha)", conexao._conexao);
                cmd.Parameters.AddWithValue("@codFunc", Usuario.codFun);
                cmd.Parameters.AddWithValue("@usuario", usuario._usuario);
                cmd.Parameters.AddWithValue("@senha", usuario._senha);

                if (conexao.abrirConexao() == true)
                {
                    //Realiza o insert
                    cmd.ExecuteScalar();
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorno = false;
            }
            finally
            {
                conexao.fecharConexao();
            }
            return retorno;
        }

        public void IncluirTipoDeAcesso(int codUsuario, string cargo)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("INSERT INTO TipoAcesso VALUES(@codUsuario, @cargo)", conexao._conexao);
                cmd.Parameters.AddWithValue("@codUsuario", codUsuario);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                if(conexao.abrirConexao() == true)
                {
                    cmd.ExecuteScalar();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

        public bool Alterar(Usuario usuario)
        {
            conexao = new Conexao();
            bool retorno = false;

            try
            {
                cmd = new SqlCommand("UPDATE Usuario SET CodFunc = @CODFUNC, USUARIO = @USUARIO, SENHA = @SENHA WHERE CODIGO = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CODIGO", usuario._codigo);
                cmd.Parameters.AddWithValue("@CODFUNC", Usuario.codFun);
                cmd.Parameters.AddWithValue("@USUARIO", usuario._usuario);
                cmd.Parameters.AddWithValue("@SENHA", usuario._senha);


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

        public void AlterarNivelAcesso(Usuario usuario, string cargo)
        {
            conexao = new Conexao();
            try
            {
                cmd = new SqlCommand("UPDATE TipoAcesso SET CARGO = @CARGO  WHERE CodUsuario = @CODIGO", conexao._conexao);
                cmd.Parameters.AddWithValue("@CARGO", cargo);
                cmd.Parameters.AddWithValue("@CODIGO", usuario._codigo);


                if (conexao.abrirConexao() == true)
                {
                    //Realiza o insert
                    cmd.ExecuteScalar();
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.fecharConexao();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexao.fecharConexao();
            }
        }

        public DataTable ListarTodos()
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT Usuario.CODIGO AS [COD], USUARIO, SENHA, TipoAcesso.Cargo, NOME as [FUNCIONÁRIO] FROM Usuario JOIN Funcionarios ON Usuario.CodFunc = Funcionarios.CODIGO JOIN TipoAcesso on TipoAcesso.CodUsuario = Usuario.CODIGO", conexao._conexao);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);

                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return dt;
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        public DataTable ConsultarPorUsuario(string user)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT Usuario.CODIGO AS [COD], USUARIO, SENHA, TipoAcesso.Cargo, CodFunc as [FUNCIONÁRIO] FROM Usuario JOIN Funcionarios ON Usuario.CodFunc = Funcionarios.CODIGO JOIN TipoAcesso on TipoAcesso.CodUsuario = Usuario.CODIGO WHERE Usuario.USUARIO = @USUARIO", conexao._conexao);
                cmd.Parameters.AddWithValue("@USUARIO", user);
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

        public DataTable ConsultarPorCodigo(string codigo)
        {
            try
            {
                conexao.abrirConexao();
                cmd = new SqlCommand("SELECT Usuario.CODIGO ,USUARIO, SENHA, TipoAcesso.Cargo, NOME as [FUNCIONÁRIO] FROM Usuario JOIN Funcionarios ON Usuario.CodFunc = Funcionarios.CODIGO JOIN TipoAcesso on TipoAcesso.CodUsuario = Usuario.CODIGO WHERE Usuario.CODIGO = @CODIGO", conexao._conexao);
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

        public bool AutenticarUsuario(Usuario usuario)
        {
            conexao.abrirConexao();
            try
            {
                cmd = new SqlCommand("SELECT CodFunc,USUARIO, SENHA, CARGO FROM Usuario JOIN TipoAcesso ON TipoAcesso.CodUsuario = Usuario.CODIGO WHERE USUARIO = @USUARIO AND SENHA = @SENHA", conexao._conexao);
                cmd.Parameters.AddWithValue("@USUARIO", usuario._usuario);
                cmd.Parameters.AddWithValue("@SENHA", usuario._senha);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TipoDeAcesso.cargo = dr["CARGO"].ToString();
                    Usuario.codFun = Convert.ToInt32(dr["CodFunc"]);
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.fecharConexao();
                dr.Close();
            }
        }

        public string BuscarNomeFuncionario(string codFunc)
        {
            conexao.abrirConexao();
            try
            {
                cmd = new SqlCommand("SELECT NOME FROM Usuario JOIN Funcionarios ON Usuario.CodFunc = Funcionarios.CODIGO WHERE CodFunc = @codFunc", conexao._conexao);
                cmd.Parameters.AddWithValue("@codFunc", codFunc);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codFunc = dr["NOME"].ToString();
                }
                return codFunc;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return codFunc;   
            }
            finally
            {
                conexao.fecharConexao();
                dr.Close();
            }
        }

        public int BuscarCodidoUsuario()
        {
            int codigo;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) AS [QTD] FROM Usuario", conexao._conexao);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return codigo = 0;
            }
            finally
            {
                dr.Close();
            }
        }

    }
}
