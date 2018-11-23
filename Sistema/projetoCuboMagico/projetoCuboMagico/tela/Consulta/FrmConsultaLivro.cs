using projetoCuboMagico.controlador.ControladorLivro;
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
    public partial class FrmConsultaLivro : Form
    {
        ControladorFrmConsultaLivro controladorFrmConsultaLivro;
        public FrmConsultaLivro()
        {
            InitializeComponent();
            controladorFrmConsultaLivro = new ControladorFrmConsultaLivro(txtCodigo, txtNome, cboGenero, dgvLivro);
        }

        private void ckbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCodigo.CheckState == CheckState.Checked)
            {
                ckbNome.CheckState = CheckState.Unchecked;
                txtNome.Enabled = false;
                ckbGenero.CheckState = CheckState.Unchecked;
                cboGenero.Enabled = false; ;
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
                ckbGenero.CheckState = CheckState.Unchecked;
                cboGenero.Enabled = false;
                txtCodigo.Enabled = false;
            }
            else
            {
                txtNome.Enabled = false;
                txtNome.Text = null;
            }
        }

        private void ckbGenero_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGenero.CheckState == CheckState.Checked)
            {
                ckbCodigo.CheckState = CheckState.Unchecked;
                cboGenero.Enabled = true;
                ckbNome.CheckState = CheckState.Unchecked;
                txtNome.Enabled = false;
                txtCodigo.Enabled = false;
            }
            else
            {
                cboGenero.Enabled = false;
                cboGenero.Text = null;
            }
        }

        private void FrmConsultaLivro_Load(object sender, EventArgs e)
        {
            dgvLivro.DataSource = controladorFrmConsultaLivro.ListarTodos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Enabled == true)
            {
                if(txtCodigo.Text.Length > 0)
                {
                    dgvLivro.DataSource = controladorFrmConsultaLivro.ConsultaPorCodigo(Convert.ToInt32(txtCodigo.Text));
                }
                else
                {
                    MessageBox.Show("Codigo não pode estar vazio");
                }
            }
            else if(txtNome.Enabled == true)
            {
                if(txtNome.Text.Length > 0)
                {
                    dgvLivro.DataSource = controladorFrmConsultaLivro.ConsultaPorNome(txtNome.Text);
                }
                else
                {
                    MessageBox.Show("Nome não pode estar vazio");
                }
            }
            else if(cboGenero.Enabled == true)
            {
                if (cboGenero.SelectedItem != null)
                {
                    dgvLivro.DataSource = controladorFrmConsultaLivro.ConsultaPorGenero(cboGenero.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione um gênero");
                }
            }

        }
    }
}
