using projetoCuboMagico.controlador;
using projetoCuboMagico.ControladorCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Cadastro
{
    public partial class FrmCadastroCliente : Form
    {
        ControladorFrmCadastroCliente controladorFrmCadastroCliente;
        public FrmCadastroCliente()
        {
            InitializeComponent();
            controladorFrmCadastroCliente = new ControladorFrmCadastroCliente(txtCodigo, txtNome, txtEndereco, txtNumero, txtCidade, txtBairro, txtComplemento, txtReferencia, txtEmail, mkdCpf, mkdDataNascimento, mkdTelefone, mkdCelular, mkdCep, cboSexo, cboEstCivil, cboEstado, ckbInfantoJuvenil, ckbRomance, ckbTerror, ckbHistoria, ckbAventura);
            
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = controladorFrmCadastroCliente.BuscarID();
            txtNome.Focus();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Length == 0) || (mkdCpf.Text.Length == 0) || (txtEmail.Text.Length == 0) || (mkdDataNascimento.Text.Length == 0) || (mkdTelefone.Text.Length == 0) || (mkdCelular.Text.Length == 0) || (cboSexo.SelectedIndex == -1) || (cboEstCivil.SelectedIndex == -1) || (mkdCep.Text.Length == 0) || (txtEndereco.Text.Length == 0) || (txtNumero.Text.Length == 0) || (cboEstado.SelectedIndex == -1) || (txtCidade.Text.Length == 0) || (txtBairro.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if ((ckbAventura.Checked) || (ckbHistoria.Checked) || (ckbInfantoJuvenil.Checked) || (ckbRomance.Checked) || (ckbTerror.Checked) || (ckbTodos.Checked))
                {
                    if (controladorFrmCadastroCliente.IncluirCliente() == true)
                    {
                        controladorFrmCadastroCliente.Limpar();
                        txtCodigo.Text = controladorFrmCadastroCliente.BuscarID();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione no mínimo 1 gênero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controladorFrmCadastroCliente.Limpar();
        }

        private void mkdDataNascimento_Click(object sender, EventArgs e)
        {
            mkdDataNascimento.Focus();
            mkdDataNascimento.Select(0, 0);
        }

        private void mkdCpf_Click(object sender, EventArgs e)
        {
            mkdCpf.Focus();
            if(mkdCpf.Text.Length == 0)
            {
                mkdCpf.Select(0, 0);
            }

        }

        private void mkdTelefone_Click(object sender, EventArgs e)
        {
            mkdTelefone.Focus();
            mkdTelefone.Select(0, 0);
        }

        private void mkdCelular_Click(object sender, EventArgs e)
        {
            mkdCelular.Focus();
            mkdCelular.Select(0, 0);
        }

        private void mkdCep_Click(object sender, EventArgs e)
        {
            mkdCep.Focus();
            mkdCep.Select(0, 0);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
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
    }
}
