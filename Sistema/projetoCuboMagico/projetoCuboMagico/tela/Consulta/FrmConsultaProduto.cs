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

namespace projetoCuboMagico.tela.Consulta
{
    public partial class FrmConsultaProduto : Form
    {
        ControladorFrmConsultaProduto controladorFrmConsultaProduto;
        public FrmConsultaProduto()
        {
            InitializeComponent();
            controladorFrmConsultaProduto = new ControladorFrmConsultaProduto(txtNome, txtCodigo, dgvProduto);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == true)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    dgvProduto.DataSource = controladorFrmConsultaProduto.ConsultaPorCodigo(txtCodigo.Text);
                }
                else
                {
                    MessageBox.Show("Codigo não pode estar vazio");
                }
            }
            else if (txtNome.Enabled == true)
            {
                if (txtNome.Text.Length > 0)
                {
                    dgvProduto.DataSource = controladorFrmConsultaProduto.ConsultaPorNome(txtNome.Text);
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

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = controladorFrmConsultaProduto.ListarTodos();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = controladorFrmConsultaProduto.ListarTodos();
        }

        private void ckbCodigo_CheckedChanged(object sender, EventArgs e)
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
    }
}
