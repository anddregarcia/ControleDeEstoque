namespace AtHome.ControleDeEstoque.UI
{
    partial class ConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPedidos));
            this.btnFechar = new System.Windows.Forms.Button();
            this.grdPedido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(557, 17);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 31);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grdPedido
            // 
            this.grdPedido.AllowUserToAddRows = false;
            this.grdPedido.AllowUserToDeleteRows = false;
            this.grdPedido.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedido.Location = new System.Drawing.Point(13, 57);
            this.grdPedido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grdPedido.Name = "grdPedido";
            this.grdPedido.ReadOnly = true;
            this.grdPedido.RowHeadersWidth = 20;
            this.grdPedido.Size = new System.Drawing.Size(589, 383);
            this.grdPedido.TabIndex = 4;
            this.grdPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedido_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 44);
            this.label2.TabIndex = 10;
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btnPesquisarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPesquisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPedido.Image")));
            this.btnPesquisarPedido.Location = new System.Drawing.Point(17, 17);
            this.btnPesquisarPedido.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(45, 31);
            this.btnPesquisarPedido.TabIndex = 1;
            this.btnPesquisarPedido.TabStop = false;
            this.btnPesquisarPedido.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(72, 17);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 31);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.grdPedido);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarPedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedidos";
            this.Load += new System.EventHandler(this.ConsultarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView grdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Button btnImprimir;
    }
}