using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Log
    {
        public Log()
        {

        }

        public Log(long idItem, String descricao, long quantidadeAnterior, long quantidadeAtual, long quantidadeInformada, String origem, Enumeradores.TipoOperacao tpOp, long idPedido, long pedidoNumero)
        {
            this.IdItem = IdItem;
            this.Descricao = descricao;
            this.QuantidadeAnterior = quantidadeAnterior;
            this.QuantidadeAtual = quantidadeAtual;
            this.QuantidadeInformada = quantidadeInformada;
            this.Origem = origem;
            this.TpOperacao = tpOp;
            this.IdPedido = IdPedido;
            this.PedidoNumero = pedidoNumero;
        }

        public Log(long idItem, String descricao, long quantidadeAnterior, long quantidadeAtual, long quantidadeInformada, String origem, String tpOp, long idPedido, long pedidoNumero)
        {
            this.IdItem = IdItem;
            this.Descricao = descricao;
            this.QuantidadeAnterior = quantidadeAnterior;
            this.QuantidadeAtual = quantidadeAtual;
            this.QuantidadeInformada = quantidadeInformada;
            this.Origem = origem;
            this.TpOperacaoNome = tpOp;
            this.IdPedido = IdPedido;
            this.PedidoNumero = pedidoNumero;
        }
        
        public DateTime DataHora { get; set; }
        public long IdItem { get; set; }
        public String Descricao { get; set; }
        public long QuantidadeAnterior { get; set; }
        public long QuantidadeAtual { get; set; }
        public long QuantidadeInformada { get; set; }
        public String Origem { get; set; }
        public Enumeradores.TipoOperacao TpOperacao { get; set; }
        public String TpOperacaoNome { get; set; }
        public long IdPedido { get; set; }
        public long PedidoNumero { get; set; }
        
           
    }
}
