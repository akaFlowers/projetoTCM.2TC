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
    public partial class FrmAlterarFuncionario : Form
    {
        ControladorFrmAlterarFuncionario controladorFrmAlterarFuncionario;
        public FrmAlterarFuncionario()
        {
            InitializeComponent();
            controladorFrmAlterarFuncionario = new ControladorFrmAlterarFuncionario(txtCodigo, txtNome, txtEndereco, txtNumero, txtCidade, txtBairro, txtComplemento, txtReferencia, txtEmail, txtCargo, mkdCpf, mkdDataNascimento, mkdTelefone, mkdCelular, mkdCep, cboSexo, cboEstCivil, cboEstado);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtCodFuncionario.Text.Length > 0)
            {
                if (controladorFrmAlterarFuncionario.BuscarFuncionario(Convert.ToInt32(txtCodFuncionario.Text)) == true)
                {
                    gpbEndereco.Enabled = true;
                    gpbInfoPessoal.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Codigo do cliente não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if((txtNome.Text.Length == 0) || (mkdCpf.Text == "###.###.###-##") | (txtEmail.Text.Length == 0) || (mkdDataNascimento.Text == "##/##/####") || (mkdTelefone.Text == "(##)####-####") || (mkdCelular.Text == "(##)#####-####") || (cboSexo.SelectedIndex == 1) || (cboEstCivil.SelectedIndex == -1) || (txtCargo.Text.Length == 0) || (mkdCep.Text == "#####-###") || (txtEndereco.Text.Length == 0) || (txtNumero.Text.Length == 0) || (cboEstado.SelectedIndex == -1) || (txtCidade.Text.Length == 0) || (txtBairro.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmAlterarFuncionario.AlterarFuncionario() == true)
                {
                    controladorFrmAlterarFuncionario.Limpar();
                }
            }
        }
    }
}
