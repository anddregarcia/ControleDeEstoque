namespace AtHome.ControleDeEstoque.UI
{
    partial class AlterarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarEstoque));
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Snow;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(12, 12);
            this.txtQuantidade.MaxLength = 6;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(222, 75);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // btnOperacao
            // 
            this.btnOperacao.BackColor = System.Drawing.SystemColors.Window;
            this.btnOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOperacao.Location = new System.Drawing.Point(240, 12);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(101, 75);
            this.btnOperacao.TabIndex = 1;
            this.btnOperacao.TabStop = false;
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "somar.png");
            this.img.Images.SetKeyName(1, "subtrair.png");
            this.img.Images.SetKeyName(2, "substituir.png");
            // 
            // AlterarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 100);
            this.Controls.Add(this.btnOperacao);
            this.Controls.Add(this.txtQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AlterarEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Estoque";
            this.Load += new System.EventHandler(this.AlterarEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlterarEstoque_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.ImageList img;
    }
}