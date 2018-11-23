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
    public partial class FrmAlterarProduto : Form
    {
        ControladorFrmAlterarProduto controladorFrmAlterarProduto;
        public FrmAlterarProduto()
        {
            InitializeComponent();
            controladorFrmAlterarProduto = new ControladorFrmAlterarProduto(txtCodigo, txtNome, txtQuantidade, txtDescricao, txtValor);
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            if(txtCodProduto.Text.Length != 0)
            {
                if (controladorFrmAlterarProduto.BuscarProduto(txtCodProduto.Text) == true)
                {
                    gpbInfoProduto.Enabled = true;
                    txtQuantidade.Enabled = true;
                    txtValor.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Código do cliente não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }





        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Length == 0) || (txtDescricao.Text.Length == 0) || (txtQuantidade.Text.Length == 0) || (txtValor.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            {
                controladorFrmAlterarProduto.AlterarProduto();
                controladorFrmAlterarProduto.Limpar();
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

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
    }
}
