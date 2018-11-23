using projetoCuboMagico.tela.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.Controlador
{
    class ControladorTelaPrincipal
    {
        private Panel pnlBase;


        //Construtores
        public ControladorTelaPrincipal()
        {
        }
  

        public ControladorTelaPrincipal(Panel pnlBase)
        {
            this.PnlBase = pnlBase;
        }

        //Getetrs And Setters
        public Panel PnlBase { get => pnlBase; set => pnlBase = value; }

        //instancia
        FrmCadastroCliente frmCadastroCliente;

        //Codigo

        public void MudarTela()
        {
            if (pnlBase.Controls.Count != 0)
            {
                pnlBase.Controls.RemoveAt(0);
            }
            frmCadastroCliente = new FrmCadastroCliente { TopLevel = false, Dock = DockStyle.Fill };
            pnlBase.Controls.Add(frmCadastroCliente);
            frmCadastroCliente.Show();

        }
    }
}
