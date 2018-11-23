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
    public partial class FrmAlterarUsuario : Form
    {
        ControladorFrmAlterarUsuario controladorFrmAlterarUsuario;
        public FrmAlterarUsuario()
        {
            InitializeComponent();
            controladorFrmAlterarUsuario = new ControladorFrmAlterarUsuario(txtUsuario, txtSenha, txtCodFunc, txtCodigo, cboTipoAcesso, dgvUsuario);
        }

        string user;

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if(txtNomeUsuario.Text.Length > 0)
            {
                user = txtNomeUsuario.Text;
                if (controladorFrmAlterarUsuario.BuscarUsuario(txtNomeUsuario.Text))
                {
                    gpbCadastrarUsuario.Enabled = true;
                    btnAlterar.Enabled = true;
                    
                }
            }
            else
            {
                MessageBox.Show("Código do Usuário não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmAlterarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = controladorFrmAlterarUsuario.ListarTodos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text.Length == 0) || (txtSenha.Text.Length == 0) || (cboTipoAcesso.SelectedIndex == -1) || (txtCodFunc.Text.Length == 0))
            {
                MessageBox.Show("Campos com * não podem estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmAlterarUsuario.AlterarUsuario(user) == true)
                {
                    controladorFrmAlterarUsuario.Limpar();
                    txtCodFunc.Text = null;
                    dgvUsuario.DataSource = controladorFrmAlterarUsuario.ListarTodos();
                }
            }
        }

    }
}
