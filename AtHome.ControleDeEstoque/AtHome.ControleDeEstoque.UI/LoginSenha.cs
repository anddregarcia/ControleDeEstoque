using AtHome.ControleDeEstoque.Data;
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
    public partial class LoginSenha : Form
    {
        public LoginSenha(bool usarSenhaPadrao)
        {
            InitializeComponent();
            this.UsarSenhaPadrao = usarSenhaPadrao;
        }

        private bool UsarSenhaPadrao { get; set; }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) LiberarAcesso();
        }

        private void LiberarAcesso()
        {
            ConfiguracaoDAO configDAO = new ConfiguracaoDAO();

            if (this.UsarSenhaPadrao)
            {
                if (txtSenha.Text == Convert.ToString(DateTime.Now.Day +
                                                      DateTime.Now.Month +
                                                      DateTime.Now.Year)) this.Dispose();
                else
                {
                    MessageBox.Show("Senha Inválida!", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
            }
            else
            {
                if (configDAO.VerificaSenha(txtSenha.Text))
                    this.Dispose();
                else
                {
                    MessageBox.Show("Senha Inválida!", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {          
            LiberarAcesso();
        }

        private void LoginSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

    }
}
