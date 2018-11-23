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
    public partial class FrmConsultaUsuario : Form
    {
        ControladorFrmConsultaUsuario controladorFrmConsulta;
        public FrmConsultaUsuario()
        {
            InitializeComponent();
            controladorFrmConsulta = new ControladorFrmConsultaUsuario(txtCodigo, txtUsuario, dgvUsuário);
        }

        private void ckbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCodigo.CheckState == CheckState.Checked)
            {
                ckbNome.CheckState = CheckState.Unchecked;
                txtUsuario.Enabled = false;
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
                txtUsuario.Enabled = true;
                txtCodigo.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtUsuario.Text = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == true)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    controladorFrmConsulta.ConsultaPorCodigo();
                }
                else
                {
                    MessageBox.Show("Codigo não pode estar vazio");
                }
            }
            else if (txtUsuario.Enabled == true)
            {
                if (txtUsuario.Text.Length > 0)
                {
                    controladorFrmConsulta.ConsultaPorUsuario();
                }
                else
                {
                    MessageBox.Show("Nome de usuário não pode estar vazio");
                }
            }
            else
            {
                MessageBox.Show("Escolha consulta por nome ou codigo.");

            }
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            controladorFrmConsulta.ListarTodos();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            controladorFrmConsulta.ListarTodos();
        }
    }
}
