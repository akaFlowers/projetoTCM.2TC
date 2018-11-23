using projetoCuboMagico.Controlador;
using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.ControladorCliente
{
    class ControladorFrmCadastroCliente
    {
        Cliente cliente = new Cliente();
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtReferencia;
        private TextBox txtEmail;
        private MaskedTextBox mkdCpf;
        private MaskedTextBox mkdDataNascimento;
        private MaskedTextBox mkdTelefone;
        private MaskedTextBox mkdCelular;
        private MaskedTextBox mkdCep;
        private ComboBox cboSexo;
        private ComboBox cboEstCivil;
        private ComboBox cboEstado;
        private CheckBox ckbInfantoJuvenil;
        private CheckBox ckbRomance;
        private CheckBox ckbTerror;
        private CheckBox ckbHistoria;
        private CheckBox ckbAventura;
        //Construtores

        public ControladorFrmCadastroCliente()
        {
        }

        public ControladorFrmCadastroCliente(TextBox txtCodigo, TextBox txtNome, TextBox txtEndereco, TextBox txtNumero, TextBox txtCidade, TextBox txtBairro, TextBox txtComplemento, TextBox txtReferencia, TextBox txtEmail, MaskedTextBox mkdCpf, MaskedTextBox mkdDataNascimento, MaskedTextBox mkdTelefone, MaskedTextBox mkdCelular, MaskedTextBox mkdCep, ComboBox cboSexo, ComboBox cboEstCivil, ComboBox cboEstado, CheckBox ckbInfantoJuvenil, CheckBox ckbRomance, CheckBox ckbTerror, CheckBox ckbHistoria, CheckBox ckbAventura)
        {
            this.txtCodigo = txtCodigo;
            this.txtNome = txtNome;
            this.txtEndereco = txtEndereco;
            this.txtNumero = txtNumero;
            this.txtCidade = txtCidade;
            this.txtBairro = txtBairro;
            this.txtComplemento = txtComplemento;
            this.txtReferencia = txtReferencia;
            this.txtEmail = txtEmail;
            this.mkdCpf = mkdCpf;
            this.mkdDataNascimento = mkdDataNascimento;
            this.mkdTelefone = mkdTelefone;
            this.mkdCelular = mkdCelular;
            this.mkdCep = mkdCep;
            this.cboSexo = cboSexo;
            this.cboEstCivil = cboEstCivil;
            this.cboEstado = cboEstado;
            this.ckbInfantoJuvenil = ckbInfantoJuvenil;
            this.ckbRomance = ckbRomance;
            this.ckbTerror = ckbTerror;
            this.ckbHistoria = ckbHistoria;
            this.ckbAventura = ckbAventura;
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
        public MaskedTextBox MkdCpf { get => mkdCpf; set => mkdCpf = value; }
        public MaskedTextBox MkdDataNascimento { get => mkdDataNascimento; set => mkdDataNascimento = value; }
        public MaskedTextBox MkdTelefone { get => mkdTelefone; set => mkdTelefone = value; }
        public MaskedTextBox MkdCelular { get => mkdCelular; set => mkdCelular = value; }
        public MaskedTextBox MkdCep { get => mkdCep; set => mkdCep = value; }
        public ComboBox CboSexo { get => cboSexo; set => cboSexo = value; }
        public ComboBox CboEstCivil { get => cboEstCivil; set => cboEstCivil = value; }
        public ComboBox CboEstado { get => cboEstado; set => cboEstado = value; }
        public CheckBox CkbInfantoJuvenil { get => ckbInfantoJuvenil; set => ckbInfantoJuvenil = value; }
        public CheckBox CkbRomance { get => ckbRomance; set => ckbRomance = value; }
        public CheckBox CkbTerror { get => ckbTerror; set => ckbTerror = value; }
        public CheckBox CkbHistoria { get => ckbHistoria; set => ckbHistoria = value; }
        public CheckBox CkbAventura { get => ckbAventura; set => ckbAventura = value; }

        //Instancias

        //CODIGO

        public void VerficarCheckBox()
        {
            if (CkbInfantoJuvenil.CheckState == CheckState.Checked)
            {
                cliente._genero1 = CkbInfantoJuvenil.Text;
            }
            else
            {
                cliente._genero1 = "";
            }



            if (CkbRomance.CheckState == CheckState.Checked)
            {
                cliente._genero2 = CkbRomance.Text;
            }
            else
            {
                cliente._genero2 = "";
            }


            if (CkbTerror.CheckState == CheckState.Checked)
            {
                cliente._genero3 = CkbTerror.Text;
            }
            else
            {
                cliente._genero3 = "";
            }


            if (CkbHistoria.CheckState == CheckState.Checked)
            {
                cliente._genero4 = CkbHistoria.Text;
            }
            else
            {
                cliente._genero4 = "";
            }

            if (CkbAventura.CheckState == CheckState.Checked)
            {
                cliente._genero5 = CkbAventura.Text;
            }
            else
            {
                cliente._genero5 = "";
            }


        }

        public void InicializarObjetos()
        {
            cliente._codigo = Convert.ToInt32(txtCodigo.Text);
            cliente._nome = txtNome.Text;
            cliente._endereco = txtEndereco.Text;
            cliente._numero = txtNumero.Text;
            cliente._cidade = txtCidade.Text;
            cliente._bairro = txtBairro.Text;
            cliente._complemento = txtComplemento.Text;
            cliente._referencia = txtReferencia.Text;
            cliente._email = txtEmail.Text;
            cliente._cpf = mkdCpf.Text;
            cliente._dataNascimento = mkdDataNascimento.Text;
            cliente._telefone = mkdTelefone.Text;
            cliente._celular = mkdCelular.Text;
            cliente._cep = mkdCep.Text;
            cliente._sexo = cboSexo.SelectedItem.ToString();
            cliente._estadoCivil = cboEstCivil.SelectedItem.ToString();
            cliente._estado = cboEstado.SelectedItem.ToString();
            VerficarCheckBox();
        }

        public bool IncluirCliente()
        {
            cliente = new Cliente();
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Cadastrar Cliente??\n\n" + cliente.ToString(), "Cadastrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioCliente.Incluir(cliente) == true)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!!");
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

        public string BuscarID()
        {
            return repositorioCliente.BuscarID().ToString();
        }

    }
}
