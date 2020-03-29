using System;
using System.Text;
using System.Windows.Forms;
using AtHome.ControleDeEstoque.Domain;
using AtHome.ControleDeEstoque.Data;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class CadastroDeItem : Form
    {
        long _id;
        long _idGrupo;
        ItemDAO _itemDAO = new ItemDAO();
        GrupoDAO _grupoDAO = new GrupoDAO();

        private enum ColunasEstoque
        {
            Somar = 0,
            Subtrair = 1,
            Substituir = 2
        }

        public CadastroDeItem(long idGrupo)
        {
            InitializeComponent();
            _idGrupo = idGrupo;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            _id = 0;
            txtNomeItem.Text = String.Empty;
            txtQtdAtual.Text = String.Empty;
            txtEstoqueMinimo.Text = String.Empty;
            txtPorcentagem.Text = String.Empty;
            txtPrecoCusto.Text = String.Empty;
            txtPrecoVenda.Text = String.Empty;
            txtTamanho.Text = String.Empty;
            grdItens.ClearSelection();
            txtNomeItem.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void SalvarRegistro()
        {
            if (MessageBox.Show("Deseja salvar?", CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
            {
                Item item = null;
                long quantidadeAnterior = 0;

                if (!Validacao()) return;

                if (txtEstoqueMinimo.Text == String.Empty) txtEstoqueMinimo.Text = "0";

                if (!_id.Equals(0))
                {
                    item = _itemDAO.GetDataByID(_id);
                    item.Descricao = txtNomeItem.Text;
                    item.EstoqueMinimo = Convert.ToInt64(txtEstoqueMinimo.Text);
                    item.GrupoId = _idGrupo;
                    item.PorcentagemLucro = Convert.ToDouble(txtPorcentagem.Text);
                    item.PrecoCusto = Convert.ToDouble(txtPrecoCusto.Text);
                    item.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
                    item.Quantidade = Convert.ToInt64(txtQtdAtual.Text);
                    item.Tamanho = txtTamanho.Text;
                    
                    quantidadeAnterior = item.Quantidade;
                    
                }
                else
                {
                    item = new Item(txtNomeItem.Text,
                                    txtTamanho.Text,
                                    _idGrupo,
                                    Convert.ToInt64(txtQtdAtual.Text),
                                    Convert.ToInt64(txtEstoqueMinimo.Text),
                                    Convert.ToDouble(txtPrecoCusto.Text),
                                    Convert.ToDouble(txtPrecoVenda.Text),
                                    Convert.ToDouble(txtPorcentagem.Text));
                }

                try
                {
                    if (!item.Id.Equals(0))
                    {
                        _itemDAO.Update(item);

                        Log log = new Log()
                        {
                            IdItem = item.Id,
                            Descricao = item.Descricao + " (" + item.Tamanho + ")",
                            QuantidadeAnterior = quantidadeAnterior,
                            QuantidadeAtual = item.Quantidade,
                            QuantidadeInformada = item.Quantidade,
                            Origem = this.Text,
                            TpOperacao = Enumeradores.TipoOperacao.Substituir,
                            IdPedido = 0,
                            PedidoNumero = 0
                        };

                        log.GravarRastreabilidade();
                    }
                    else
                    {
                        _id = _itemDAO.Save(item);

                        Log log = new Log()
                        {
                            IdItem = item.Id,
                            Descricao = item.Descricao + " (" + item.Tamanho + ")",
                            QuantidadeAnterior = 0,
                            QuantidadeAtual = item.Quantidade,
                            QuantidadeInformada = item.Quantidade,
                            Origem = this.Text,
                            TpOperacao = Enumeradores.TipoOperacao.Novo,
                            IdPedido = 0,
                            PedidoNumero = 0
                        };

                        log.GravarRastreabilidade();
                    }

                    CarregarDataGrid();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        bool Validacao()
        {
            StringBuilder msg = new StringBuilder("");

            if (txtNomeItem.Text == String.Empty)
                msg.Append("Digitar o nome do grupo!\n");

            if (txtQtdAtual.Text == String.Empty)
                msg.Append("Digitar a quantidade atual!\n");

            if (txtTamanho.Text == String.Empty)
                msg.Append("Digitar o tamanho!\n");

            if (txtPrecoCusto.Text == String.Empty)
                msg.Append("Digitar o preço de custo!\n");

            if (txtPorcentagem.Text == String.Empty)
                msg.Append("Digitar a porcetagem de lucro!\n");

            if (txtPrecoVenda.Text == String.Empty)
                msg.Append("Digitar o preço de venda!\n");

            if (msg.ToString() == String.Empty)
                return true;

            MessageBox.Show(msg.ToString(), CadastroDeItem.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void CarregarDataGrid()
        {
            try
            {
                this.grdItens.RowEnter -= new
                    DataGridViewCellEventHandler(grdItens_RowEnter);

                grdItens.DataSource = _itemDAO.GetDataByGrupoId(_idGrupo);
                grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdItens.AllowUserToDeleteRows = false;

                grdItens.Columns["Id"].Visible = false;
                grdItens.Columns["GrupoId"].Visible = false;
                grdItens.Columns["Grupo"].Visible = false;

                grdItens.Columns["Descricao"].Width = 300;
                grdItens.Columns["Descricao"].HeaderText = "Nome do Item";

                grdItens.Columns["Tamanho"].Width = 80;
                grdItens.Columns["Tamanho"].HeaderText = "Tamanho";

                grdItens.Columns["Quantidade"].Width = 150;
                grdItens.Columns["Quantidade"].HeaderText = "Estoque Atual";

                grdItens.Columns["EstoqueMinimo"].Width = 150;
                grdItens.Columns["EstoqueMinimo"].HeaderText = "Estoque Mínimo";

                grdItens.Columns["PrecoCusto"].Width = 150;
                grdItens.Columns["PrecoCusto"].HeaderText = "Preço de Custo";

                grdItens.Columns["PorcentagemLucro"].Width = 100;
                grdItens.Columns["PorcentagemLucro"].HeaderText = "% Lucro";

                grdItens.Columns["PrecoVenda"].Width = 150;
                grdItens.Columns["PrecoVenda"].HeaderText = "Preço de Venda";

                this.grdItens.RowEnter += new
                    DataGridViewCellEventHandler(grdItens_RowEnter);

                this.grdItens.Columns["Quantidade"].DefaultCellStyle.Format = "#0";
                this.grdItens.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItens.Columns["EstoqueMinimo"].DefaultCellStyle.Format = "#0";
                this.grdItens.Columns["EstoqueMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItens.Columns["Tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdItens.Columns["PrecoCusto"].DefaultCellStyle.Format = "c";
                this.grdItens.Columns["PrecoCusto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItens.Columns["PrecoVenda"].DefaultCellStyle.Format = "c";
                this.grdItens.Columns["PrecoVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItens.Columns["PorcentagemLucro"].DefaultCellStyle.Format = "p";
                this.grdItens.Columns["PorcentagemLucro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdItens_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)grdItens.Rows[e.RowIndex];
            txtNomeItem.Text = row.Cells["Descricao"].Value.ToString();
            txtTamanho.Text = row.Cells["Tamanho"].Value.ToString();
            txtQtdAtual.Text = row.Cells["Quantidade"].Value.ToString();
            txtEstoqueMinimo.Text = row.Cells["EstoqueMinimo"].Value.ToString();
            txtPrecoCusto.Text = row.Cells["PrecoCusto"].Value.ToString();
            txtPorcentagem.Text = row.Cells["PorcentagemLucro"].EditedFormattedValue.ToString().Replace("%", "");
            txtPrecoVenda.Text = row.Cells["PrecoVenda"].Value.ToString();
            _id = Convert.ToInt64(row.Cells["id"].Value.ToString());
        }

        private void txtQtdAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica(sender, e, false);
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica(sender, e, false);
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica(sender, e, true);
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica(sender, e, true);
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica(sender, e, true);
        }

        void ValidacaoNumerica(object sender, KeyPressEventArgs e, bool permite_decimal)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if (!permite_decimal && e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void txtQtdAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) SalvarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    Item item = _itemDAO.GetDataByID(_id);
                    _itemDAO.Delete(item);

                    Log log = new Log()
                    {
                        IdItem = item.Id,
                        Descricao = item.Descricao + " (" + item.Tamanho + ")",
                        QuantidadeAnterior = item.Quantidade,
                        QuantidadeAtual = item.Quantidade,
                        QuantidadeInformada = item.Quantidade,
                        Origem = this.Text,
                        TpOperacao = Enumeradores.TipoOperacao.Excluir,
                        IdPedido = 0,
                        PedidoNumero = 0
                    };

                    log.GravarRastreabilidade();

                    CarregarDataGrid();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CadastroDeItem_Load(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo = _grupoDAO.GetDataByID(_idGrupo);

            CarregarDataGrid();

            lblGrupo.Text = "Grupo: " + grupo.Descricao;
        }

        private void CadastroDeItem_Activated(object sender, EventArgs e)
        {
            txtNomeItem.Focus();
        }

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
        }

        private void CalcularPrecoVenda()
        {
            if (txtPrecoCusto.Text != String.Empty && txtPorcentagem.Text != String.Empty)
            {
                txtPrecoVenda.Text = (Convert.ToDouble(txtPrecoCusto.Text) + (Convert.ToDouble(txtPorcentagem.Text) / 100 *
                                                                             Convert.ToDouble(txtPrecoCusto.Text))).ToString();
            }
        }

        private void btnCalcularPorcetagem_Click(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
            txtPrecoVenda.Focus();
        }

        private void CadastroDeItem_Resize(object sender, EventArgs e)
        {
            grdItens.Width = CadastroDeItem.ActiveForm.Width - 30;
            grdItens.Height = CadastroDeItem.ActiveForm.Height - grdItens.Top - 50;
            lblGrupo.Width = CadastroDeItem.ActiveForm.Width - 30;
            lblLine.Width = CadastroDeItem.ActiveForm.Width - 30;
            btnFechar.Left = CadastroDeItem.ActiveForm.Width - btnFechar.Width - 30;
        }

        void ValidacaoApostrofo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39) //bloqueia apostrofo
            {
                e.Handled = true;
            }
        }
        private void txtNomeItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoApostrofo(sender, e);
        }

        private void txtTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoApostrofo(sender, e);
        }

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            //txtPrecoCusto.Text = txtPrecoCusto.Text.ToString("d");
        }

    }
}
