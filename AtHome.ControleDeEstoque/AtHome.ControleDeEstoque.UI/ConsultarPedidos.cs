using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.UI.Relatórios;
using System;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class ConsultarPedidos : Form
    {
        public ConsultarPedidos()
        {
            InitializeComponent();
        }

        long _idPedido;

        public long PedidoID
        {
            get { return _idPedido; }
        }
        
        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            try
            {            
                PedidoDAO pedidoDAO = new PedidoDAO();

                grdPedido.DataSource = pedidoDAO.GetAllPedido();
                grdPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                grdPedido.Columns["Id"].Visible = false;
                grdPedido.Columns["TipoOperacao"].Visible = false;
                grdPedido.Columns["PedidoFinalizado"].Visible = false;
            
                grdPedido.Columns["Numero"].Width = 80;
                grdPedido.Columns["Numero"].HeaderText = "Número";

                grdPedido.Columns["DataHora"].Width = 160;
                grdPedido.Columns["DataHora"].HeaderText = "Data";

                grdPedido.Columns["Observacao"].Width = 200;
                grdPedido.Columns["Observacao"].HeaderText = "Observação";

                grdPedido.Columns["Valor"].Width = 100;
                grdPedido.Columns["Valor"].HeaderText = "Valor";

                this.grdPedido.Columns["Numero"].DefaultCellStyle.Format = "#0";
                this.grdPedido.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdPedido.Columns["DataHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                this.grdPedido.Columns["DataHora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdPedido.Columns["Observacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.grdPedido.Columns["Valor"].DefaultCellStyle.Format = "c";
                this.grdPedido.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ConsultarPedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grdPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _idPedido = Convert.ToInt64(grdPedido.Rows[e.RowIndex].Cells["Id"].Value);
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (grdPedido.SelectedRows.Count == 0)
                return;

            var idPedido = Convert.ToInt64(grdPedido.SelectedRows[0].Cells["Id"].Value);

            ListaDePedidosFormReport relatorio = new ListaDePedidosFormReport(idPedido);
            relatorio.ShowDialog();
        }

    }
}
