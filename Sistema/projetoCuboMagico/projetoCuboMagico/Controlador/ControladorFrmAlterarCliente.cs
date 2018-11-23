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
    class ControladorFrmAlterarCliente
    {
        Cliente cliente = new Cliente();
        RepositorioCliente repositorioCliente = new RepositorioCliente();
        DataTable dt = new DataTable();

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
        private CheckBox ckbTodos;
        private CheckBox ckbTerror;
        private CheckBox ckbHistoria;
        private CheckBox ckbAventura;
        private CheckBox ckbInfantoJuvenil;
        private CheckBox ckbRomance;


        //Construtores

        public ControladorFrmAlterarCliente()
        {
        }

        public ControladorFrmAlterarCliente(TextBox txtCodigo, TextBox txtNome, TextBox txtEndereco, TextBox txtNumero, TextBox txtCidade, TextBox txtBairro, TextBox txtComplemento, TextBox txtReferencia, TextBox txtEmail, MaskedTextBox mkdCpf, MaskedTextBox mkdDataNascimento, MaskedTextBox mkdTelefone, MaskedTextBox mkdCelular, MaskedTextBox mkdCep, ComboBox cboSexo, ComboBox cboEstCivil, ComboBox cboEstado, CheckBox ckbTodos, CheckBox ckbTerror, CheckBox ckbHistoria, CheckBox ckbAventura, CheckBox ckbInfantoJuvenil, CheckBox ckbRomance)
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
            this.ckbTodos = ckbTodos;
            this.ckbTerror = ckbTerror;
            this.ckbHistoria = ckbHistoria;
            this.ckbAventura = ckbAventura;
            this.ckbInfantoJuvenil = ckbInfantoJuvenil;
            this.ckbRomance = ckbRomance;
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
        public CheckBox CkbTodos { get => ckbTodos; set => ckbTodos = value; }
        public CheckBox CkbTerror { get => ckbTerror; set => ckbTerror = value; }
        public CheckBox CkbHistoria { get => ckbHistoria; set => ckbHistoria = value; }
        public CheckBox CkbAventura { get => ckbAventura; set => ckbAventura = value; }
        public CheckBox CkbInfantoJuvenil { get => ckbInfantoJuvenil; set => ckbInfantoJuvenil = value; }
        public CheckBox CkbRomance { get => ckbRomance; set => ckbRomance = value; }

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
            cliente._codigo = Convert.ToInt32(TxtCodigo.Text);
            cliente._nome = TxtNome.Text;
            cliente._endereco = TxtEndereco.Text;
            cliente._numero = TxtNumero.Text;
            cliente._cidade = TxtCidade.Text;
            cliente._bairro = TxtBairro.Text;
            cliente._complemento = TxtComplemento.Text;
            cliente._referencia = TxtReferencia.Text;
            cliente._email = TxtEmail.Text;
            cliente._cpf = mkdCpf.Text;
            cliente._dataNascimento = mkdDataNascimento.Text;
            cliente._telefone = MkdTelefone.Text;
            cliente._celular = MkdCelular.Text;
            cliente._cep = mkdCep.Text;
            cliente._sexo = CboSexo.SelectedItem.ToString();
            cliente._estadoCivil = CboEstCivil.SelectedItem.ToString();
            cliente._estado = CboEstado.SelectedItem.ToString();
            VerficarCheckBox();
        }

        public bool AlterarCliente()
        {
            cliente = new Cliente();
            bool retorno;
            InicializarObjetos();
            DialogResult resposta = MessageBox.Show("Alterar Cliente??\n\n" + cliente.ToString(), "Alterar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (repositorioCliente.Alterar(cliente) == true)
                {
                    MessageBox.Show("Cliente Alterado com sucesso!!");
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


        public bool BuscarCliente(int codigo)
        {
            try
            {
                dt = repositorioCliente.ConsultaPorCodigo(codigo);
                txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                mkdCpf.Text = dt.Rows[0]["CPF"].ToString();
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
                string genero1 = dt.Rows[0]["GENERO1"].ToString();
                string genero2 = dt.Rows[0]["GENERO2"].ToString();
                string genero3 = dt.Rows[0]["GENERO3"].ToString();
                string genero4 = dt.Rows[0]["GENERO4"].ToString();
                string genero5 = dt.Rows[0]["GENERO5"].ToString();

                if((genero1 == "Infanto-juvenil") && (genero2 == "Romance") && (genero3 == "Terror") && (genero4 == "História") && (genero5 == "Aventura"))
                {
                    ckbTodos.CheckState = CheckState.Checked;
                    ckbInfantoJuvenil.CheckState = CheckState.Checked;
                    ckbRomance.CheckState = CheckState.Checked;
                    ckbTerror.CheckState = CheckState.Checked;
                    ckbHistoria.CheckState = CheckState.Checked;
                    ckbAventura.CheckState = CheckState.Checked;
                    ckbInfantoJuvenil.Enabled = false;
                    ckbRomance.Enabled = false;
                    ckbTerror.Enabled = false;
                    ckbHistoria.Enabled = false;
                    ckbAventura.Enabled = false;

                }
                else
                {
                    ckbTodos.CheckState = CheckState.Unchecked;
                    ckbInfantoJuvenil.CheckState = CheckState.Unchecked;
                    ckbRomance.CheckState = CheckState.Unchecked;
                    ckbTerror.CheckState = CheckState.Unchecked;
                    ckbHistoria.CheckState = CheckState.Unchecked;
                    ckbAventura.CheckState = CheckState.Unchecked;
                    ckbInfantoJuvenil.Enabled = true;
                    ckbRomance.Enabled = true;
                    ckbTerror.Enabled = true;
                    ckbHistoria.Enabled = true;
                    ckbAventura.Enabled = true;

                    if (genero1 == "Infanto-juvenil")
                    {
                        ckbInfantoJuvenil.CheckState = CheckState.Checked;
                    }

                    if(genero2 == "Romance")
                    {
                        ckbRomance.CheckState = CheckState.Checked;
                    }

                    if(genero3 == "Terror")
                    {
                        ckbTerror.CheckState = CheckState.Checked;
                    }
                    
                    if(genero4 == "História")
                    {
                        ckbHistoria.CheckState = CheckState.Checked;
                    }

                    if(genero5 == "Aventura")
                    {
                        ckbAventura.CheckState = CheckState.Checked;
                    }

                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Limpar()
        {
            txtCodigo.Text = null;
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
            ckbTodos.CheckState = CheckState.Unchecked;
            ckbInfantoJuvenil.CheckState = CheckState.Unchecked;
            ckbRomance.CheckState = CheckState.Unchecked;
            ckbTerror.CheckState = CheckState.Unchecked;
            ckbHistoria.CheckState = CheckState.Unchecked;
            ckbAventura.CheckState = CheckState.Unchecked;

        }


    }
}
