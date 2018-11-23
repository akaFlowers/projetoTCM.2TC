using projetoCuboMagico.controlador;
using projetoCuboMagico.domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Login
{
    public partial class TelaLogin : Form
    {
        ControladorTelaLogin controladorTelaLogin;
        TelaPrincipal telaPrincipal;
        public TelaLogin()
        {
            InitializeComponent();
            controladorTelaLogin = new ControladorTelaLogin(txtUsuario, txtSenha);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (controladorTelaLogin.Login() == true)
            {
                this.Hide();
                telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog();
            }
            else
            {

            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.Select(0, 0);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if((Keys)e.KeyChar == Keys.Enter)
            {
                if (controladorTelaLogin.Login() == true)
                {
                    this.Hide();
                    telaPrincipal = new TelaPrincipal();
                    telaPrincipal.ShowDialog();
                }
            }
            
        }
        Point ArrastarCursor;
        Point ArrastarForm;
        bool arrastando;

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }
    }
}
