using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI.Relatórios
{
    public partial class ListaDePedidosFormReport : Form
    {
        public ListaDePedidosFormReport(long idPedido)
        {
            InitializeComponent();
            this.PedidoId = idPedido;
        }

        private long PedidoId { get; set; }
        private Double ValorTotal { get; set; }

        private void ListaDePedidosRelatorio_Load(object sender, EventArgs e)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            ConfiguracaoDAO configDAO = new ConfiguracaoDAO();
            Pedido pedido = new Pedido();
            Configuracao config = new Configuracao();

            pedido = pedidoDAO.GetDataById(this.PedidoId);
            config = configDAO.GetData();

            var itens = pedidoDAO.GetAllItensDoPedido(this.PedidoId).ToArray();
            var dataSource = new ReportDataSource("DataSetListaDePedidos", itens);

            this.ValorTotal = pedido.Valor;

            this.rptListaDePedidos.LocalReport.DataSources.Clear();
            this.rptListaDePedidos.LocalReport.DataSources.Add(dataSource);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ValorTotal", this.ValorTotal.ToString("c")));
            reportParameters.Add(new ReportParameter("NomeEmpresa", config.NomeDaEmpresa));
            reportParameters.Add(new ReportParameter("Cabecalho", config.CabecalhoRelatorio));
            reportParameters.Add(new ReportParameter("Telefone", config.TelefoneRelatorio));
            if (!config.LogoTipo.Equals(String.Empty)) reportParameters.Add(new ReportParameter("Imagem", new Uri(config.LogoTipo).AbsoluteUri));
            this.rptListaDePedidos.LocalReport.EnableExternalImages = true;
            this.rptListaDePedidos.LocalReport.SetParameters(reportParameters);

            rptListaDePedidos.SetDisplayMode(DisplayMode.PrintLayout);
            rptListaDePedidos.ZoomMode = ZoomMode.Percent;
            rptListaDePedidos.ZoomPercent = 100;

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 25;
            pg.Margins.Right = 25;
            rptListaDePedidos.SetPageSettings(pg);

            this.rptListaDePedidos.RefreshReport();
        }

        private void rptListaDePedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
