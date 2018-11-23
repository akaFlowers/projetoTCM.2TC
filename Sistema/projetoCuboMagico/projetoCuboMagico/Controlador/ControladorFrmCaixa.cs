using projetoCuboMagico.repositorio;
using projetoCuboMagico.tela.Caixa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.Controlador
{
    class ControladorFrmCaixa
    {

        private DataGridView dgvCliente;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private int codigo;

        //Construtores


        public ControladorFrmCaixa()
        {

        }

        public ControladorFrmCaixa(DataGridView dgvCliente, TextBox txtCodigo, TextBox txtNome)
        {
            this.DgvCliente = dgvCliente;
            this.Codigo = codigo;
            this.TxtCodigo = txtCodigo;
            this.TxtNome = txtNome;
        }


        //Getters And Setters

        public DataGridView DgvCliente { get => dgvCliente; set => dgvCliente = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public TextBox TxtCodigo { get => txtCodigo; set => txtCodigo = value; }
        public TextBox TxtNome { get => txtNome; set => txtNome = value; }

        public void Inicializar()
        {

        }



        //Instancias
        RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        DataTable dt = new DataTable();

        //Codigo


        public bool CellClick (DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = this.dgvCliente.Columns[e.ColumnIndex];
            DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];

            if (Convert.ToInt32(column.Index) == 4)
            {
                codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
                FrmFecharBox frmFecharBox = new FrmFecharBox(codigo);
                frmFecharBox.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PopularGrid()
        {
            dt = repositorioCaixa.BuscarCliente();
            dt.Columns.Add("CAIXA", typeof(Image));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["CAIXA"] = Properties.Resources.caixa;
            }
            dgvCliente.RowTemplate.Height = 28;
            dgvCliente.DataSource = dt;

            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                if (column.DataPropertyName == "NOME")
                {
                    column.Width = 350;
                }
                if (column.DataPropertyName == "CODIGO")
                {
                    column.Width = 50;
                }
                if (column.DataPropertyName == "CAIXA")
                {
                    column.Width = 100;
                }
                    
            }

        }


        public void BuscarPorNome()
        {
            dt = repositorioCaixa.BuscarClientePorNome(txtNome.Text);
            dt.Columns.Add("CAIXA", typeof(Image));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["CAIXA"] = Properties.Resources.caixa;
            }
            dgvCliente.RowTemplate.Height = 28;
            dgvCliente.DataSource = dt;

            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                if (column.DataPropertyName == "NOME")
                {
                    column.Width = 350;
                }
                if (column.DataPropertyName == "CODIGO")
                {
                    column.Width = 50;
                }
                if (column.DataPropertyName == "CAIXA")
                {
                    column.Width = 100;
                }


                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void BuscarPorCodigo()
        {
            dt = repositorioCaixa.BuscarClientePorCodigo(txtCodigo.Text);
            dt.Columns.Add("CAIXA", typeof(Image));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["CAIXA"] = Properties.Resources.caixa;
            }
            dgvCliente.RowTemplate.Height = 28;
            dgvCliente.DataSource = dt;

            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                if (column.DataPropertyName == "NOME")
                {
                    column.Width = 350;
                }
                if (column.DataPropertyName == "CODIGO")
                {
                    column.Width = 50;
                }
                if (column.DataPropertyName == "CAIXA")
                {
                    column.Width = 100;
                }


                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void CadastrarLivrosSorteados()
        {

        }
        

    }
}
