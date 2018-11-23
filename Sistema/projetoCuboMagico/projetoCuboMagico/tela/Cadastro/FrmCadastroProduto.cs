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

namespace projetoCuboMagico.tela.Cadastro
{
    public partial class FrmCadastroProduto : Form
    {
        ControladorFrmCadastroProduto controladorFrmCadastroProduto;
        public FrmCadastroProduto()
        {
            InitializeComponent();
            controladorFrmCadastroProduto = new ControladorFrmCadastroProduto(txtCodigo, txtNome, txtQuantidade, txtDescricao, txtValor);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if((txtNome.Text.Length == 0) || (txtQuantidade.Text.Length == 0) || (txtValor.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmCadastroProduto.IncluirProduto() == true)
                {
                    txtCodigo.Text = controladorFrmCadastroProduto.BuscarCodProduto().ToString();
                    controladorFrmCadastroProduto.Limpar();
                }
            } 
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = controladorFrmCadastroProduto.BuscarCodProduto().ToString();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
