using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador
{
    class ControladorFrmCadastroFuncionario
    {
        Funcionario funcionario = new Funcionario();
        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();

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
        private MaskedTextBox mkdCPF;
        private MaskedTextBox mkdNascimento;
        private MaskedTextBox mkdTelefone;
        private MaskedTextBox mkdCelular;
        private MaskedTextBox mkdCEP;
        private ComboBox cboSexo;
        private ComboBox cboEstCivil;
        private ComboBox cboEstado;

        public ControladorFrmCadastroFuncionario()
        {

        }

        public ControladorFrmCadastroFuncionario(TextBox txtCodigo, TextBox txtNome, TextBox txtEndereco, TextBox txtNumero, TextBox txtCidade, TextBox txtBairro, TextBox txtComplemento, TextBox txtReferencia, TextBox txtEmail, TextBox txtCargo, MaskedTextBox mkdCPF, MaskedTextBox mkdNascimento, MaskedTextBox mkdTelefone, MaskedTextBox mkdCelular, MaskedTextBox mkdCEP, ComboBox cboSexo, ComboBox cboEstCivil, ComboBox cboEstado)
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
            this.MkdCPF = mkdCPF;
            this.MkdNascimento = mkdNascimento;
            this.MkdTelefone = mkdTelefone;
            this.MkdCelular = mkdCelular;
            this.MkdCEP = mkdCEP;
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
        public MaskedTextBox MkdCPF { get => mkdCPF; set => mkdCPF = value; }
        public MaskedTextBox MkdNascimento { get => mkdNascimento; set => mkdNascimento = value; }
        public MaskedTextBox MkdTelefone { get => mkdTelefone; set => mkdTelefone = value; }
        public MaskedTextBox MkdCelular { get => mkdCelular; set => mkdCelular = value; }
        public MaskedTextBox MkdCEP { get => mkdCEP; set => mkdCEP = value; }
        public ComboBox CboSexo { get => cboSexo; set => cboSexo = value; }
        public ComboBox CboEstCivil { get => cboEstCivil; set => cboEstCivil = value; }
        public ComboBox CboEstado { get => cboEstado; set => cboEstado = value; }

        //Codigo

        public void InicializarObjetos()
        {
            funcionario._nome = txtNome.Text;
            funcionario._endereco = txtEndereco.Text;
            funcionario._numero = txtNumero.Text;
            funcionario._cidade = txtCidade.Text;
            funcionario._bairro = txtBairro.Text;
            funcionario._complemento = txtComplemento.Text;
            funcionario._referencia = txtReferencia.Text;
            funcionario._email = txtEmail.Text;
            funcionario._cargo = txtCargo.Text;
            funcionario._cpf = mkdCPF.Text;
            funcionario._dataNascimento = mkdNascimento.Text;
            funcionario._telefone = mkdTelefone.Text;
            funcionario._celular = mkdCelular.Text;
            funcionario._cep = mkdCEP.Text;
            funcionario._sexo = cboSexo.SelectedItem.ToString();
            funcionario._estadoCivil = cboEstCivil.SelectedItem.ToString();
            funcionario._estado = cboEstado.SelectedItem.ToString();
        }


        public bool IncluirFuncionario()
        {
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Cadastrar Funcionario??\n\n" + funcionario.ToString(), "Cadastrar Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioFuncionario.Incluir(funcionario) == true)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!!");
   
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
            MkdCPF.Text = null;
            MkdNascimento.Text = null;
            MkdCEP.Text = null;
            MkdTelefone.Text = null;
            MkdCelular.Text = null;
            CboEstado.SelectedItem = null;
            CboSexo.SelectedItem = null;
            CboEstCivil.SelectedItem = null;
            TxtCidade.Text = null;
        }

        public string BuscarID()
        {
            return repositorioFuncionario.BuscarID().ToString();
        }




    }
}
