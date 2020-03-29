namespace AtHome.ControleDeEstoque.UI
{
    partial class CadastroDeGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeGrupo));
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.grdGrupo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeGrupo.Location = new System.Drawing.Point(11, 75);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeGrupo.MaxLength = 200;
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(289, 23);
            this.txtNomeGrupo.TabIndex = 5;
            this.txtNomeGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeGrupo_KeyDown);
            this.txtNomeGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeGrupo_KeyPress);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomeGrupo.Location = new System.Drawing.Point(7, 57);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(109, 17);
            this.lblNomeGrupo.TabIndex = 1;
            this.lblNomeGrupo.Text = "Nome do Grupo";
            // 
            // grdGrupo
            // 
            this.grdGrupo.AllowUserToAddRows = false;
            this.grdGrupo.AllowUserToDeleteRows = false;
            this.grdGrupo.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrupo.Location = new System.Drawing.Point(11, 101);
            this.grdGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdGrupo.Name = "grdGrupo";
            this.grdGrupo.ReadOnly = true;
            this.grdGrupo.RowHeadersWidth = 20;
            this.grdGrupo.Size = new System.Drawing.Size(290, 302);
            this.grdGrupo.TabIndex = 6;
            this.grdGrupo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGrupo_RowEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 44);
            this.label2.TabIndex = 7;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(250, 14);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(112, 14);
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
            this.btnSalvar.Location = new System.Drawing.Point(61, 14);
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
            this.btnNovo.AccessibleDescription = "";
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
            // CadastroDeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 413);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grdGrupo);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroDeGrupo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupos";
            this.Activated += new System.EventHandler(this.CadastroDeGrupo_Activated);
            this.Load += new System.EventHandler(this.CadastroDeGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.DataGridView grdGrupo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

