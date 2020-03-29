namespace AtHome.ControleDeEstoque.UI
{
    partial class CadastroConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroConfiguracao));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeDaEmpresa = new System.Windows.Forms.TextBox();
            this.chkExigeSenha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCaminhoLogo = new System.Windows.Forms.TextBox();
            this.txtRelatorioTelefone = new System.Windows.Forms.TextBox();
            this.txtRelatorioCabecalho = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dirLogo = new System.DirectoryServices.DirectorySearcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(105, 118);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(175, 23);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtNomeDaEmpresa
            // 
            this.txtNomeDaEmpresa.Location = new System.Drawing.Point(25, 49);
            this.txtNomeDaEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeDaEmpresa.MaxLength = 100;
            this.txtNomeDaEmpresa.Name = "txtNomeDaEmpresa";
            this.txtNomeDaEmpresa.Size = new System.Drawing.Size(255, 23);
            this.txtNomeDaEmpresa.TabIndex = 3;
            this.txtNomeDaEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDaEmpresa_KeyPress);
            // 
            // chkExigeSenha
            // 
            this.chkExigeSenha.AutoSize = true;
            this.chkExigeSenha.Location = new System.Drawing.Point(25, 90);
            this.chkExigeSenha.Name = "chkExigeSenha";
            this.chkExigeSenha.Size = new System.Drawing.Size(255, 21);
            this.chkExigeSenha.TabIndex = 4;
            this.chkExigeSenha.Text = "Exigir senha para acessar o sistema";
            this.toolTip.SetToolTip(this.chkExigeSenha, "Quando esta opção estiver marcada o sistema exigirá uma senha de acesso.");
            this.chkExigeSenha.UseVisualStyleBackColor = true;
            this.chkExigeSenha.CheckedChanged += new System.EventHandler(this.chkExigeSenha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeEmpresa);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtNomeDaEmpresa);
            this.groupBox1.Controls.Add(this.chkExigeSenha);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(22, 28);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(129, 17);
            this.lblNomeEmpresa.TabIndex = 6;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            this.toolTip.SetToolTip(this.lblNomeEmpresa, "Informar o nome para exibição no sistema e no relatório da lista de pedidos.");
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(45, 121);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCabecalho);
            this.groupBox2.Controls.Add(this.btnLocalizar);
            this.groupBox2.Controls.Add(this.lblLogo);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.txtCaminhoLogo);
            this.groupBox2.Controls.Add(this.txtRelatorioTelefone);
            this.groupBox2.Controls.Add(this.txtRelatorioCabecalho);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 258);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório da lista de pedidos";
            this.toolTip.SetToolTip(this.groupBox2, "Informações que serão exibidas no relatório da lista de pedidos.");
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Location = new System.Drawing.Point(19, 96);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(79, 17);
            this.lblCabecalho.TabIndex = 7;
            this.lblCabecalho.Text = "Cabeçalho:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(353, 61);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(25, 20);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.TabStop = false;
            this.toolTip.SetToolTip(this.btnLocalizar, "Localizar imagem");
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(43, 63);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(44, 17);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "Logo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(19, 32);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtCaminhoLogo
            // 
            this.txtCaminhoLogo.Enabled = false;
            this.txtCaminhoLogo.Location = new System.Drawing.Point(94, 60);
            this.txtCaminhoLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaminhoLogo.MaxLength = 200;
            this.txtCaminhoLogo.Name = "txtCaminhoLogo";
            this.txtCaminhoLogo.Size = new System.Drawing.Size(256, 23);
            this.txtCaminhoLogo.TabIndex = 6;
            this.txtCaminhoLogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelatorioTelefone_KeyPress);
            // 
            // txtRelatorioTelefone
            // 
            this.txtRelatorioTelefone.Location = new System.Drawing.Point(94, 29);
            this.txtRelatorioTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelatorioTelefone.MaxLength = 200;
            this.txtRelatorioTelefone.Name = "txtRelatorioTelefone";
            this.txtRelatorioTelefone.Size = new System.Drawing.Size(288, 23);
            this.txtRelatorioTelefone.TabIndex = 6;
            this.txtRelatorioTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelatorioTelefone_KeyPress);
            // 
            // txtRelatorioCabecalho
            // 
            this.txtRelatorioCabecalho.Location = new System.Drawing.Point(22, 117);
            this.txtRelatorioCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelatorioCabecalho.MaxLength = 4000;
            this.txtRelatorioCabecalho.Multiline = true;
            this.txtRelatorioCabecalho.Name = "txtRelatorioCabecalho";
            this.txtRelatorioCabecalho.Size = new System.Drawing.Size(360, 134);
            this.txtRelatorioCabecalho.TabIndex = 7;
            this.txtRelatorioCabecalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRelatorioCabecalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelatorioCabecalho_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(356, 14);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(22, 14);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(45, 31);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.Window;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(12, 9);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(389, 44);
            this.lblLine.TabIndex = 18;
            // 
            // dirLogo
            // 
            this.dirLogo.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.dirLogo.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dirLogo.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // CadastroConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroConfiguracao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.CadastroConfiguracao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeDaEmpresa;
        private System.Windows.Forms.CheckBox chkExigeSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtRelatorioTelefone;
        private System.Windows.Forms.TextBox txtRelatorioCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtCaminhoLogo;
        private System.DirectoryServices.DirectorySearcher dirLogo;
    }
}