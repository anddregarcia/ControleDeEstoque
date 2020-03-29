namespace AtHome.ControleDeEstoque.UI
{
    partial class ListaDePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDePedidos));
            this.lblListaDeGrupos = new System.Windows.Forms.Label();
            this.lblLocalizarPorNome = new System.Windows.Forms.Label();
            this.txtLocalizarItensPorNome = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblItensEncontrados = new System.Windows.Forms.Label();
            this.grdListaDePedidos = new System.Windows.Forms.DataGridView();
            this.grdItensEncontrados = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroDoPedido = new System.Windows.Forms.TextBox();
            this.btnPesquisarLista = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.rdoPedidoDeCompra = new System.Windows.Forms.RadioButton();
            this.rdoPedidoDeVenda = new System.Windows.Forms.RadioButton();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnClonarLista = new System.Windows.Forms.Button();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLine2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItensEncontrados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaDeGrupos
            // 
            this.lblListaDeGrupos.AutoSize = true;
            this.lblListaDeGrupos.ForeColor = System.Drawing.Color.Black;
            this.lblListaDeGrupos.Location = new System.Drawing.Point(91, 26);
            this.lblListaDeGrupos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaDeGrupos.Name = "lblListaDeGrupos";
            this.lblListaDeGrupos.Size = new System.Drawing.Size(164, 17);
            this.lblListaDeGrupos.TabIndex = 24;
            this.lblListaDeGrupos.Text = "Localizar itens do grupo:";
            // 
            // lblLocalizarPorNome
            // 
            this.lblLocalizarPorNome.AutoSize = true;
            this.lblLocalizarPorNome.ForeColor = System.Drawing.Color.Black;
            this.lblLocalizarPorNome.Location = new System.Drawing.Point(91, 74);
            this.lblLocalizarPorNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalizarPorNome.Name = "lblLocalizarPorNome";
            this.lblLocalizarPorNome.Size = new System.Drawing.Size(184, 17);
            this.lblLocalizarPorNome.TabIndex = 23;
            this.lblLocalizarPorNome.Text = "Localizar itens com o nome:";
            // 
            // txtLocalizarItensPorNome
            // 
            this.txtLocalizarItensPorNome.Location = new System.Drawing.Point(94, 93);
            this.txtLocalizarItensPorNome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLocalizarItensPorNome.MaxLength = 200;
            this.txtLocalizarItensPorNome.Name = "txtLocalizarItensPorNome";
            this.txtLocalizarItensPorNome.Size = new System.Drawing.Size(258, 23);
            this.txtLocalizarItensPorNome.TabIndex = 1;
            this.txtLocalizarItensPorNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalizarItensPorNome_KeyDown);
            this.txtLocalizarItensPorNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalizarItensPorNome_KeyPress);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(94, 122);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(258, 37);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.tooltip.SetToolTip(this.btnLocalizar, "Executar a busca de um item para inserir na lista");
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblItensEncontrados
            // 
            this.lblItensEncontrados.AutoSize = true;
            this.lblItensEncontrados.ForeColor = System.Drawing.Color.Black;
            this.lblItensEncontrados.Location = new System.Drawing.Point(14, 177);
            this.lblItensEncontrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItensEncontrados.Name = "lblItensEncontrados";
            this.lblItensEncontrados.Size = new System.Drawing.Size(125, 17);
            this.lblItensEncontrados.TabIndex = 27;
            this.lblItensEncontrados.Text = "Itens encontrados:";
            // 
            // grdListaDePedidos
            // 
            this.grdListaDePedidos.AllowUserToAddRows = false;
            this.grdListaDePedidos.AllowUserToDeleteRows = false;
            this.grdListaDePedidos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdListaDePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDePedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdListaDePedidos.Location = new System.Drawing.Point(473, 93);
            this.grdListaDePedidos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grdListaDePedidos.Name = "grdListaDePedidos";
            this.grdListaDePedidos.Size = new System.Drawing.Size(620, 414);
            this.grdListaDePedidos.TabIndex = 14;
            this.grdListaDePedidos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaDePedidos_CellEndEdit);
            this.grdListaDePedidos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdListaDePedidos_CellValidating);
            this.grdListaDePedidos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdListaDePedidos_RowHeaderMouseDoubleClick);
            // 
            // grdItensEncontrados
            // 
            this.grdItensEncontrados.AllowUserToAddRows = false;
            this.grdItensEncontrados.AllowUserToDeleteRows = false;
            this.grdItensEncontrados.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdItensEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItensEncontrados.Location = new System.Drawing.Point(17, 196);
            this.grdItensEncontrados.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grdItensEncontrados.Name = "grdItensEncontrados";
            this.grdItensEncontrados.ReadOnly = true;
            this.grdItensEncontrados.Size = new System.Drawing.Size(397, 357);
            this.grdItensEncontrados.TabIndex = 4;
            this.grdItensEncontrados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdItensEncontrados_CellMouseDoubleClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(422, 196);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(42, 177);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.TabStop = false;
            this.tooltip.SetToolTip(this.btnIncluir, "Incluir item na lista de pedido");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(474, 511);
            this.btnFinalizarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(619, 40);
            this.btnFinalizarPedido.TabIndex = 15;
            this.btnFinalizarPedido.Text = "Executar baixa no estoque / Gerar o relatório";
            this.tooltip.SetToolTip(this.btnFinalizarPedido, "Finalizar o pedido. Esta ação irá realizar a baixa do estoque e gerar o relatório" +
        " para impressão.");
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.Window;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(442, 12);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(2, 174);
            this.lblLine.TabIndex = 33;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(422, 381);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(42, 172);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.TabStop = false;
            this.tooltip.SetToolTip(this.btnRemover, "Remover o item da lista de pedido");
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarra.Location = new System.Drawing.Point(473, 71);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(620, 20);
            this.lblBarra.TabIndex = 35;
            this.lblBarra.Text = "Lista de Pedido - Valor total:";
            this.lblBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroPedido.Location = new System.Drawing.Point(695, 14);
            this.lblNumeroPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(111, 17);
            this.lblNumeroPedido.TabIndex = 37;
            this.lblNumeroPedido.Text = "Número da lista:";
            // 
            // txtNumeroDoPedido
            // 
            this.txtNumeroDoPedido.Enabled = false;
            this.txtNumeroDoPedido.Location = new System.Drawing.Point(814, 10);
            this.txtNumeroDoPedido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumeroDoPedido.MaxLength = 10;
            this.txtNumeroDoPedido.Name = "txtNumeroDoPedido";
            this.txtNumeroDoPedido.Size = new System.Drawing.Size(120, 23);
            this.txtNumeroDoPedido.TabIndex = 9;
            this.txtNumeroDoPedido.TabStop = false;
            this.txtNumeroDoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tooltip.SetToolTip(this.txtNumeroDoPedido, "Informe o número do pedido.");
            this.txtNumeroDoPedido.TextChanged += new System.EventHandler(this.txtNumeroDoPedido_TextChanged);
            this.txtNumeroDoPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoPedido_KeyPress);
            // 
            // btnPesquisarLista
            // 
            this.btnPesquisarLista.BackColor = System.Drawing.SystemColors.Window;
            this.btnPesquisarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarLista.Image")));
            this.btnPesquisarLista.Location = new System.Drawing.Point(942, 10);
            this.btnPesquisarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarLista.Name = "btnPesquisarLista";
            this.btnPesquisarLista.Size = new System.Drawing.Size(33, 23);
            this.btnPesquisarLista.TabIndex = 11;
            this.btnPesquisarLista.TabStop = false;
            this.tooltip.SetToolTip(this.btnPesquisarLista, "Localizar pedidos finalizados.");
            this.btnPesquisarLista.UseVisualStyleBackColor = false;
            this.btnPesquisarLista.Click += new System.EventHandler(this.btnPesquisarLista_Click);
            // 
            // rdoPedidoDeCompra
            // 
            this.rdoPedidoDeCompra.AutoSize = true;
            this.rdoPedidoDeCompra.Location = new System.Drawing.Point(91, 22);
            this.rdoPedidoDeCompra.Name = "rdoPedidoDeCompra";
            this.rdoPedidoDeCompra.Size = new System.Drawing.Size(93, 21);
            this.rdoPedidoDeCompra.TabIndex = 8;
            this.rdoPedidoDeCompra.Tag = "0";
            this.rdoPedidoDeCompra.Text = "Reposição";
            this.tooltip.SetToolTip(this.rdoPedidoDeCompra, "Esta opção irá SOMAR ao estoque as quantidades informadas no pedido. Esta opção n" +
        "ão grava a lista de pedido.");
            this.rdoPedidoDeCompra.UseVisualStyleBackColor = true;
            this.rdoPedidoDeCompra.CheckedChanged += new System.EventHandler(this.rdoPedidoDeCompra_CheckedChanged);
            // 
            // rdoPedidoDeVenda
            // 
            this.rdoPedidoDeVenda.AutoSize = true;
            this.rdoPedidoDeVenda.Checked = true;
            this.rdoPedidoDeVenda.Location = new System.Drawing.Point(24, 22);
            this.rdoPedidoDeVenda.Name = "rdoPedidoDeVenda";
            this.rdoPedidoDeVenda.Size = new System.Drawing.Size(67, 21);
            this.rdoPedidoDeVenda.TabIndex = 7;
            this.rdoPedidoDeVenda.TabStop = true;
            this.rdoPedidoDeVenda.Tag = "1";
            this.rdoPedidoDeVenda.Text = "Venda";
            this.tooltip.SetToolTip(this.rdoPedidoDeVenda, "Esta opção irá SUBTRAIR do estoque as quantidades informadas no pedido. Esta opçã" +
        "o grava a lista de pedido.");
            this.rdoPedidoDeVenda.UseVisualStyleBackColor = true;
            this.rdoPedidoDeVenda.CheckedChanged += new System.EventHandler(this.rdoPedidoDeVenda_CheckedChanged);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.ForeColor = System.Drawing.Color.Black;
            this.lblObservacao.Location = new System.Drawing.Point(712, 40);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(94, 17);
            this.lblObservacao.TabIndex = 41;
            this.lblObservacao.Text = "Observação*:";
            this.tooltip.SetToolTip(this.lblObservacao, "Digite uma observação. Esta informação não é obrigatória.");
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLista.Location = new System.Drawing.Point(474, 94);
            this.btnLimparLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(19, 21);
            this.btnLimparLista.TabIndex = 13;
            this.btnLimparLista.TabStop = false;
            this.tooltip.SetToolTip(this.btnLimparLista, "Limpar a lista de pedido.");
            this.btnLimparLista.UseVisualStyleBackColor = false;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltro.Location = new System.Drawing.Point(333, 130);
            this.btnLimparFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(19, 21);
            this.btnLimparFiltro.TabIndex = 3;
            this.btnLimparFiltro.TabStop = false;
            this.tooltip.SetToolTip(this.btnLimparFiltro, "Limpar os campos de pesquisa.");
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnClonarLista
            // 
            this.btnClonarLista.BackColor = System.Drawing.SystemColors.Window;
            this.btnClonarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClonarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClonarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnClonarLista.Image")));
            this.btnClonarLista.Location = new System.Drawing.Point(976, 10);
            this.btnClonarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnClonarLista.Name = "btnClonarLista";
            this.btnClonarLista.Size = new System.Drawing.Size(33, 23);
            this.btnClonarLista.TabIndex = 12;
            this.btnClonarLista.TabStop = false;
            this.tooltip.SetToolTip(this.btnClonarLista, "Clonar pedido.");
            this.btnClonarLista.UseVisualStyleBackColor = false;
            this.btnClonarLista.Click += new System.EventHandler(this.btnClonarLista_Click);
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(94, 46);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(258, 24);
            this.cboGrupo.TabIndex = 0;
            this.cboGrupo.SelectionChangeCommitted += new System.EventHandler(this.cboGrupo_SelectionChangeCommitted);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(814, 37);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(279, 23);
            this.txtObservacao.TabIndex = 10;
            this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPedidoDeCompra);
            this.groupBox1.Controls.Add(this.rdoPedidoDeVenda);
            this.groupBox1.Location = new System.Drawing.Point(473, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 54);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da Lista";
            // 
            // lblLine2
            // 
            this.lblLine2.BackColor = System.Drawing.SystemColors.Window;
            this.lblLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine2.Location = new System.Drawing.Point(670, 14);
            this.lblLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(2, 45);
            this.lblLine2.TabIndex = 43;
            // 
            // ListaDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 564);
            this.Controls.Add(this.btnClonarLista);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.btnPesquisarLista);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.txtNumeroDoPedido);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.grdItensEncontrados);
            this.Controls.Add(this.grdListaDePedidos);
            this.Controls.Add(this.lblItensEncontrados);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.lblListaDeGrupos);
            this.Controls.Add(this.lblLocalizarPorNome);
            this.Controls.Add(this.txtLocalizarItensPorNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaDePedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pedidos";
            this.Load += new System.EventHandler(this.ListaDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItensEncontrados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaDeGrupos;
        private System.Windows.Forms.Label lblLocalizarPorNome;
        private System.Windows.Forms.TextBox txtLocalizarItensPorNome;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblItensEncontrados;
        private System.Windows.Forms.DataGridView grdListaDePedidos;
        private System.Windows.Forms.DataGridView grdItensEncontrados;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroDoPedido;
        private System.Windows.Forms.Button btnPesquisarLista;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.RadioButton rdoPedidoDeCompra;
        private System.Windows.Forms.RadioButton rdoPedidoDeVenda;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.Button btnClonarLista;
    }
}