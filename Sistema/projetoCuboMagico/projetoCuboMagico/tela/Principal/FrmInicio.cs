using projetoCuboMagico.tela.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.tela.Principal
{
    public partial class FrmInicio : Form
    {
        TelaPrincipal telaPrincipal;
        FrmCadastroCliente frmCadastroCliente;

        public FrmInicio()
        {
            InitializeComponent();
            telaPrincipal = new TelaPrincipal();

            
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Point p = new Point(263, 75);
            frmCadastroCliente = new FrmCadastroCliente { Location = p };
            frmCadastroCliente.Show();

        }

        
    }
}
