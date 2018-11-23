using projetoCuboMagico.controlador.ControladorEditora;
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
    public partial class FrmCadastroEditora : Form
    {
        ControladorFrmCadastroEditora controladorFrmCadastroEditora;
        public FrmCadastroEditora()
        {
            InitializeComponent();
            controladorFrmCadastroEditora = new ControladorFrmCadastroEditora(txtCodigo, txtNome, txtEmail, mkdCnpj, mkdTelefone, cboPais);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if((txtNome.Text.Length == 0) || (mkdCnpj.Text == "##.###.###/####-##") || (mkdTelefone.Text == "(##)####-####") || (cboPais.SelectedIndex == -1) || (txtEmail.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmCadastroEditora.IncluirEditora() == true)
                {
                    controladorFrmCadastroEditora.Limpar();
                    txtCodigo.Text = controladorFrmCadastroEditora.BuscarID().ToString();
                }
            }
        }

        private void FrmCadastroEditora_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = controladorFrmCadastroEditora.BuscarID().ToString();
        }

        private void mkdCnpj_Click(object sender, EventArgs e)
        {
            mkdCnpj.Focus();
            mkdCnpj.Select(0, 0);
        }

        private void mkdTelefone_Click(object sender, EventArgs e)
        {
            mkdTelefone.Focus();
            mkdTelefone.Select(0, 0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controladorFrmCadastroEditora.Limpar();
        }
    }
}
