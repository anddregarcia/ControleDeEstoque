using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;
using AtHome.ControleDeEstoque.UI.Relatórios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class ListaDePedidos : Form
    {
        public ListaDePedidos()
        {
            InitializeComponent();
        }

        ItemDAO _itemDAO = new ItemDAO();
        Pedido _pedido = new Pedido();
        BindingList<ItemDoPedido> _itensNoPedido = new BindingList<ItemDoPedido>();
        Double _valorTotalLista;
        const string _textoFinalizarPedido = "Executar baixa no estoque / Gerar o relatório";
        const string _textoListaAberta = "Lista de Pedidos em andamento - Valor total: ";
        const string _textoListaFinalizada = "Lista de Pedidos finalizada - Valor total: ";

        private void CarregarListGrupos()
        {
            List<Grupo> grupos = new List<Grupo>();
            GrupoDAO grupoDAO = new GrupoDAO();

            grupos = grupoDAO.GetAll();

            foreach (var item in grupos)
            {
                cboGrupo.Items.Add(new GrupoCheckedListBoxItem()
                {
                    Tag = item.Id,
                    Text = item.Descricao
                });
            }
        }

        private void ListaDePedidos_Load(object sender, EventArgs e)
        {
            CarregarListGrupos();
            FormatarGridPedido();
            AtualizaValorTotal();
            BloquearAlteracaoNaLista(false);
        }

        private void txtLocalizarItensPorNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39) //bloqueia apostrofo
                e.Handled = true;
        }

        private void CarregarDataGridComFiltros()
        {
            long grupo = 0;
            String nome_item = "";

            var item = cboGrupo.SelectedItem;

            GrupoCheckedListBoxItem g = (GrupoCheckedListBoxItem)item;

            if (!Nullable.Equals(null, g))
                grupo = g.Tag;
            else
            {
                MessageBox.Show("Escolha o grupo.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGrupo.Focus();
                return;
            }

            nome_item = txtLocalizarItensPorNome.Text;

            CarregarDataGridItensEncontrados(grupo, nome_item);
        }

        private void CarregarDataGridItensEncontrados(long grupo_selecionado, String nome_item)
        {
            List<Item> itens = new List<Item>();

            try
            {
                itens = _itemDAO.RetornaItensParaLista(grupo_selecionado, nome_item);

                grdItensEncontrados.Columns.Clear();
                grdItensEncontrados.DataSource = itens;
                grdItensEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdItensEncontrados.AllowUserToDeleteRows = false;
                grdItensEncontrados.RowHeadersVisible = false;

                grdItensEncontrados.Columns["id"].Visible = false;
                grdItensEncontrados.Columns["estoqueminimo"].Visible = false;
                grdItensEncontrados.Columns["precocusto"].Visible = false;
                grdItensEncontrados.Columns["GrupoId"].Visible = false;
                grdItensEncontrados.Columns["PorcentagemLucro"].Visible = false;
                grdItensEncontrados.Columns["Grupo"].Visible = false;

                grdItensEncontrados.Columns["descricao"].Width = 160;
                grdItensEncontrados.Columns["descricao"].HeaderText = "Nome do Item";
                grdItensEncontrados.Columns["descricao"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);

                grdItensEncontrados.Columns["tamanho"].Width = 39;
                grdItensEncontrados.Columns["tamanho"].HeaderText = "";
                grdItensEncontrados.Columns["tamanho"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);

                grdItensEncontrados.Columns["quantidade"].Width = 50;
                grdItensEncontrados.Columns["quantidade"].HeaderText = "Estoque";
                grdItensEncontrados.Columns["quantidade"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);

                grdItensEncontrados.Columns["precovenda"].Width = 70;
                grdItensEncontrados.Columns["precovenda"].HeaderText = "Venda";
                grdItensEncontrados.Columns["precovenda"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);

                this.grdItensEncontrados.Columns["quantidade"].DefaultCellStyle.Format = "#0";
                this.grdItensEncontrados.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItensEncontrados.Columns["tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdItensEncontrados.Columns["precovenda"].DefaultCellStyle.Format = "c";
                this.grdItensEncontrados.Columns["precovenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdItensEncontrados.AllowUserToResizeRows = false;

                foreach (DataGridViewColumn item in grdItensEncontrados.Columns)
                {
                    item.DefaultCellStyle.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.grdItensEncontrados.ClearSelection();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            CarregarDataGridComFiltros();
        }

        private void cboGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarDataGridComFiltros();
        }

        private void txtLocalizarItensPorNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) CarregarDataGridComFiltros();
        }

        private void AdicionaItemNoPedido(DataGridViewRow datagridrow)
        {
            if (_pedido.PedidoFinalizado)
                return;

            ItemDoPedido itemNoPedido = new ItemDoPedido();
            GrupoDAO grupoDAO = new GrupoDAO();

            itemNoPedido.IdItem = Convert.ToInt64(datagridrow.Cells["Id"].Value);
            itemNoPedido.Descricao = datagridrow.Cells["Descricao"].Value.ToString() + " (" + datagridrow.Cells["Tamanho"].Value.ToString() + ")";
            itemNoPedido.Tamanho = datagridrow.Cells["Tamanho"].Value.ToString();
            itemNoPedido.IdGrupo = Convert.ToInt64(datagridrow.Cells["GrupoId"].Value.ToString());
            itemNoPedido.DescricaoGrupo = grupoDAO.GetDataByID(Convert.ToInt64(datagridrow.Cells["GrupoId"].Value)).Descricao;
            itemNoPedido.QuantidadeEstoque = Convert.ToInt64(datagridrow.Cells["Quantidade"].Value.ToString()); ;
            itemNoPedido.QuantidadePedido = 0;
            itemNoPedido.PrecoVenda = Convert.ToDouble(datagridrow.Cells["PrecoVenda"].Value.ToString());
            itemNoPedido.ValorTotal = 0;

            foreach (var item in _itensNoPedido)
            {
                if (item.IdItem == itemNoPedido.IdItem)
                    return;
            }

            _itensNoPedido.Add(itemNoPedido);
            AtualizaValorTotal();
            VerificarNumeroDoPedido();
        }

        private void RemoverItemDaLista(DataGridViewRow datagridrow)
        {
            if (_pedido.PedidoFinalizado)
                return;

            if (MessageBox.Show("Deseja realmente remover o item da lista?", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                .Equals(System.Windows.Forms.DialogResult.No))
                return;

            long itemNoPedido = 0;
            int i = 0;

            itemNoPedido = Convert.ToInt64(datagridrow.Cells["IdItem"].Value);

            foreach (var item in _itensNoPedido)
            {
                if (item.IdItem == itemNoPedido)
                {
                    _itensNoPedido.RemoveAt(i);
                    VerificarNumeroDoPedido();
                    AtualizaValorTotal();
                    return;
                }
                i++;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (grdItensEncontrados.CurrentRow == null) return;
            AdicionaItemNoPedido((DataGridViewRow)grdItensEncontrados.Rows[grdItensEncontrados.CurrentRow.Index]);
        }

        private void grdItensEncontrados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            AdicionaItemNoPedido((DataGridViewRow)grdItensEncontrados.Rows[e.RowIndex]);
        }

        private void FormatarGridPedido()
        {
            grdListaDePedidos.DataSource = _itensNoPedido;
            grdListaDePedidos.RowHeadersWidth = 20;
            grdListaDePedidos.AllowUserToResizeRows = false;

            grdListaDePedidos.EditMode = DataGridViewEditMode.EditOnF2;

            grdListaDePedidos.Columns["IdItem"].Visible = false;
            grdListaDePedidos.Columns["IdPedido"].Visible = false;
            grdListaDePedidos.Columns["QuantidadeEstoque"].Visible = false;
            grdListaDePedidos.Columns["IdGrupo"].Visible = false;
            grdListaDePedidos.Columns["Tamanho"].Visible = false;

            grdListaDePedidos.Columns["Descricao"].Width = 200;
            grdListaDePedidos.Columns["Descricao"].HeaderText = "Nome do Item";
            grdListaDePedidos.Columns["Descricao"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            grdListaDePedidos.Columns["Descricao"].ReadOnly = true;

            grdListaDePedidos.Columns["DescricaoGrupo"].Width = 100;
            grdListaDePedidos.Columns["DescricaoGrupo"].HeaderText = "Grupo";
            grdListaDePedidos.Columns["DescricaoGrupo"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            grdListaDePedidos.Columns["DescricaoGrupo"].ReadOnly = true;

            grdListaDePedidos.Columns["QuantidadePedido"].Width = 60;
            grdListaDePedidos.Columns["QuantidadePedido"].HeaderText = "Qtd.";
            grdListaDePedidos.Columns["QuantidadePedido"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            grdListaDePedidos.Columns["QuantidadePedido"].DefaultCellStyle.Format = "#0";
            grdListaDePedidos.Columns["QuantidadePedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdListaDePedidos.Columns["QuantidadePedido"].ReadOnly = false;

            grdListaDePedidos.Columns["PrecoVenda"].Width = 85;
            grdListaDePedidos.Columns["PrecoVenda"].HeaderText = "Unitário";
            grdListaDePedidos.Columns["PrecoVenda"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            grdListaDePedidos.Columns["PrecoVenda"].DefaultCellStyle.Format = "c";
            grdListaDePedidos.Columns["PrecoVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdListaDePedidos.Columns["PrecoVenda"].ReadOnly = true;

            grdListaDePedidos.Columns["ValorTotal"].Width = 85
                ;
            grdListaDePedidos.Columns["ValorTotal"].HeaderText = "Valor Total";
            grdListaDePedidos.Columns["ValorTotal"].HeaderCell.Style.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            grdListaDePedidos.Columns["ValorTotal"].DefaultCellStyle.Format = "c";
            grdListaDePedidos.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdListaDePedidos.Columns["ValorTotal"].ReadOnly = true;

            foreach (DataGridViewColumn item in grdListaDePedidos.Columns)
            {
                item.DefaultCellStyle.Font = new Font(ListaDePedidos.ActiveForm.Font.Name, 8.25F);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (grdListaDePedidos.CurrentRow == null) return;
            RemoverItemDaLista((DataGridViewRow)grdListaDePedidos.Rows[grdListaDePedidos.CurrentRow.Index]);
        }

        private void grdListaDePedidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            long quantidade;
            Double valorTotal;

            if (long.TryParse(grdListaDePedidos.Rows[e.RowIndex].Cells["QuantidadePedido"].Value.ToString(), out quantidade))
                valorTotal = quantidade * Convert.ToDouble(grdListaDePedidos.Rows[e.RowIndex].Cells["PrecoVenda"].Value.ToString());
            else
                valorTotal = 0;

            grdListaDePedidos.Rows[e.RowIndex].Cells["ValorTotal"].Value = valorTotal;
            _valorTotalLista = _valorTotalLista + valorTotal;

            foreach (var item in _itensNoPedido)
            {
                if (item.IdItem == Convert.ToInt64(grdListaDePedidos.Rows[e.RowIndex].Cells["IdItem"].Value))
                    item.QuantidadePedido = quantidade;
            }

            AtualizaValorTotal();
        }

        private void grdListaDePedidos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Double quantidade;

            if (e.ColumnIndex == grdListaDePedidos.Columns["QuantidadePedido"].Index)
            {
                if (!Double.TryParse(e.FormattedValue.ToString(), out quantidade))
                {
                    MessageBox.Show("A quantidade é inválida!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                if (e.FormattedValue.ToString().Contains(",") || e.FormattedValue.ToString().Contains("."))
                {
                    MessageBox.Show("A quantidade é inválida!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                if (quantidade < 0)
                {
                    MessageBox.Show("A quantidade é inválida!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                if (rdoPedidoDeVenda.Checked)
                {
                    if (Convert.ToInt64(grdListaDePedidos.Rows[e.RowIndex].Cells["QuantidadeEstoque"].Value) - quantidade < 0)
                    {
                        MessageBox.Show("A quantidade é inválida! O estoque do item ficaria negativo.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }

                }
                else if (rdoPedidoDeCompra.Checked)
                {
                    if (Convert.ToInt64(grdListaDePedidos.Rows[e.RowIndex].Cells["QuantidadeEstoque"].Value) + quantidade > Item.ESTOQUE_MAXIMO)
                    {
                        MessageBox.Show("A quantidade é inválida! O estoque do item ficaria inválido para o sistema.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (rdoPedidoDeVenda.Checked) //subtrair
            {
                if (!_pedido.PedidoFinalizado)
                {
                    if (MessageBox.Show("O sistema executará automaticamente a baixa no estoque.\n\nDeseja realmente finalizar a lista de pedidos?\nClique em 'Sim' para continuar ou em 'Não' para cancelar.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                       .Equals(System.Windows.Forms.DialogResult.No))
                        return;

                    if (txtNumeroDoPedido.Text.Equals(String.Empty) || _itensNoPedido.Count == 0)
                    {
                        MessageBox.Show("Não foi possível continuar. A lista de pedidos está vazia!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (!ValidaListaDePedido())
                        return;

                    long idPedido = GravarPedido();

                    if (idPedido != 0)
                    {
                        try
                        {
                            _pedido.Id = idPedido;
                            _pedido.Numero = Int32.Parse(txtNumeroDoPedido.Text);
                            ExecutarAlteracaoNoEstoque(Enumeradores.TipoOperacao.Subtrair);
                            FinalizarPedido(idPedido);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("A baixa no estoque não foi realizada automaticamente.\n\nMensagem do sistema:" + ex.Message, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A lista de pedidos não foi salva. Tente novamente.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (MessageBox.Show("O pedido foi salvo com sucesso e a baixa do estoque já foi realizada.\n\nDeseja gerar o relatório dos pedidos agora?", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        .Equals(System.Windows.Forms.DialogResult.Yes))
                        GerarRelatorioDoPedido(idPedido);

                    LimparListaDePedido();

                }
                else
                {
                    if (MessageBox.Show("Deseja gerar o relatório dos pedidos?", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        .Equals(System.Windows.Forms.DialogResult.Yes))
                        GerarRelatorioDoPedido(_pedido.Id);
                }
            }
            else // somar
            {
                if (MessageBox.Show("O sistema executará automaticamente a reposição do estoque.\n\nClique em 'Sim' para continuar ou em 'Não' para cancelar.", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                       .Equals(System.Windows.Forms.DialogResult.No))
                    return;

                if (txtNumeroDoPedido.Text.Equals(String.Empty) || _itensNoPedido.Count == 0)
                {
                    MessageBox.Show("Não foi possível continuar. A lista de pedidos está vazia!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!ValidaListaDePedido())
                    return;

                try
                {
                    ExecutarAlteracaoNoEstoque(Enumeradores.TipoOperacao.Somar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A reposição do estoque não foi realizada automaticamente.\n\nMensagem do sistema:" + ex.Message, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("A reposição do estoque foi realizada com sucesso!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparListaDePedido();
            }
        }

        private long GravarPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            Pedido pedido = new Pedido();
            List<ItemDoPedido> itensDoPedido = new List<ItemDoPedido>();
            long idPedido = 0;

            try
            {
                pedido.Numero = Convert.ToInt64(txtNumeroDoPedido.Text);
                pedido.Observacao = txtObservacao.Text;
                pedido.PedidoFinalizado = false;
                pedido.Valor = _valorTotalLista;

                if (rdoPedidoDeCompra.Checked)
                    pedido.TipoOperacao = Enumeradores.TipoOperacao.Somar;
                else if (rdoPedidoDeVenda.Checked)
                    pedido.TipoOperacao = Enumeradores.TipoOperacao.Subtrair;

                foreach (var item in _itensNoPedido)
                {
                    itensDoPedido.Add(item);
                }

                pedido.ItensDoPedido = itensDoPedido;
                idPedido = pedidoDAO.Save(pedido);

            }
            catch (Exception ex)
            {
                MessageBox.Show("A lista de pedidos não foi salva. Tente novamente.\n\n Mensagem do sistema:" + ex.Message, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return idPedido;
        }

        private void FinalizarPedido(long idPedido)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            try
            {
                pedidoDAO.FinalizarPedido(idPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A lista de pedidos não foi salva. Tente novamente.\n\n Mensagem do sistema:" + ex.Message, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecutarAlteracaoNoEstoque(Enumeradores.TipoOperacao tpO)
        {
            ItemDAO itemDAO = new ItemDAO();
            Item item = new Item();
            long novaQuantidade = 0;

            foreach (var v in _itensNoPedido)
            {
                item = itemDAO.GetDataByID(v.IdItem);

                if (tpO.Equals(Enumeradores.TipoOperacao.Somar))
                    novaQuantidade = v.QuantidadeEstoque + v.QuantidadePedido;
                else if (tpO.Equals(Enumeradores.TipoOperacao.Subtrair))
                    novaQuantidade = v.QuantidadeEstoque - v.QuantidadePedido;
                else
                    novaQuantidade = v.QuantidadeEstoque;

                try
                {
                    itemDAO.AlterarQuantidadeEstoque(item.Id, novaQuantidade);

                    Log log = new Log()
                    {
                        IdItem = item.Id,
                        Descricao = item.Descricao + " (" + item.Tamanho + ")",
                        QuantidadeAnterior = v.QuantidadeEstoque,
                        QuantidadeAtual = novaQuantidade,
                        QuantidadeInformada = v.QuantidadePedido,
                        Origem = this.Text,
                        TpOperacao = tpO,
                        IdPedido = _pedido.Id,
                        PedidoNumero = _pedido.Numero
                    };

                    log.GravarRastreabilidade();
                }
                catch (Exception) { throw; }
            }
        }

        private bool ValidaListaDePedido()
        {
            String itensQuantidadeZerada = "";

            if (_itensNoPedido.Count == 0)
            {
                MessageBox.Show("A lista de pedidos não pode estar vazia!", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            foreach (var item in _itensNoPedido)
            {
                if (item.QuantidadePedido == 0)
                    itensQuantidadeZerada = itensQuantidadeZerada + item.Descricao + "\n";
            }

            if (!itensQuantidadeZerada.Equals(String.Empty))
            {
                MessageBox.Show("Existem itens com quantidade igual a zero!\n\nItens:\n" + itensQuantidadeZerada, ListaDePedidos.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void txtNumeroDoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LimparListaDePedido()
        {
            _itensNoPedido.Clear();
            _pedido = new Pedido();
            grdItensEncontrados.Columns.Clear();
            cboGrupo.SelectedIndex = -1;
            txtLocalizarItensPorNome.Text = "";
            txtObservacao.Text = "";
            txtNumeroDoPedido.Text = "";
            btnFinalizarPedido.Text = _textoFinalizarPedido;
            rdoPedidoDeVenda.Checked = true;
            AtualizaValorTotal();
            BloquearAlteracaoNaLista(false);
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            LimparListaDePedido();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            cboGrupo.SelectedIndex = -1;
            txtLocalizarItensPorNome.Text = "";
            grdItensEncontrados.Columns.Clear();
        }

        private void grdListaDePedidos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RemoverItemDaLista((DataGridViewRow)grdListaDePedidos.Rows[e.RowIndex]);
        }

        private void VerificarNumeroDoPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();

            if (_itensNoPedido.Count > 0 && txtNumeroDoPedido.Text == String.Empty)
                txtNumeroDoPedido.Text = pedidoDAO.PegarProximoNumero().ToString();
            else if (_itensNoPedido.Count == 0)
                txtNumeroDoPedido.Text = "";
        }

        private void AtualizaValorTotal()
        {
            _valorTotalLista = 0;
            foreach (var item in _itensNoPedido)
            {
                _valorTotalLista = _valorTotalLista + item.ValorTotal;
            }

            if (_pedido.PedidoFinalizado)
                lblBarra.Text = _textoListaFinalizada + _valorTotalLista.ToString("c");
            else
                lblBarra.Text = _textoListaAberta + _valorTotalLista.ToString("c");
        }

        private void btnPesquisarLista_Click(object sender, EventArgs e)
        {
            long idPedido;

            ConsultarPedidos window = new ConsultarPedidos();
            window.ShowDialog();

            LimparListaDePedido();

            idPedido = window.PedidoID;
            window.Dispose();

            CarregarListaDePedidoFinalizada(idPedido);
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39) //bloqueia apostrofo
                e.Handled = true;
        }

        private void CarregarListaDePedidoFinalizada(long idPedido)
        {
            if (idPedido == 0)
                return;

            PedidoDAO pedidoDAO = new PedidoDAO();
            ItemDAO itemDAO = new ItemDAO();
            List<ItemDoPedido> itens = new List<ItemDoPedido>();

            _pedido = pedidoDAO.GetDataById(idPedido);

            itens = pedidoDAO.GetAllItensDoPedido(idPedido);

            foreach (var i in itens) // isto foi feito só para atualziar algumas informações que devem ser atualizadas
            {
                Item item = new Item();
                item = itemDAO.GetDataByID(i.IdItem);

                i.PrecoVenda = item.PrecoVenda;
                i.QuantidadeEstoque = item.Quantidade;
                i.Tamanho = item.Tamanho;

                _itensNoPedido.Add(i);
            }

            grdListaDePedidos.Refresh();

            txtNumeroDoPedido.Text = _pedido.Numero.ToString();
            txtObservacao.Text = _pedido.Observacao;

            BloquearAlteracaoNaLista(true);
            AtualizaValorTotal();
        }

        private void BloquearAlteracaoNaLista(bool pedidoFinalizado)
        {
            if (pedidoFinalizado)
            {
                _pedido.PedidoFinalizado = true;
                btnFinalizarPedido.Text = "Gerar o relatório";
                lblBarra.Text = "Lista de pedidos aberta";
                grdListaDePedidos.Enabled = false;
                txtObservacao.Enabled = false;
                rdoPedidoDeCompra.Enabled = false;
                grdListaDePedidos.ClearSelection();
            }
            else
            {
                _pedido.PedidoFinalizado = false;
                btnFinalizarPedido.Text = _textoFinalizarPedido;
                lblBarra.Text = _textoListaAberta;
                grdListaDePedidos.Enabled = true;
                rdoPedidoDeCompra.Enabled = true;
                txtObservacao.Enabled = true;
            }

            AtualizaValorTotal();
        }

        private void rdoPedidoDeCompra_CheckedChanged(object sender, EventArgs e)
        {
            lblNumeroPedido.Visible = !rdoPedidoDeCompra.Checked;
            txtNumeroDoPedido.Visible = !rdoPedidoDeCompra.Checked;
            lblObservacao.Visible = !rdoPedidoDeCompra.Checked;
            txtObservacao.Visible = !rdoPedidoDeCompra.Checked;
            btnPesquisarLista.Visible = !rdoPedidoDeCompra.Checked;
            btnClonarLista.Visible = !rdoPedidoDeCompra.Checked;
            lblLine2.Visible = !rdoPedidoDeCompra.Checked;

            txtNumeroDoPedido.Text = "0";
            _pedido.Numero = 0;
            _pedido.Id = 0;

            if (rdoPedidoDeCompra.Checked)
                btnFinalizarPedido.Text = "Executar reposição";
            else
                btnFinalizarPedido.Text = _textoFinalizarPedido;

            //LimparListaDePedido();        
        }

        private void GerarRelatorioDoPedido(long pedido)
        {
            ListaDePedidosFormReport relatorio = new ListaDePedidosFormReport(pedido);
            relatorio.ShowDialog();
        }

        private void btnClonarLista_Click(object sender, EventArgs e)
        {
            if (!_pedido.PedidoFinalizado)
                return;

            if (MessageBox.Show("Ao clicar em 'Sim' o sistema gerará um novo número para a lista de pedidos e os itens da lista poderão ser alterados.\n\nDeseja continuar?", ListaDePedidos.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    .Equals(System.Windows.Forms.DialogResult.No))
                return;

            PedidoDAO pedidoDAO = new PedidoDAO();

            _pedido.Numero = pedidoDAO.PegarProximoNumero();
            txtNumeroDoPedido.Text = _pedido.Numero.ToString();

            BloquearAlteracaoNaLista(false);
        }

        private void rdoPedidoDeVenda_CheckedChanged(object sender, EventArgs e)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();

            _pedido.Numero = pedidoDAO.PegarProximoNumero();
            txtNumeroDoPedido.Text = _pedido.Numero.ToString();
        }

        private void txtNumeroDoPedido_TextChanged(object sender, EventArgs e)
        {

        }


    } //fechamento da classe
} //fechamento do namespace
