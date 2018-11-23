using projetoCuboMagico.controlador;
using projetoCuboMagico.ControladorCliente;
using projetoCuboMagico.domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Consulta
{
    public partial class FrmConsultaCliente : Form
    {
        ControladorFrmConsultaCliente controladorFrmConsultaCliente;
        public FrmConsultaCliente()
        {
            InitializeComponent();
            controladorFrmConsultaCliente = new ControladorFrmConsultaCliente(txtCodigo, dgvCliente);

        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = controladorFrmConsultaCliente.ListarTodos();
            txtCodigo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Enabled == true)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    dgvCliente.DataSource = controladorFrmConsultaCliente.ConsultaPorCodigo(Convert.ToInt32(txtCodigo.Text));
                }
                else
                {
                    MessageBox.Show("Codigo não pode estar vazio");
                }
            }
            else if(txtNome.Enabled == true)
            {
                if (txtNome.Text.Length > 0)
                {
                    dgvCliente.DataSource = controladorFrmConsultaCliente.ConsultaPorNome(txtNome.Text);
                }
                else
                {
                    MessageBox.Show("Nome não pode estar vazio");
                }
            }
            else
            {
                MessageBox.Show("Escolha consulta por nome ou codigo.");
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = controladorFrmConsultaCliente.ListarTodos();
        }

        private void ckbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbCodigo.CheckState == CheckState.Checked)
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

        private void ckbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbCodigo.Checked)
                {
                    ckbCodigo.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbCodigo.CheckState = CheckState.Checked;
                }
            }
        }

        private void ckbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (ckbNome.Checked)
                {
                    ckbNome.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbNome.CheckState = CheckState.Checked;
                }
            }
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
