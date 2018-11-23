using projetoCuboMagico.controlador;
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
    public partial class FrmCadastroFuncionario : Form
    {
        ControladorFrmCadastroFuncionario controladorFrmCadastroFuncionario;
        
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            controladorFrmCadastroFuncionario = new ControladorFrmCadastroFuncionario(txtCodigo, txtNome, txtEndereco, txtNumero, txtCidade, txtBairro, txtComplemento, txtReferencia, txtEmail, txtCargo, mkdCpf, mkdDataNascimento, mkdTelefone, mkdCelular, mkdCep, cboSexo, cboEstCivil, cboEstado);
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = controladorFrmCadastroFuncionario.BuscarID();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Length == 0) || (mkdCpf.Text.Length == 0) || (txtEmail.Text.Length == 0) || (mkdDataNascimento.Text.Length == 0) || (mkdTelefone.Text.Length == 0) || (mkdCelular.Text.Length == 0) || (cboSexo.SelectedIndex == -1) || (cboEstCivil.SelectedIndex == -1) || (mkdCep.Text.Length == 0) || (txtEndereco.Text.Length == 0) || (txtNumero.Text.Length == 0) || (cboEstado.SelectedIndex == -1) || (txtCidade.Text.Length == 0) || (txtBairro.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (controladorFrmCadastroFuncionario.IncluirFuncionario() == true)
                {
                    controladorFrmCadastroFuncionario.Limpar();
                    txtCodigo.Text = controladorFrmCadastroFuncionario.BuscarID();
                }
                else
                {

                }

            }
        }

        private void mkdDataNascimento_MouseClick(object sender, MouseEventArgs e)
        {
            mkdDataNascimento.Focus();
            mkdDataNascimento.Select(0, 0);
        }

        private void mkdCpf_MouseClick(object sender, MouseEventArgs e)
        {
            mkdCpf.Focus();
            mkdCpf.Select(0, 0);
        }

        private void mkdTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            mkdTelefone.Focus();
            mkdTelefone.Select(0, 0);
        }

        private void mkdCelular_MouseClick(object sender, MouseEventArgs e)
        {
            mkdCelular.Focus();
            mkdCelular.Select(0, 0);
        }

        private void mkdCep_MouseClick(object sender, MouseEventArgs e)
        {
            mkdCep.Focus();
            mkdCep.Select(0, 0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controladorFrmCadastroFuncionario.Limpar();
        }
    }
}
