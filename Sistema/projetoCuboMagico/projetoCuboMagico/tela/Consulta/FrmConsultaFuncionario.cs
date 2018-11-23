using projetoCuboMagico.controlador;
using projetoCuboMagico.controlador.Funcionário;
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
    public partial class FrmConsultaFuncionario : Form
    {
        ControladorFrmConsultaFuncionario controladorFrmConsultaFuncionario;
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
            controladorFrmConsultaFuncionario = new ControladorFrmConsultaFuncionario(txtCodigo, txtNome, dgvFuncionario);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == true)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    dgvFuncionario.DataSource = controladorFrmConsultaFuncionario.ConsultaPorCodigo(Convert.ToInt32(txtCodigo.Text));
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
                    dgvFuncionario.DataSource = controladorFrmConsultaFuncionario.ConsultaPorNome(txtNome.Text);
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
            dgvFuncionario.DataSource = controladorFrmConsultaFuncionario.ListarTodos();
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = controladorFrmConsultaFuncionario.ListarTodos();
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
