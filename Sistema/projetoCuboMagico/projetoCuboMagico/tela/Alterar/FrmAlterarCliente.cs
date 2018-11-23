using projetoCuboMagico.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Alterar
{
    public partial class FrmAlterarCliente : Form
    {
        ControladorFrmAlterarCliente controladorFrmAlterarCliente;
        public FrmAlterarCliente()
        {
            InitializeComponent();
            controladorFrmAlterarCliente = new ControladorFrmAlterarCliente(txtCodigo, txtNome, txtEndereco, txtNumero, txtCidade, txtBairro, txtComplemento, txtReferencia, txtEmail, mkdCpf, mkdDataNascimento, mkdTelefone, mkdCelular, mkdCep, cboSexo, cboEstCivil, cboEstado, ckbTodos, ckbTerror, ckbHistoria, ckbAventura, ckbInfantoJuvenil, ckbRomance);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(txtCodCliente.Text.Length > 0)
            {
                if (controladorFrmAlterarCliente.BuscarCliente(Convert.ToInt32(txtCodCliente.Text)) == true)
                {
                    gpbEndereco.Enabled = true;
                    gpbGenero.Enabled = true;
                    gpbInfoPessoal.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Codigo do cliente não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if((txtNome.Text.Length == 0) || (mkdCpf.Text == "###.###.###-##") || (txtEmail.Text.Length == 0) || (mkdDataNascimento.Text == "##/##/####") || (mkdTelefone.Text == "(##)####-####") || (mkdCelular.Text == "(##)#####-####") || (cboSexo.SelectedIndex == -1) || (cboEstCivil.SelectedIndex == -1) || (mkdCep.Text == "#####-###") || (txtEndereco.Text.Length == 0) || (txtNumero.Text.Length == 0) || (cboEstado.SelectedIndex == -1) || (txtCidade.Text.Length == 0) || (txtBairro.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (controladorFrmAlterarCliente.AlterarCliente() == true)
                {
                    controladorFrmAlterarCliente.Limpar();
                    gpbEndereco.Enabled = false;
                    gpbGenero.Enabled = false;
                    gpbInfoPessoal.Enabled = false;
                }
            }
            
        }

        private void FrmAlterarCliente_Load(object sender, EventArgs e)
        {
            txtCodCliente.Focus();
        }

        private void ckbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTodos.Checked)
            {
                ckbAventura.CheckState = CheckState.Checked;
                ckbHistoria.CheckState = CheckState.Checked;
                ckbInfantoJuvenil.CheckState = CheckState.Checked;
                ckbRomance.CheckState = CheckState.Checked;
                ckbTerror.CheckState = CheckState.Checked;
                ckbAventura.Enabled = false;
                ckbHistoria.Enabled = false;
                ckbInfantoJuvenil.Enabled = false;
                ckbRomance.Enabled = false;
                ckbTerror.Enabled = false;
            }
            else
            {
                ckbAventura.CheckState = CheckState.Unchecked;
                ckbHistoria.CheckState = CheckState.Unchecked;
                ckbInfantoJuvenil.CheckState = CheckState.Unchecked;
                ckbRomance.CheckState = CheckState.Unchecked;
                ckbTerror.CheckState = CheckState.Unchecked;
                ckbAventura.Enabled = true;
                ckbHistoria.Enabled = true;
                ckbInfantoJuvenil.Enabled = true;
                ckbRomance.Enabled = true;
                ckbTerror.Enabled = true;
            }
        }

        private void ckbTerror_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbTerror.Checked)
                {
                    ckbTerror.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbTerror.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbHistoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbHistoria.Checked)
                {
                    ckbHistoria.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbHistoria.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbAventura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbAventura.Checked)
                {
                    ckbAventura.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbAventura.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbInfantoJuvenil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbInfantoJuvenil.Checked)
                {
                    ckbInfantoJuvenil.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbInfantoJuvenil.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbRomance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbRomance.Checked)
                {
                    ckbRomance.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbRomance.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbTodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbTodos.Checked)
                {
                    ckbTodos.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbTodos.CheckState = CheckState.Checked;
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void mkdCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
    }
}
