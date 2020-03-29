using System;
using System.Windows.Forms;
using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class AlterarEstoque : Form
    {
        public AlterarEstoque(Enumeradores.TipoOperacao tpOp, long idItem, long quantidade)
        {
            InitializeComponent();
            this.tpOperacao = tpOp;
            this.IdItem = idItem;
            this.Quantidade = quantidade;
            _novaQuantidade = quantidade;
        }

        Enumeradores.TipoOperacao tpOperacao { get; set; }
        long IdItem { get; set; }
        long Quantidade { get; set; }

        long _novaQuantidade;

        public long NovaQuantidade
        {
            get { return _novaQuantidade; }
        }

        private void AlterarEstoque_Load(object sender, EventArgs e)
        {
            btnOperacao.Image = img.Images[(int)tpOperacao];
            if (Enumeradores.TipoOperacao.Somar.Equals(tpOperacao))
                btnOperacao.Text = "Somar";
            else if (Enumeradores.TipoOperacao.Subtrair.Equals(tpOperacao))
                btnOperacao.Text = "Subtrair";
            else if (Enumeradores.TipoOperacao.Substituir.Equals(tpOperacao))
                btnOperacao.Text = "Substituir";
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            AlterarQuantidadeEstoque();
        }

        private void AlterarQuantidadeEstoque()
        {
            ItemDAO itemDAO = new ItemDAO();
            Item item = new Item();
            long novaQuantidade = this.Quantidade;

            if (txtQuantidade.Text.Equals(""))
            {
                txtQuantidade.Focus();
                return;
            }

            item = itemDAO.GetDataByID(this.IdItem);

            if (this.tpOperacao.Equals(Enumeradores.TipoOperacao.Somar))
                novaQuantidade = this.Quantidade + Convert.ToInt64(txtQuantidade.Text);
            else if (this.tpOperacao.Equals(Enumeradores.TipoOperacao.Subtrair))
                novaQuantidade = this.Quantidade - Convert.ToInt64(txtQuantidade.Text);
            else if (this.tpOperacao.Equals(Enumeradores.TipoOperacao.Substituir))
                novaQuantidade = Convert.ToInt64(txtQuantidade.Text);
            else
                novaQuantidade = this.Quantidade;

            if (novaQuantidade < 0 || novaQuantidade > Item.ESTOQUE_MAXIMO)
            {
                MessageBox.Show("Não será possível realizar a alteração, pois o estoque ficaria inválido para o sistema! (Quantidade: " + novaQuantidade.ToString() + ")", AlterarEstoque.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("O estoque do item '" + item.Descricao + "' será alterado para: " + novaQuantidade.ToString() + " \nDeseja realmente continuar?", AlterarEstoque.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
                {
                    try
                    {
                        itemDAO.AlterarQuantidadeEstoque(this.IdItem, novaQuantidade);

                        Log log = new Log()
                        {
                            IdItem = this.IdItem,
                            Descricao = item.Descricao + " (" + item.Tamanho + ")",
                            QuantidadeAnterior = this.Quantidade,
                            QuantidadeAtual = novaQuantidade,
                            QuantidadeInformada = Convert.ToInt64(txtQuantidade.Text),
                            Origem = this.Text,
                            TpOperacao = tpOperacao,
                            IdPedido = 0,
                            PedidoNumero = 0
                        };

                        log.GravarRastreabilidade();

                        MessageBox.Show("O estoque foi alterado com sucesso!", AlterarEstoque.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _novaQuantidade = novaQuantidade;
                        this.Hide();
                    }
                    catch (Exception) { throw; }
                }
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && IdItem != 0) AlterarQuantidadeEstoque();
            if (e.KeyCode.Equals(Keys.Escape)) this.Hide();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AlterarEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape)) this.Hide();
        }
    }
}
