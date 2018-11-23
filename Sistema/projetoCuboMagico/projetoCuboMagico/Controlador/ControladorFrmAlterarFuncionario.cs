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
    class ControladorFrmAlterarFuncionario
    {
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtReferencia;
        private TextBox txtEmail;
        private TextBox txtCargo;
        private MaskedTextBox mkdCpf;
        private MaskedTextBox mkdDataNascimento;
        private MaskedTextBox mkdTelefone;
        private MaskedTextBox mkdCelular;
        private MaskedTextBox mkdCep;
        private ComboBox cboSexo;
        private ComboBox cboEstCivil;
        private ComboBox cboEstado;

        //Construtores

        public ControladorFrmAlterarFuncionario()
        {

        }

        public ControladorFrmAlterarFuncionario(TextBox txtCodigo, TextBox txtNome, TextBox txtEndereco, TextBox txtNumero, TextBox txtCidade, TextBox txtBairro, TextBox txtComplemento, TextBox txtReferencia, TextBox txtEmail, TextBox txtCargo, MaskedTextBox mkdCpf, MaskedTextBox mkdDataNascimento, MaskedTextBox mkdTelefone, MaskedTextBox mkdCelular, MaskedTextBox mkdCep, ComboBox cboSexo, ComboBox cboEstCivil, ComboBox cboEstado)
        {
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
            this.TxtEndereco = txtEndereco;
            this.TxtNumero = txtNumero;
            this.TxtCidade = txtCidade;
            this.TxtBairro = txtBairro;
            this.TxtComplemento = txtComplemento;
            this.TxtReferencia = txtReferencia;
            this.TxtEmail = txtEmail;
            this.TxtCargo = txtCargo;
            this.MkdCpf = mkdCpf;
            this.MkdDataNascimento = mkdDataNascimento;
            this.MkdTelefone = mkdTelefone;
            this.MkdCelular = mkdCelular;
            this.MkdCep = mkdCep;
            this.CboSexo = cboSexo;
            this.CboEstCivil = cboEstCivil;
            this.CboEstado = cboEstado;
        }

        //Getters And Setters

        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        public TextBox TxtEndereco { get => txtEndereco; set => txtEndereco = value; }
        public TextBox TxtNumero { get => txtNumero; set => txtNumero = value; }
        public TextBox TxtCidade { get => txtCidade; set => txtCidade = value; }
        public TextBox TxtBairro { get => txtBairro; set => txtBairro = value; }
        public TextBox TxtComplemento { get => txtComplemento; set => txtComplemento = value; }
        public TextBox TxtReferencia { get => txtReferencia; set => txtReferencia = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtCargo { get => txtCargo; set => txtCargo = value; }
        public MaskedTextBox MkdCpf { get => mkdCpf; set => mkdCpf = value; }
        public MaskedTextBox MkdDataNascimento { get => mkdDataNascimento; set => mkdDataNascimento = value; }
        public MaskedTextBox MkdTelefone { get => mkdTelefone; set => mkdTelefone = value; }
        public MaskedTextBox MkdCelular { get => mkdCelular; set => mkdCelular = value; }
        public MaskedTextBox MkdCep { get => mkdCep; set => mkdCep = value; }
        public ComboBox CboSexo { get => cboSexo; set => cboSexo = value; }
        public ComboBox CboEstCivil { get => cboEstCivil; set => cboEstCivil = value; }
        public ComboBox CboEstado { get => cboEstado; set => cboEstado = value; }



        //Instancias
        Funcionario funcionario = new Funcionario();
        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
        DataTable dt = new DataTable();
        //Codigo

        public void InicializarObjetos()
        {
            funcionario._codigo = Convert.ToInt32(txtCodigo.Text);
            funcionario._nome = txtNome.Text;
            funcionario._endereco = txtEndereco.Text;
            funcionario._numero = txtNumero.Text;
            funcionario._cidade = txtCidade.Text;
            funcionario._bairro = txtBairro.Text;
            funcionario._complemento = txtComplemento.Text;
            funcionario._referencia = txtReferencia.Text;
            funcionario._email = txtEmail.Text;
            funcionario._cargo = txtCargo.Text;
            funcionario._cpf = mkdCpf.Text;
            funcionario._dataNascimento = mkdDataNascimento.Text;
            funcionario._telefone = mkdTelefone.Text;
            funcionario._celular = mkdCelular.Text;
            funcionario._cep = mkdCep.Text;
            funcionario._sexo = cboSexo.SelectedItem.ToString();
            funcionario._estadoCivil = cboEstCivil.SelectedItem.ToString();
            funcionario._estado = cboEstado.SelectedItem.ToString();
        }


        public bool AlterarFuncionario()
        {
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Alterar Funcionario??\n\n" + funcionario.ToString(), "Alterar Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioFuncionario.Alterar(funcionario) == true)
                {
                    MessageBox.Show("Funcionario alterado com sucesso!!");

                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public void Limpar()
        {
            TxtNome.Text = null;
            TxtEndereco.Text = null;
            TxtNumero.Text = null;
            TxtComplemento.Text = null;
            TxtEmail.Text = null;
            TxtReferencia.Text = null;
            TxtBairro.Text = null;
            TxtCargo.Text = null;
            MkdCpf.Text = null;
            MkdDataNascimento.Text = null;
            MkdCep.Text = null;
            MkdTelefone.Text = null;
            MkdCelular.Text = null;
            CboEstado.SelectedItem = null;
            CboSexo.SelectedItem = null;
            CboEstCivil.SelectedItem = null;
            TxtCidade.Text = null;
        }

        public bool BuscarFuncionario(int codigo)
        {
            try
            {
                dt = repositorioFuncionario.ConsultaPorCodigo(codigo);
                txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                mkdCpf.Text = dt.Rows[0]["CPF"].ToString();
                txtCargo.Text = dt.Rows[0]["CARGO"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                mkdDataNascimento.Text = dt.Rows[0]["DATA_NASCIMENTO"].ToString();
                mkdTelefone.Text = dt.Rows[0]["TELEFONE"].ToString();
                mkdCelular.Text = dt.Rows[0]["CELULAR"].ToString();
                cboSexo.Text = dt.Rows[0]["SEXO"].ToString();
                cboEstCivil.Text = dt.Rows[0]["ESTADO_CIVIL"].ToString();
                mkdCep.Text = dt.Rows[0]["CEP"].ToString();
                txtEndereco.Text = dt.Rows[0]["ENDERECO"].ToString();
                txtNumero.Text = dt.Rows[0]["NUMERO"].ToString();
                cboEstado.Text = dt.Rows[0]["ESTADO"].ToString();
                txtCidade.Text = dt.Rows[0]["CIDADE"].ToString();
                txtBairro.Text = dt.Rows[0]["BAIRRO"].ToString();
                txtComplemento.Text = dt.Rows[0]["COMPLEMENTO"].ToString();
                txtReferencia.Text = dt.Rows[0]["REFERENCIA"].ToString();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
