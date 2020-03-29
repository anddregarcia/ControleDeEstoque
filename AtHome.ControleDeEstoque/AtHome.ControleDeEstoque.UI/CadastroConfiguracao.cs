using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class CadastroConfiguracao : Form
    {
        public CadastroConfiguracao()
        {
            InitializeComponent();
        }

        private void txtNomeDaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void txtRelatorioTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void txtRelatorioCabecalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }

        private void SalvarConfiguracao()
        {
            if (MessageBox.Show("Deseja salvar?", CadastroConfiguracao.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
            {
                Configuracao config = new Configuracao();
                ConfiguracaoDAO configDAO = new ConfiguracaoDAO();

                config.ExigeSenha = chkExigeSenha.Checked;
                config.Senha = txtSenha.Text;
                config.NomeDaEmpresa = txtNomeDaEmpresa.Text;
                config.TelefoneRelatorio = txtRelatorioTelefone.Text;
                config.CabecalhoRelatorio = txtRelatorioCabecalho.Text;
                config.LogoTipo = txtCaminhoLogo.Text;

                if (!Validacao()) return;

                try
                {
                    if (configDAO.Count()==0)
                    {
                        configDAO.Save(config); 
                    }else
                    {
                        configDAO.Update(config);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CadastroConfiguracao.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool Validacao()
        {
            if (chkExigeSenha.Checked && txtSenha.Text.Equals(String.Empty))
            {
                MessageBox.Show("Informe a senha.", CadastroConfiguracao.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void CadastroConfiguracao_Load(object sender, EventArgs e)
        {
            Configuracao config = new Configuracao();
            ConfiguracaoDAO configDAO = new ConfiguracaoDAO();

            config = configDAO.GetData();

            chkExigeSenha.Checked = config.ExigeSenha;
            txtSenha.Text = config.Senha;
            txtNomeDaEmpresa.Text = config.NomeDaEmpresa;
            txtRelatorioTelefone.Text = config.TelefoneRelatorio;
            txtRelatorioCabecalho.Text = config.CabecalhoRelatorio;
            txtCaminhoLogo.Text = config.LogoTipo;

            if (chkExigeSenha.Checked)
            {
                txtSenha.Enabled = true;
            }
            else
            {
                txtSenha.Text = "";
                txtSenha.Enabled = false;
            }
        }

        private void chkExigeSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExigeSenha.Checked)
            {
                txtSenha.Enabled = true;
            }
            else
            {
                txtSenha.Text = "";
                txtSenha.Enabled = false;
            }
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtCaminhoLogo.Text = ofd.FileName;
            }
        }
    }
}
