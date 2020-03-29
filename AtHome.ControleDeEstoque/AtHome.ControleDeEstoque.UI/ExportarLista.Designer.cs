namespace AtHome.ControleDeEstoque.UI
{
    partial class ExportarLista
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
            this.rtbExportarLista = new System.Windows.Forms.RichTextBox();
            this.chkAsterisco = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbExportarLista
            // 
            this.rtbExportarLista.Location = new System.Drawing.Point(12, 12);
            this.rtbExportarLista.Name = "rtbExportarLista";
            this.rtbExportarLista.Size = new System.Drawing.Size(643, 224);
            this.rtbExportarLista.TabIndex = 0;
            this.rtbExportarLista.Text = "";
            this.rtbExportarLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbExportarLista_KeyDown);
            // 
            // chkAsterisco
            // 
            this.chkAsterisco.AutoSize = true;
            this.chkAsterisco.Checked = true;
            this.chkAsterisco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAsterisco.Location = new System.Drawing.Point(12, 242);
            this.chkAsterisco.Name = "chkAsterisco";
            this.chkAsterisco.Size = new System.Drawing.Size(162, 17);
            this.chkAsterisco.TabIndex = 1;
            this.chkAsterisco.Text = "Remover/Inserir asterísco (*)";
            this.chkAsterisco.UseVisualStyleBackColor = true;
            this.chkAsterisco.CheckedChanged += new System.EventHandler(this.chkAsterisco_CheckedChanged);
            // 
            // ExportarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 265);
            this.Controls.Add(this.chkAsterisco);
            this.Controls.Add(this.rtbExportarLista);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "ExportarLista";
            this.ShowInTaskbar = false;
            this.Text = "Exportar Lista";
            this.Load += new System.EventHandler(this.ExportarLista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExportarLista_KeyDown);
            this.Resize += new System.EventHandler(this.ExportarLista_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbExportarLista;
        private System.Windows.Forms.CheckBox chkAsterisco;
    }
}