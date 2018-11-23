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
    public partial class FrmAlterarEditora : Form
    {
        ControladorFrmAlterarEditora controladorFrmAlterarEditora;
        public FrmAlterarEditora()
        {
            InitializeComponent();
            controladorFrmAlterarEditora = new ControladorFrmAlterarEditora(txtCodigo, txtNome, txtEmail, mkdCnpj, mkdTelefone, cboPais);
        }

        private void btnBuscarEditora_Click(object sender, EventArgs e)
        {
            if(txtCodEditora.Text.Length != 0)
            {
                if (controladorFrmAlterarEditora.BuscarEditora(Convert.ToInt32(txtCodEditora.Text)) == true)
                {
                    gpbCadastrarEditora.Enabled = true;
                    btnAlterar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Codigo da editora não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Length == 0) || (mkdCnpj.Text == "##.###.###/####-##") || (mkdTelefone.Text == "(##)####-####") || (cboPais.SelectedIndex == -1) || (txtEmail.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmAlterarEditora.AlterarEditora() == true)
                {
                    controladorFrmAlterarEditora.Limpar();
                    gpbCadastrarEditora.Enabled = false;
                    btnAlterar.Enabled = false;
                }
            }
        }
    }
}
