using projetoCuboMagico.controlador;
using projetoCuboMagico.persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Cadastro
{
    public partial class FrmCadastroUsuario : Form
    {
        ControladorFrmCadastroUsuario controladorFrmCadastroUsuario;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            controladorFrmCadastroUsuario = new ControladorFrmCadastroUsuario(txtCodigo, txtUsuario, txtSenha, txtCodFunc, cboTipoAcesso, dgvFuncionarios);
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = controladorFrmCadastroUsuario.ListarTodosFuncionarios();
            dgvUsuarios.DataSource = controladorFrmCadastroUsuario.ListarTodosUsuario();
            txtCodigo.Text = controladorFrmCadastroUsuario.BuscarCodigoUsuario().ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text.Length == 0) || (txtSenha.Text.Length == 0 ) || (txtCodFunc.Text.Length == 0) || (cboTipoAcesso.SelectedIndex == -1))
            {
                MessageBox.Show("Campos com * são obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmCadastroUsuario.IncluirUsuario() == true)
                {
                    controladorFrmCadastroUsuario.Limpar();
                    dgvFuncionarios.DataSource = controladorFrmCadastroUsuario.ListarTodosFuncionarios();
                    dgvUsuarios.DataSource = controladorFrmCadastroUsuario.ListarTodosUsuario();
                    txtCodigo.Text = controladorFrmCadastroUsuario.BuscarCodigoUsuario().ToString();
                }
            }
        }

        private void ckbExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExibirSenha.CheckState == CheckState.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtCodFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
    }
}
