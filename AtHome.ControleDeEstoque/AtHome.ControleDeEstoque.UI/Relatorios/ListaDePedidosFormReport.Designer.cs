namespace AtHome.ControleDeEstoque.UI.Relatórios
{
    partial class ListaDePedidosFormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ItemDoPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptListaDePedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDoPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemDoPedidoBindingSource
            // 
            this.ItemDoPedidoBindingSource.DataSource = typeof(AtHome.ControleDeEstoque.Domain.ItemDoPedido);
            // 
            // rptListaDePedidos
            // 
            this.rptListaDePedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetListaDePedidos";
            reportDataSource2.Value = this.ItemDoPedidoBindingSource;
            this.rptListaDePedidos.LocalReport.DataSources.Add(reportDataSource2);
            this.rptListaDePedidos.LocalReport.ReportEmbeddedResource = "AtHome.ControleDeEstoque.UI.Relatorios.ListaDePedidosReport.rdlc";
            this.rptListaDePedidos.Location = new System.Drawing.Point(0, 0);
            this.rptListaDePedidos.Name = "rptListaDePedidos";
            this.rptListaDePedidos.Size = new System.Drawing.Size(545, 434);
            this.rptListaDePedidos.TabIndex = 0;
            this.rptListaDePedidos.Load += new System.EventHandler(this.rptListaDePedidos_Load);
            // 
            // ListaDePedidosFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 434);
            this.Controls.Add(this.rptListaDePedidos);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "ListaDePedidosFormReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaDePedidosRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDoPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptListaDePedidos;
        private System.Windows.Forms.BindingSource ItemDoPedidoBindingSource;
    }
}