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

namespace projetoCuboMagico.tela.Caixa
{
    public partial class FrmFecharBox : Form
    {
        ControladorFrmFecharCaixa controladorFrmFecharCaixa;
        int codigo1;
        public FrmFecharBox()
        {
            InitializeComponent();

        }

        public FrmFecharBox(int codigo)
        {
            InitializeComponent();
            codigo1 = codigo;
            controladorFrmFecharCaixa = new ControladorFrmFecharCaixa(codigo1, dgvCaixa, lblNomeCliente, lblCpfCliente, lblTelefoneCliente);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFecharBox_Load(object sender, EventArgs e)
        {
            controladorFrmFecharCaixa.VerificarCliente();
            controladorFrmFecharCaixa.BuscarInformacoesCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        Point ArrastarCursor;
        Point ArrastarForm;
        bool arrastando;

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void btnFecharBox_Click(object sender, EventArgs e)
        {
            if(controladorFrmFecharCaixa.CadastrarLivrosSorteados() == true)
            {
                this.Close();
            }
        }
    }
}
