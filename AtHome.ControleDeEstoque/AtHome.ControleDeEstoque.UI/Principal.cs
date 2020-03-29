using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{    
    public partial class Principal : Form
    {
        ReportDAO _reportDAO = new ReportDAO();
        
        private enum ColunasDoGrid
        {
            NomeDoItem = 0,
            Tamanho = 1,
            NomeDoGrupo = 2,
            Quantidade = 3,
            EstoqueMinimo = 4,
            Somar = 5,
            Subtrair = 6,
            Substituir = 7,
            PrecoCusto = 8,
            PrecoVenda = 9
        }
        
        public Principal()
        {
            InitializeComponent();    
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PosicionarComponentes();
            CarregarDataGrid("", "", Enumeradores.TipoComparador.Nenhum, 0, false);
            CarregarListGrupos();
            CarregarMenuItensPorGrupo();
            CarregarNomeDaEmpresa();
        }

        private void CarregarNomeDaEmpresa()
        {
            ConfiguracaoDAO configDAO = new ConfiguracaoDAO();
            Configuracao config = configDAO.GetData();

            config = configDAO.GetData();

            lblBarra.Text = config.NomeDaEmpresa.Replace("&", "&&");

        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            PosicionarComponentes();
        }

        private void PosicionarComponentes()
        {
            lblBarra.Left = 0;
            lblBarra.Width = this.Size.Width;
            grdGerenciamento.Width = this.Size.Width - 17;
            grdGerenciamento.Height = this.Height - grdGerenciamento.Top - 41;
            btnLocalizar.Left = this.Width - btnLocalizar.Height - 150;
            btnAbrirPedido.Left = btnLocalizar.Left;
            btnLimpar.Left = btnLocalizar.Left;
            btnExportarLista.Left = btnLocalizar.Left;
        }

        private void CarregarDataGrid(String grupos_selecionados, String nome_item, Enumeradores.TipoComparador tpOP, long quantidade, bool abaixo_do_minimo)
        {
            try
            {
                DataGridViewImageColumn grdImg = new DataGridViewImageColumn();

                //this.grdGerenciamento.RowEnter -= new DataGridViewCellEventHandler(grdGerenciamento_RowEnter);
                grdGerenciamento.Columns.Clear();
                grdGerenciamento.DataSource = _reportDAO.ItensParaGerenciamento(grupos_selecionados, nome_item, tpOP, quantidade, abaixo_do_minimo);
                grdGerenciamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdGerenciamento.AllowUserToDeleteRows = false;

                grdGerenciamento.Columns["id"].Visible = false;
                grdGerenciamento.Columns["estoquebaixo"].Visible = false;

                grdGerenciamento.Columns["descricao"].Width = 300;
                grdGerenciamento.Columns["descricao"].HeaderText = "Nome do Item";

                grdGerenciamento.Columns["tamanho"].Width = 80;
                grdGerenciamento.Columns["tamanho"].HeaderText = "Tamanho";

                grdGerenciamento.Columns["grupo_descricao"].Width = 135;
                grdGerenciamento.Columns["grupo_descricao"].HeaderText = "Grupo";

                grdGerenciamento.Columns["quantidade"].Width = 100;
                grdGerenciamento.Columns["quantidade"].HeaderText = "Estoque Atual";

                grdGerenciamento.Columns["estoqueminimo"].Width = 100;
                grdGerenciamento.Columns["estoqueminimo"].HeaderText = "Estoque Mínimo";

                grdImg = new DataGridViewImageColumn();                
                grdImg.Image = img.Images[0];
                grdGerenciamento.Columns.Insert((int)ColunasDoGrid.Somar, grdImg);
                grdImg.HeaderText = "Somar";
                grdImg.Name = "somar";
                grdGerenciamento.Columns["somar"].Width = 70;

                grdImg = new DataGridViewImageColumn();
                grdImg.Image = img.Images[1];
                grdGerenciamento.Columns.Insert((int)ColunasDoGrid.Subtrair, grdImg);
                grdImg.HeaderText = "Subtrair";
                grdImg.Name = "subtrair";
                grdGerenciamento.Columns["subtrair"].Width = 70;

                grdImg = new DataGridViewImageColumn();
                grdImg.Image = img.Images[2];
                grdGerenciamento.Columns.Insert((int)ColunasDoGrid.Substituir, grdImg);
                grdImg.HeaderText = "Substituir";
                grdImg.Name = "substituir";
                grdGerenciamento.Columns["substituir"].Width = 70;
                
                grdGerenciamento.Columns["precocusto"].Width = 150;
                grdGerenciamento.Columns["precocusto"].HeaderText = "Preço de Custo";

                grdGerenciamento.Columns["precovenda"].Width = 150;
                grdGerenciamento.Columns["precovenda"].HeaderText = "Preço de Venda";

                // this.grdGerenciamento.RowEnter += new
                //     DataGridViewCellEventHandler(grdGerenciamento_RowEnter);

                this.grdGerenciamento.Columns["quantidade"].DefaultCellStyle.Format = "#0";
                this.grdGerenciamento.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdGerenciamento.Columns["estoqueminimo"].DefaultCellStyle.Format = "#0";
                this.grdGerenciamento.Columns["estoqueminimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdGerenciamento.Columns["tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.grdGerenciamento.Columns["precocusto"].DefaultCellStyle.Format = "c";
                this.grdGerenciamento.Columns["precocusto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.grdGerenciamento.Columns["precovenda"].DefaultCellStyle.Format = "c";
                this.grdGerenciamento.Columns["precovenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Principal.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBarra.Text = "";
            }

            this.grdGerenciamento.ClearSelection();
        }

        private void CarregarMenuItensPorGrupo()
        {
            GrupoDAO grupoDAO = new GrupoDAO();
            List<Grupo> grupos = new List<Grupo>();

            grupos = grupoDAO.GetAll();
            mnuItens.DropDownItems.Clear();

            foreach (Grupo g in grupos) 
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();

                tsmi.Text = g.Descricao.Trim();//nome_menu;
                tsmi.Name = "mnu" + g.Id.ToString();
                tsmi.Tag = g.Id.ToString();
                mnuItens.DropDownItems.Add(tsmi);
                
                tsmi.Click += new EventHandler(mnuCadastroItens_Click);
            }
        }

        private void mnuCadastroItens_Click(object sender, EventArgs e)
        {
            String s;
            long g;
            s = sender.ToString();

            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi = (ToolStripMenuItem)sender; 

            g = Convert.ToInt64(tsmi.Tag);
            CadastroDeItem window = new CadastroDeItem(g);
            window.ShowDialog(this);

            CarregarDataGridComFiltros();
        }

        private void mnuGrupos_Click(object sender, EventArgs e)
        {
            CadastroDeGrupo window = new CadastroDeGrupo();
            window.ShowDialog(this);
            CarregarMenuItensPorGrupo();
            CarregarListGrupos();
        }

        private void grdGerenciamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long idItem, quantidade, novaQuantidade = 0;

            if (e.RowIndex < 0) return;
            if ((int)ColunasDoGrid.Somar != e.ColumnIndex &&
                (int)ColunasDoGrid.Subtrair != e.ColumnIndex &&
                (int)ColunasDoGrid.Substituir != e.ColumnIndex) return;

            idItem = Convert.ToInt64(grdGerenciamento.Rows[e.RowIndex].Cells["Id"].Value);
            quantidade = Convert.ToInt64(grdGerenciamento.Rows[e.RowIndex].Cells["Quantidade"].Value);
            novaQuantidade = quantidade;

            if ((int)ColunasDoGrid.Somar == e.ColumnIndex)
            {
                using (AlterarEstoque window = new AlterarEstoque(Enumeradores.TipoOperacao.Somar, idItem, quantidade))
                {
                    window.ShowDialog(this);
                    novaQuantidade = window.NovaQuantidade;
                    window.Dispose();
                }
            }

            if ((int)ColunasDoGrid.Subtrair == e.ColumnIndex)
            {
                using (AlterarEstoque window = new AlterarEstoque(Enumeradores.TipoOperacao.Subtrair, idItem, quantidade))
                {
                    window.ShowDialog(this);
                    novaQuantidade = window.NovaQuantidade;
                    window.Dispose();
                }
            }

            if ((int)ColunasDoGrid.Substituir == e.ColumnIndex)
            {
                using (AlterarEstoque window = new AlterarEstoque(Enumeradores.TipoOperacao.Substituir, idItem, quantidade))
                {
                    window.ShowDialog(this);
                    novaQuantidade = window.NovaQuantidade;
                    window.Dispose();
                }
            }

            grdGerenciamento.Rows[e.RowIndex].Cells["Quantidade"].Value = novaQuantidade.ToString();

            if (Convert.ToInt64(grdGerenciamento.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString()) <= 
                Convert.ToInt64(grdGerenciamento.Rows[e.RowIndex].Cells["EstoqueMinimo"].Value.ToString()))
            {
                grdGerenciamento.Rows[e.RowIndex].Cells["EstoqueBaixo"].Value = 1;
                grdGerenciamento.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            }
            else
            {
                grdGerenciamento.Rows[e.RowIndex].Cells["EstoqueBaixo"].Value = 0;
                grdGerenciamento.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            CarregarDataGridComFiltros();
        }

        private void CarregarListGrupos()
        {
            List<Grupo> grupos = new List<Grupo>();
            GrupoDAO grupoDAO = new GrupoDAO();

            grupos = grupoDAO.GetAll();
            lstGrupos.Items.Clear();

            foreach (var item in grupos)
            {
                lstGrupos.Items.Add(new GrupoCheckedListBoxItem()
                    {
                        Tag = item.Id,
                        Text = item.Descricao
                    });
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void txtQuantidadeEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLocalizarItensPorNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39) //bloqueia apostrofo
            {
                e.Handled = true;
            }
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            txtLocalizarItensPorNome.Focus();
        }

        private void LimparGruposMarcados()
        {
            for (int i = 0; i < lstGrupos.Items.Count; i++)
            {
                lstGrupos.SetItemCheckState(i, CheckState.Unchecked);
            }
            chkSelecionarTodos.Checked = false;
        }

        private void MarcarTodosOsGrupos()
        {
            for (int i = 0; i < lstGrupos.Items.Count; i++)
            {
                lstGrupos.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void chkSelecionarTodos_Click(object sender, EventArgs e)
        {
            if (chkSelecionarTodos.Checked)
                MarcarTodosOsGrupos();
            else
                LimparGruposMarcados();
        }

        private void lstGrupos_Click(object sender, EventArgs e)
        {
            chkSelecionarTodos.Checked = (lstGrupos.Items.Count == lstGrupos.CheckedItems.Count);
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdGerenciamento.Rows[e.RowIndex].Cells["estoquebaixo"].Value.ToString() == "1")
            {
                grdGerenciamento.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void btnExportarLista_Click(object sender, EventArgs e)
        {
            String itens;
            
            itens = GerarTextoParaExportacao();

            ExportarLista window = new ExportarLista(itens);
            window.ShowDialog();
        }

        private String GerarTextoParaExportacao()
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < grdGerenciamento.RowCount; i++)
            {
                s.Append(String.Format("*Item:* {0} ", grdGerenciamento.Rows[i].Cells["descricao"].Value.ToString()));
                s.Append(String.Format("*Tamanho:* {0} ", grdGerenciamento.Rows[i].Cells["tamanho"].Value.ToString()));
                s.Append(String.Format("*Grupo:* {0} ", grdGerenciamento.Rows[i].Cells["grupo_descricao"].Value.ToString()));
                s.Append(String.Format("*Estoque:* {0} ", grdGerenciamento.Rows[i].Cells["quantidade"].Value.ToString()));
                s.Append(String.Format("*Preço de Custo:* {0:c} ", grdGerenciamento.Rows[i].Cells["precocusto"].Value));
                s.Append("\n\n");
            }
            return s.ToString();
        }

        private void LimparFiltros()
        {
            LimparGruposMarcados();
            txtLocalizarItensPorNome.Text = String.Empty;
            txtQuantidadeEstoque.Text = String.Empty;
            rdoMaiorIgual.Checked = false;
            rdoMenorIgual.Checked = false;
            chkExibirItensAbaixoMinimo.Checked = false;
            txtLocalizarItensPorNome.Focus();
            grdGerenciamento.ClearSelection();
        }

        private void CarregarDataGridComFiltros()
        {
            String grupos = "", nome_item = "";
            long quantidade = 0;
            bool abaixo_do_minimo;
            Enumeradores.TipoComparador tipoOP = Enumeradores.TipoComparador.Nenhum;

            lblBarra.Text = "Aguarde... carregando as informações de estoque.";
            
            foreach (var item in lstGrupos.CheckedItems)
            {
                GrupoCheckedListBoxItem g = new GrupoCheckedListBoxItem();
                g = (GrupoCheckedListBoxItem)item;
                grupos = grupos + g.Tag.ToString() + ",";
            }

            if (grupos.Length > 0)
                grupos = grupos.Substring(0, grupos.Length - 1);

            nome_item = txtLocalizarItensPorNome.Text;
            if (!txtQuantidadeEstoque.Text.Equals(String.Empty))
                quantidade = Convert.ToInt64(txtQuantidadeEstoque.Text);
            abaixo_do_minimo = chkExibirItensAbaixoMinimo.Checked;
            if (rdoMaiorIgual.Checked)
                tipoOP = Enumeradores.TipoComparador.Maior_que;
            else if (rdoMenorIgual.Checked)
                tipoOP = Enumeradores.TipoComparador.Menor_que;
            else
                tipoOP = Enumeradores.TipoComparador.Nenhum;

            CarregarDataGrid(grupos, nome_item, tipoOP, quantidade, abaixo_do_minimo);

            CarregarNomeDaEmpresa();
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            ListaDePedidos window = new ListaDePedidos();
            window.ShowDialog();
            CarregarDataGridComFiltros();
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroConfiguracao window = new CadastroConfiguracao();
            window.ShowDialog();

            CarregarNomeDaEmpresa();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void grdGerenciamento_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idItem = Int64.Parse(grdGerenciamento.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var grupo = grdGerenciamento.Rows[e.RowIndex].Cells["grupo_descricao"].Value.ToString();
            ConsultarLog window = new ConsultarLog(idItem, grupo);
            window.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            
            try
            {                
                System.Diagnostics.Process.Start(path + "//Manual.pdf");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
