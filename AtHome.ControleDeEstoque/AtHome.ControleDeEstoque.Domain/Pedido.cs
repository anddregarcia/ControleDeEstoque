using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Pedido
    {
        public Pedido() { }

        public Pedido(long numero, String observacao, List<ItemDoPedido> itens, Double valor)
        {
            this.Numero = numero;
            this.Observacao = observacao;
            this.ItensDoPedido = itens;
            this.Valor = valor;
        }

        public long Id { get; set; }
        public long Numero { get; set; }
        public DateTime DataHora { get; set; }
        public String Observacao { get; set; }
        public bool PedidoFinalizado { get; set; }
        public Enumeradores.TipoOperacao TipoOperacao { get; set; }
        public List<ItemDoPedido> ItensDoPedido { get; set; }
        public Double Valor { get; set; }

    }

    public class ItemDoPedido
    {
        public ItemDoPedido() { }

        public ItemDoPedido(long id_item, String descricao, long id_pedido, String tamanho, long id_grupo, String descricao_grupo, long quantidade_estoque, long quantidade_pedido, Double preco_venda, Double valor_total)
        {
            this.IdItem = id_item;
            this.Descricao = descricao;
            this.IdPedido = id_pedido;
            this.IdGrupo = id_grupo;
            this.DescricaoGrupo = descricao_grupo;
            this.Tamanho = tamanho;
            this.QuantidadeEstoque = quantidade_estoque;
            this.QuantidadePedido = quantidade_pedido;
            this.PrecoVenda = preco_venda;
            this.ValorTotal = valor_total;
        }

        public long IdItem { get; set; }
        public String Descricao { get; set; }
        public long IdPedido { get; set; }
        public long IdGrupo { get; set; }
        public String Tamanho { get; set; }
        public String DescricaoGrupo { get; set; }
        public long QuantidadeEstoque { get; set; }
        public long QuantidadePedido { get; set; }
        public Double PrecoVenda { get; set; }
        public Double ValorTotal { get; set; }

    }

}
