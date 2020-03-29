namespace AtHome.ControleDeEstoque.UI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItens = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUteis = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.btnAbrirPedido = new System.Windows.Forms.Button();
            this.lblLocalizarPorNome = new System.Windows.Forms.Label();
            this.txtLocalizarItensPorNome = new System.Windows.Forms.TextBox();
            this.grpQtdEstoque = new System.Windows.Forms.GroupBox();
            this.rdoMenorIgual = new System.Windows.Forms.RadioButton();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.rdoMaiorIgual = new System.Windows.Forms.RadioButton();
            this.chkExibirItensAbaixoMinimo = new System.Windows.Forms.CheckBox();
            this.lstGrupos = new System.Windows.Forms.CheckedListBox();
            this.btnExportarLista = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.lblListaDeGrupos = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.grpQtdEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastros,
            this.mnuUteis});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuPrincipal.Size = new System.Drawing.Size(1133, 24);
            this.mnuPrincipal.TabIndex = 3;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrupos,
            this.mnuItens});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 22);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuGrupos
            // 
            this.mnuGrupos.Name = "mnuGrupos";
            this.mnuGrupos.Size = new System.Drawing.Size(112, 22);
            this.mnuGrupos.Text = "Grupos";
            this.mnuGrupos.Click += new System.EventHandler(this.mnuGrupos_Click);
            // 
            // mnuItens
            // 
            this.mnuItens.Name = "mnuItens";
            this.mnuItens.Size = new System.Drawing.Size(112, 22);
            this.mnuItens.Text = "Itens";
            // 
            // mnuUteis
            // 
            this.mnuUteis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.toolStripSeparator1,
            this.manualToolStripMenuItem});
            this.mnuUteis.Name = "mnuUteis";
            this.mnuUteis.Size = new System.Drawing.Size(45, 22);
            this.mnuUteis.Text = "Úteis";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // grdGerenciamento
            // 
            this.grdGerenciamento.AllowUserToAddRows = false;
            this.grdGerenciamento.AllowUserToDeleteRows = false;
            this.grdGerenciamento.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGerenciamento.Location = new System.Drawing.Point(0, 249);
            this.grdGerenciamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.ReadOnly = true;
            this.grdGerenciamento.Size = new System.Drawing.Size(1132, 341);
            this.grdGerenciamento.TabIndex = 12;
            this.toolTip.SetToolTip(this.grdGerenciamento, "Dê um duplo-clique no começo da linha para abrir o histórico.");
            this.grdGerenciamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGerenciamento_CellDoubleClick);
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            this.grdGerenciamento.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdGerenciamento_RowHeaderMouseDoubleClick);
            // 
            // btnAbrirPedido
            // 
            this.btnAbrirPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btnAbrirPedido.Location = new System.Drawing.Point(960, 157);
            this.btnAbrirPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirPedido.Name = "btnAbrirPedido";
            this.btnAbrirPedido.Size = new System.Drawing.Size(159, 38);
            this.btnAbrirPedido.TabIndex = 10;
            this.btnAbrirPedido.Text = "Pedidos";
            this.toolTip.SetToolTip(this.btnAbrirPedido, "Abrir tela para criar ou consultar lista de pedidos.");
            this.btnAbrirPedido.UseVisualStyleBackColor = false;
            this.btnAbrirPedido.Click += new System.EventHandler(this.btnAbrirPedido_Click);
            // 
            // lblLocalizarPorNome
            // 
            this.lblLocalizarPorNome.AutoSize = true;
            this.lblLocalizarPorNome.ForeColor = System.Drawing.Color.Black;
            this.lblLocalizarPorNome.Location = new System.Drawing.Point(11, 63);
            this.lblLocalizarPorNome.Name = "lblLocalizarPorNome";
            this.lblLocalizarPorNome.Size = new System.Drawing.Size(184, 17);
            this.lblLocalizarPorNome.TabIndex = 11;
            this.lblLocalizarPorNome.Text = "Localizar itens com o nome:";
            this.toolTip.SetToolTip(this.lblLocalizarPorNome, "Digite o nome ou parte do nome de um item para localizá-lo");
            // 
            // txtLocalizarItensPorNome
            // 
            this.txtLocalizarItensPorNome.Location = new System.Drawing.Point(15, 81);
            this.txtLocalizarItensPorNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalizarItensPorNome.MaxLength = 200;
            this.txtLocalizarItensPorNome.Name = "txtLocalizarItensPorNome";
            this.txtLocalizarItensPorNome.Size = new System.Drawing.Size(289, 23);
            this.txtLocalizarItensPorNome.TabIndex = 1;
            this.txtLocalizarItensPorNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalizarItensPorNome_KeyPress);
            // 
            // grpQtdEstoque
            // 
            this.grpQtdEstoque.Controls.Add(this.rdoMenorIgual);
            this.grpQtdEstoque.Controls.Add(this.txtQuantidadeEstoque);
            this.grpQtdEstoque.Controls.Add(this.rdoMaiorIgual);
            this.grpQtdEstoque.Location = new System.Drawing.Point(16, 112);
            this.grpQtdEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.grpQtdEstoque.Name = "grpQtdEstoque";
            this.grpQtdEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.grpQtdEstoque.Size = new System.Drawing.Size(289, 101);
            this.grpQtdEstoque.TabIndex = 12;
            this.grpQtdEstoque.TabStop = false;
            this.grpQtdEstoque.Text = "Quantidade em estoque";
            // 
            // rdoMenorIgual
            // 
            this.rdoMenorIgual.AutoSize = true;
            this.rdoMenorIgual.Location = new System.Drawing.Point(46, 62);
            this.rdoMenorIgual.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMenorIgual.Name = "rdoMenorIgual";
            this.rdoMenorIgual.Size = new System.Drawing.Size(87, 21);
            this.rdoMenorIgual.TabIndex = 3;
            this.rdoMenorIgual.TabStop = true;
            this.rdoMenorIgual.Text = "abaixo de";
            this.rdoMenorIgual.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(140, 36);
            this.txtQuantidadeEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeEstoque.MaxLength = 200;
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(109, 47);
            this.txtQuantidadeEstoque.TabIndex = 4;
            this.txtQuantidadeEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEstoque_KeyPress);
            // 
            // rdoMaiorIgual
            // 
            this.rdoMaiorIgual.AutoSize = true;
            this.rdoMaiorIgual.Location = new System.Drawing.Point(46, 36);
            this.rdoMaiorIgual.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMaiorIgual.Name = "rdoMaiorIgual";
            this.rdoMaiorIgual.Size = new System.Drawing.Size(83, 21);
            this.rdoMaiorIgual.TabIndex = 2;
            this.rdoMaiorIgual.TabStop = true;
            this.rdoMaiorIgual.Text = "acima de";
            this.rdoMaiorIgual.UseVisualStyleBackColor = true;
            // 
            // chkExibirItensAbaixoMinimo
            // 
            this.chkExibirItensAbaixoMinimo.AutoSize = true;
            this.chkExibirItensAbaixoMinimo.Location = new System.Drawing.Point(15, 220);
            this.chkExibirItensAbaixoMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.chkExibirItensAbaixoMinimo.Name = "chkExibirItensAbaixoMinimo";
            this.chkExibirItensAbaixoMinimo.Size = new System.Drawing.Size(363, 21);
            this.chkExibirItensAbaixoMinimo.TabIndex = 5;
            this.chkExibirItensAbaixoMinimo.Text = "Exibir apenas os itens com estoque abaixo do mínimo";
            this.chkExibirItensAbaixoMinimo.UseVisualStyleBackColor = true;
            // 
            // lstGrupos
            // 
            this.lstGrupos.CheckOnClick = true;
            this.lstGrupos.FormattingEnabled = true;
            this.lstGrupos.Location = new System.Drawing.Point(386, 89);
            this.lstGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(198, 148);
            this.lstGrupos.TabIndex = 6;
            this.lstGrupos.Click += new System.EventHandler(this.lstGrupos_Click);
            // 
            // btnExportarLista
            // 
            this.btnExportarLista.BackColor = System.Drawing.SystemColors.Window;
            this.btnExportarLista.Location = new System.Drawing.Point(960, 115);
            this.btnExportarLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarLista.Name = "btnExportarLista";
            this.btnExportarLista.Size = new System.Drawing.Size(159, 38);
            this.btnExportarLista.TabIndex = 9;
            this.btnExportarLista.Text = "Exportar Lista";
            this.toolTip.SetToolTip(this.btnExportarLista, "Exibe a lista de itens em forma de texto para copiar e colar.");
            this.btnExportarLista.UseVisualStyleBackColor = false;
            this.btnExportarLista.Click += new System.EventHandler(this.btnExportarLista_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLocalizar.Location = new System.Drawing.Point(960, 70);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(159, 41);
            this.btnLocalizar.TabIndex = 8;
            this.btnLocalizar.Text = "Localizar itens";
            this.toolTip.SetToolTip(this.btnLocalizar, "Executar busca dos itens com os filtros selecionados.");
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "somar.png");
            this.img.Images.SetKeyName(1, "subtrair.png");
            this.img.Images.SetKeyName(2, "substituir.png");
            // 
            // lblListaDeGrupos
            // 
            this.lblListaDeGrupos.AutoSize = true;
            this.lblListaDeGrupos.ForeColor = System.Drawing.Color.Black;
            this.lblListaDeGrupos.Location = new System.Drawing.Point(383, 63);
            this.lblListaDeGrupos.Name = "lblListaDeGrupos";
            this.lblListaDeGrupos.Size = new System.Drawing.Size(110, 17);
            this.lblListaDeGrupos.TabIndex = 17;
            this.lblListaDeGrupos.Text = "Lista de grupos:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.Location = new System.Drawing.Point(960, 199);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 38);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar campos";
            this.toolTip.SetToolTip(this.btnLimpar, "Limpar os campos de pesquisa.");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelecionarTodos.Location = new System.Drawing.Point(591, 222);
            this.chkSelecionarTodos.Name = "chkSelecionarTodos";
            this.chkSelecionarTodos.Size = new System.Drawing.Size(105, 17);
            this.chkSelecionarTodos.TabIndex = 7;
            this.chkSelecionarTodos.Text = "Selecionar todos";
            this.toolTip.SetToolTip(this.chkSelecionarTodos, "Selecionar todos os grupos");
            this.chkSelecionarTodos.UseVisualStyleBackColor = true;
            this.chkSelecionarTodos.CheckedChanged += new System.EventHandler(this.chkSelecionarTodos_CheckedChanged);
            this.chkSelecionarTodos.Click += new System.EventHandler(this.chkSelecionarTodos_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(-3, 24);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(1136, 29);
            this.lblBarra.TabIndex = 19;
            this.lblBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1133, 590);
            this.Controls.Add(this.chkSelecionarTodos);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblListaDeGrupos);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExportarLista);
            this.Controls.Add(this.lstGrupos);
            this.Controls.Add(this.chkExibirItensAbaixoMinimo);
            this.Controls.Add(this.grpQtdEstoque);
            this.Controls.Add(this.lblLocalizarPorNome);
            this.Controls.Add(this.txtLocalizarItensPorNome);
            this.Controls.Add(this.btnAbrirPedido);
            this.Controls.Add(this.grdGerenciamento);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.grpQtdEstoque.ResumeLayout(false);
            this.grpQtdEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuUteis;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupos;
        private System.Windows.Forms.ToolStripMenuItem mnuItens;
        private System.Windows.Forms.Button btnAbrirPedido;
        private System.Windows.Forms.Label lblLocalizarPorNome;
        private System.Windows.Forms.TextBox txtLocalizarItensPorNome;
        private System.Windows.Forms.GroupBox grpQtdEstoque;
        private System.Windows.Forms.RadioButton rdoMenorIgual;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.RadioButton rdoMaiorIgual;
        private System.Windows.Forms.CheckBox chkExibirItensAbaixoMinimo;
        private System.Windows.Forms.CheckedListBox lstGrupos;
        private System.Windows.Forms.Button btnExportarLista;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ImageList img;
        private System.Windows.Forms.Label lblListaDeGrupos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
    }
}