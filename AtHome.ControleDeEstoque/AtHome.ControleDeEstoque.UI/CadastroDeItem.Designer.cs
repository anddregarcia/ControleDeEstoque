namespace AtHome.ControleDeEstoque.UI
{
    partial class CadastroDeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeItem));
            this.lblLine = new System.Windows.Forms.Label();
            this.grdItens = new System.Windows.Forms.DataGridView();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.lblQtdAtual = new System.Windows.Forms.Label();
            this.txtQtdAtual = new System.Windows.Forms.TextBox();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPorcetagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCalcularPorcetagem = new System.Windows.Forms.Button();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.Window;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(9, 9);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(766, 44);
            this.lblLine.TabIndex = 15;
            // 
            // grdItens
            // 
            this.grdItens.AllowUserToAddRows = false;
            this.grdItens.AllowUserToDeleteRows = false;
            this.grdItens.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItens.Location = new System.Drawing.Point(9, 188);
            this.grdItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdItens.Name = "grdItens";
            this.grdItens.ReadOnly = true;
            this.grdItens.Size = new System.Drawing.Size(764, 141);
            this.grdItens.TabIndex = 13;
            this.grdItens.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItens_RowEnter);
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomeItem.Location = new System.Drawing.Point(6, 88);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(95, 17);
            this.lblNomeItem.TabIndex = 9;
            this.lblNomeItem.Text = "Nome do Item";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeItem.Location = new System.Drawing.Point(9, 107);
            this.txtNomeItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeItem.MaxLength = 200;
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(289, 23);
            this.txtNomeItem.TabIndex = 5;
            this.txtNomeItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeItem_KeyPress);
            // 
            // lblQtdAtual
            // 
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQtdAtual.Location = new System.Drawing.Point(377, 139);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(71, 17);
            this.lblQtdAtual.TabIndex = 17;
            this.lblQtdAtual.Text = "Qtd. Atual";
            // 
            // txtQtdAtual
            // 
            this.txtQtdAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdAtual.Location = new System.Drawing.Point(380, 157);
            this.txtQtdAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdAtual.MaxLength = 6;
            this.txtQtdAtual.Name = "txtQtdAtual";
            this.txtQtdAtual.Size = new System.Drawing.Size(112, 23);
            this.txtQtdAtual.TabIndex = 12;
            this.txtQtdAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtdAtual_KeyDown);
            this.txtQtdAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdAtual_KeyPress);
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(495, 90);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(117, 17);
            this.lblEstoqueMinimo.TabIndex = 19;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo *";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(498, 107);
            this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoqueMinimo.MaxLength = 6;
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(107, 23);
            this.txtEstoqueMinimo.TabIndex = 7;
            this.txtEstoqueMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMinimo_KeyPress);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTamanho.Location = new System.Drawing.Point(302, 90);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(68, 17);
            this.lblTamanho.TabIndex = 21;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTamanho.Location = new System.Drawing.Point(305, 107);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTamanho.MaxLength = 100;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(187, 23);
            this.txtTamanho.TabIndex = 6;
            this.txtTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanho_KeyPress);
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecoCusto.Location = new System.Drawing.Point(6, 138);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(105, 17);
            this.lblPrecoCusto.TabIndex = 23;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoCusto.Location = new System.Drawing.Point(9, 157);
            this.txtPrecoCusto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoCusto.MaxLength = 11;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(107, 23);
            this.txtPrecoCusto.TabIndex = 8;
            this.txtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoCusto_KeyPress);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.txtPrecoCusto_Leave);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecoVenda.Location = new System.Drawing.Point(265, 139);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(110, 17);
            this.lblPrecoVenda.TabIndex = 25;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Enabled = false;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoVenda.Location = new System.Drawing.Point(268, 157);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoVenda.MaxLength = 11;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(107, 23);
            this.txtPrecoVenda.TabIndex = 11;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            // 
            // lblPorcetagem
            // 
            this.lblPorcetagem.AutoSize = true;
            this.lblPorcetagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPorcetagem.Location = new System.Drawing.Point(192, 162);
            this.lblPorcetagem.Name = "lblPorcetagem";
            this.lblPorcetagem.Size = new System.Drawing.Size(20, 17);
            this.lblPorcetagem.TabIndex = 27;
            this.lblPorcetagem.Text = "%";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPorcentagem.Location = new System.Drawing.Point(126, 157);
            this.txtPorcentagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPorcentagem.MaxLength = 8;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(65, 23);
            this.txtPorcentagem.TabIndex = 9;
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagem_KeyPress);
            this.txtPorcentagem.Leave += new System.EventHandler(this.txtPorcentagem_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(728, 14);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(114, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 31);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(63, 14);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(45, 31);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(12, 14);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(45, 31);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCalcularPorcetagem
            // 
            this.btnCalcularPorcetagem.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcularPorcetagem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularPorcetagem.FlatAppearance.BorderSize = 0;
            this.btnCalcularPorcetagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPorcetagem.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularPorcetagem.Image")));
            this.btnCalcularPorcetagem.Location = new System.Drawing.Point(214, 147);
            this.btnCalcularPorcetagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcularPorcetagem.Name = "btnCalcularPorcetagem";
            this.btnCalcularPorcetagem.Size = new System.Drawing.Size(45, 37);
            this.btnCalcularPorcetagem.TabIndex = 10;
            this.btnCalcularPorcetagem.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCalcularPorcetagem, "Calcular Preço de Venda");
            this.btnCalcularPorcetagem.UseVisualStyleBackColor = false;
            this.btnCalcularPorcetagem.Click += new System.EventHandler(this.btnCalcularPorcetagem_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.BackColor = System.Drawing.Color.FloralWhite;
            this.lblGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrupo.Location = new System.Drawing.Point(9, 60);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(765, 21);
            this.lblGrupo.TabIndex = 34;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastroDeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 333);
            this.ControlBox = false;
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.btnCalcularPorcetagem);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblPorcetagem);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.lblQtdAtual);
            this.Controls.Add(this.txtQtdAtual);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.grdItens);
            this.Controls.Add(this.lblNomeItem);
            this.Controls.Add(this.txtNomeItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroDeItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Item";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CadastroDeItem_Activated);
            this.Load += new System.EventHandler(this.CadastroDeItem_Load);
            this.Resize += new System.EventHandler(this.CadastroDeItem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.DataGridView grdItens;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label lblQtdAtual;
        private System.Windows.Forms.TextBox txtQtdAtual;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPorcetagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCalcularPorcetagem;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}