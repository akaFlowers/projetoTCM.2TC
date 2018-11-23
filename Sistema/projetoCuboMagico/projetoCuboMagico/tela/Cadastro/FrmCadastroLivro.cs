using projetoCuboMagico.controlador.ControladorLivro;
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

namespace projetoCuboMagico.tela.Cadastro.Livro
{
    public partial class FrmCadastroLivro : Form
    {
        ControladorFrmCadastroLivro controladorFrmCadastroLivro;
        RepositorioLivro repositorioLivro;
        public FrmCadastroLivro()
        {
            InitializeComponent();
            controladorFrmCadastroLivro = new ControladorFrmCadastroLivro(txtCodigo, txtNome, txtAutor, txtQtdPaginas, txtSinopse, txtQuantidade, txtValor, mkdDataPublicacao, cboCapa, cboEditora, cboGenero);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controladorFrmCadastroLivro.Limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if((txtNome.Text.Length == 0) || (cboCapa.SelectedIndex == -1) || (txtAutor.Text.Length == 0) || (cboEditora.SelectedIndex == -1) || (txtQtdPaginas.Text.Length == 0) || (cboGenero.SelectedIndex == -1) || (txtSinopse.Text.Length == 0))
            {
                MessageBox.Show("Campos com * são obrigatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (controladorFrmCadastroLivro.IncluirLivro() == true)
                {
                    controladorFrmCadastroLivro.Limpar();
                    txtCodigo.Text = controladorFrmCadastroLivro.BuscarID().ToString();
                }
                else
                {

                }
            }
          
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            repositorioLivro = new RepositorioLivro();
            txtCodigo.Text = controladorFrmCadastroLivro.BuscarID().ToString();
            repositorioLivro.BuscarEditora(cboEditora);
        }

        private void cboEditora_DropDown(object sender, EventArgs e)
        {
            repositorioLivro.BuscarEditora(cboEditora);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
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

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            
            }
            else
            {
                e.Handled = true;
            }

        }

        private void mkdDataPublicacao_Click(object sender, EventArgs e)
        {
            mkdDataPublicacao.Focus();
            mkdDataPublicacao.Select(0, 0);
        }
    }
}
