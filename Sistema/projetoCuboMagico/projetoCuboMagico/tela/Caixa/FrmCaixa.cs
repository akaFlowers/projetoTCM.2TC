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

namespace projetoCuboMagico.tela.Caixa
{
    public partial class FrmCaixa : Form
    {
        ControladorFrmCaixa controladorFrmCaixa;
        public FrmCaixa()
        {
            InitializeComponent();
            controladorFrmCaixa = new ControladorFrmCaixa(dgvCliente, txtCodigo, txtNome);
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            controladorFrmCaixa.PopularGrid();
        }

        private void dgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            controladorFrmCaixa.CellClick(e);
        }

        private void ckbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNome.CheckState == CheckState.Checked)
            {
                ckbCodigo.CheckState = CheckState.Unchecked;
                txtNome.Enabled = true;
                txtCodigo.Enabled = false;
            }
            else
            {
                txtNome.Enabled = false;
                txtNome.Text = null;
            }
        }

        private void CkbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCodigo.CheckState == CheckState.Checked)
            {
                ckbNome.CheckState = CheckState.Unchecked;
                txtNome.Enabled = false;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == true)
            {
                if(txtCodigo.Text.Length != 0)
                {
                    controladorFrmCaixa.BuscarPorCodigo();
                }
                else
                {
                    MessageBox.Show("Codigo não pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (txtNome.Enabled == true)
            {
                if(txtNome.Text.Length != 0)
                {
                    controladorFrmCaixa.BuscarPorNome();

                }
                else
                {
                    MessageBox.Show("Nome não pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção de pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            controladorFrmCaixa.PopularGrid();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
    }
}
