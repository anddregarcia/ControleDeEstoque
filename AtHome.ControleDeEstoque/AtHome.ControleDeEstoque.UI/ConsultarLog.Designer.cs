namespace AtHome.ControleDeEstoque.UI
{
    partial class ConsultarLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLog));
            this.grdLog = new System.Windows.Forms.DataGridView();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblBarra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLog)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLog
            // 
            this.grdLog.AllowUserToAddRows = false;
            this.grdLog.AllowUserToDeleteRows = false;
            this.grdLog.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grdLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLog.Location = new System.Drawing.Point(10, 51);
            this.grdLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdLog.Name = "grdLog";
            this.grdLog.ReadOnly = true;
            this.grdLog.RowHeadersWidth = 20;
            this.grdLog.Size = new System.Drawing.Size(872, 260);
            this.grdLog.TabIndex = 7;
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btnPesquisarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPesquisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPedido.Image")));
            this.btnPesquisarPedido.Location = new System.Drawing.Point(13, 12);
            this.btnPesquisarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(34, 25);
            this.btnPesquisarPedido.TabIndex = 11;
            this.btnPesquisarPedido.TabStop = false;
            this.btnPesquisarPedido.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(847, 13);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 25);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(10, 7);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(872, 36);
            this.lblBarra.TabIndex = 13;
            this.lblBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultarLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(893, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.grdLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultarLog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.ConsultarLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLog;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblBarra;
    }
}