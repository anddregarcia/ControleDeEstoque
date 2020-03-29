using AtHome.ControleDeEstoque.Data;
using System;
using System.Windows.Forms;

namespace AtHome.ControleDeEstoque.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfiguracaoDAO configDAO = new ConfiguracaoDAO();
            BaseDeDadosDAO bdDAO = new BaseDeDadosDAO();

            bool _usaSenhaPadrao = false;

            bdDAO.AtualizarBaseDeDados();

            if (args.Length > 0)
            {
                _usaSenhaPadrao = (args[0] == "esqueciminhasenha");
            }

            if (configDAO.ExigirSenha())
            {
                LoginSenha window = new LoginSenha(_usaSenhaPadrao);
                window.ShowDialog();

                Application.Run(new Principal());
            }
            else
            {
                Application.Run(new Principal());
            }       
        }
    }
}
