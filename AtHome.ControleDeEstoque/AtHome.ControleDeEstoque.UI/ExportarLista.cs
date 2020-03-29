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
    public partial class ExportarLista : Form
    {
        public ExportarLista(String itens)
        {
            InitializeComponent();
            this.Itens = itens;
        }
        
        private String Itens;

        private void ExportarLista_Load(object sender, EventArgs e)
        {
            rtbExportarLista.Text = this.Itens;
        }

        private void ExportarLista_Resize(object sender, EventArgs e)
        {
            rtbExportarLista.Width = ExportarLista.ActiveForm.Width - rtbExportarLista.Left - 30;
            rtbExportarLista.Height = ExportarLista.ActiveForm.Height - rtbExportarLista.Top - 50;
        }

        private void ExportarLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape)) this.Dispose();
        }

        private void rtbExportarLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape)) this.Dispose();
        }

        private void chkAsterisco_CheckedChanged(object sender, EventArgs e)
        {
            string texto;

            if (chkAsterisco.Checked)
            {
                texto = rtbExportarLista.Text;

                texto = texto.Replace("Item:", "*Item:*");
                texto = texto.Replace("Tamanho:", "*Tamanho:*");
                texto = texto.Replace("Grupo:", "*Grupo:*");
                texto = texto.Replace("Estoque:", "*Estoque:*");
                texto = texto.Replace("Preço de Custo:", "*Preço de Custo:*");

                rtbExportarLista.Text = texto;

            }
            else
            {
                texto = rtbExportarLista.Text;

                texto = texto.Replace("*Item:*", "Item:");
                texto = texto.Replace("*Tamanho:*", "Tamanho:");
                texto = texto.Replace("*Grupo:*", "Grupo:");
                texto = texto.Replace("*Estoque:*", "Estoque:");
                texto = texto.Replace("*Preço de Custo:*", "Preço de Custo:");

                rtbExportarLista.Text = texto;
            }
        }
    }
}
