using projetoCuboMagico.Controlador;
using projetoCuboMagico.repositorio;
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
    public partial class FrmAlterarLivro : Form
    {
        ControladorFrmAlterarLivro controladorFrmAlterarLivro;
        RepositorioLivro repositorioLivro;
        public FrmAlterarLivro()
        {
            InitializeComponent();
            controladorFrmAlterarLivro = new ControladorFrmAlterarLivro(txtCodigo, txtNome, txtAutor, txtQtdPaginas, txtSinopse, txtQuantidade, txtValor, mkdDataPublicacao, cboCapa, cboEditora, cboGenero);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if ((txtNome.Text.Length == 0) || (cboCapa.SelectedIndex == -1) || (txtAutor.Text.Length == 0) || (cboEditora.SelectedIndex == -1) || (txtQtdPaginas.Text.Length == 0) || (cboGenero.SelectedIndex == -1) || (txtSinopse.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmAlterarLivro.AlterarLivro() == true)
                {
                    controladorFrmAlterarLivro.Limpar();
                }
            }
        }

        private void btnBuscarLivro_Click(object sender, EventArgs e)
        {
            if (txtCodLivro.Text.Length > 0)
            {
                if (controladorFrmAlterarLivro.BuscarLivro(Convert.ToInt32(txtCodLivro.Text)) == true)
                {
                    gpbInfoLivro.Enabled = true;
                    txtValor.Enabled = true;
                    txtQuantidade.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Codigo não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboEditora_DropDown(object sender, EventArgs e)
        {
            repositorioLivro = new RepositorioLivro();
            repositorioLivro.BuscarEditora(cboEditora);
        }

        private void FrmAlterarLivro_Load(object sender, EventArgs e)
        {
            repositorioLivro = new RepositorioLivro();
            repositorioLivro.BuscarEditora(cboEditora);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtQtdPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
