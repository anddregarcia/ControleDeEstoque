using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class ConsultarLog : Form
    {
        public long IdItem { get; set; }
        public String GrupoNome { get; set; }

        public ConsultarLog(long idItem, String grupo)
        {
            InitializeComponent();
            this.IdItem = idItem;
            this.GrupoNome = grupo;  
        }

        private void CarregarGrid()
        {
            int dias = 30;
                       
            try
            {

                grdLog.DataSource = LogDAO.GetLogByID(IdItem, dias);

                grdLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdLog.AllowUserToDeleteRows = false;
                grdLog.RowHeadersVisible = false;

                grdLog.Columns["IdItem"].Visible = false;
                grdLog.Columns["IdPedido"].Visible = false;
                grdLog.Columns["TpOperacao"].Visible = false;

                grdLog.Columns["DataHora"].Width = 100;
                grdLog.Columns["DataHora"].HeaderText = "Data";

                grdLog.Columns["Descricao"].Width = 200;
                grdLog.Columns["Descricao"].HeaderText = "Nome do Item";

                grdLog.Columns["QuantidadeAnterior"].Width = 80;
                grdLog.Columns["QuantidadeAnterior"].HeaderText = "Qtd. Anterior";

                grdLog.Columns["QuantidadeAtual"].Width = 80;
                grdLog.Columns["QuantidadeAtual"].HeaderText = "Qtd. Atual";

                grdLog.Columns["QuantidadeInformada"].Width = 80;
                grdLog.Columns["QuantidadeInformada"].HeaderText = "Qtd. Informada";

                grdLog.Columns["Origem"].Width = 150;
                grdLog.Columns["Origem"].HeaderText = "Tela";

                grdLog.Columns["TpOperacaoNome"].Width = 80;
                grdLog.Columns["TpOperacaoNome"].HeaderText = "Operação";

                grdLog.Columns["PedidoNumero"].Width = 80;
                grdLog.Columns["PedidoNumero"].HeaderText = "Pedido";
                
                this.grdLog.Columns["DataHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                this.grdLog.Columns["DataHora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdLog.Columns["QuantidadeAnterior"].DefaultCellStyle.Format = "#0";
                this.grdLog.Columns["QuantidadeAnterior"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdLog.Columns["QuantidadeAtual"].DefaultCellStyle.Format = "#0";
                this.grdLog.Columns["QuantidadeAtual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdLog.Columns["QuantidadeInformada"].DefaultCellStyle.Format = "#0";
                this.grdLog.Columns["QuantidadeInformada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdLog.Columns["Origem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdLog.Columns["TpOperacaoNome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdLog.Columns["PedidoNumero"].DefaultCellStyle.Format = "#0";
                this.grdLog.Columns["PedidoNumero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConsultarLog_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lblBarra.Text = "Grupo: " + this.GrupoNome;
        }

    }
}
