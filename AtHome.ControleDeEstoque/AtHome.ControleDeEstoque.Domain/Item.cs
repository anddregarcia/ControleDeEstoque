using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Item
    {
        public Item() { }

        public Item(String descricao, String tamanho, long grupoId, long quantidade, long estoqueMinimo, Double precoCusto, Double precoVenda, Double porcentagemLucro)
        {
            this.GrupoId = grupoId;
            this.Descricao = descricao;
            this.Tamanho = tamanho;
            this.Quantidade = quantidade;
            this.EstoqueMinimo = estoqueMinimo;
            this.PrecoCusto = precoCusto;
            this.PrecoVenda = precoVenda;
            this.PorcentagemLucro = porcentagemLucro;
        }

        public Item(String descricao, long quantidade, long estoqueMinimo, Double precoCusto, Double precoVenda, Double porcentagemLucro)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.EstoqueMinimo = estoqueMinimo;
            this.PrecoCusto = precoCusto;
            this.PrecoVenda = precoVenda;
            this.PorcentagemLucro = porcentagemLucro;
        }

        public long Id { get; set; }
        public String Descricao { get; set; }
        public String Tamanho { get; set; }
        public long GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public long Quantidade { get; set; }
        public long EstoqueMinimo { get; set; }
        public Double PrecoCusto { get; set; }
        public Double PrecoVenda { get; set; }
        public Double PorcentagemLucro { get; set; }

        public const long ESTOQUE_MAXIMO = 999999;

    }

    public class ItensParaGerenciamento
    {
        public ItensParaGerenciamento()
        {

        }

        public ItensParaGerenciamento(long id,
            String descricao,
            String grupoDescricao,
            long quantidade,
            long estoqueMinimo,
            Double precoCusto,
            Double precoVenda,
            int estoqueBaixo)
        {
            this.Id = Id;
            this.Descricao = descricao;
            this.Grupo_Descricao = grupoDescricao;
            this.Quantidade = quantidade;
            this.EstoqueMinimo = estoqueMinimo;
            this.PrecoCusto = precoCusto;
            this.PrecoVenda = precoVenda;
            this.EstoqueBaixo = estoqueBaixo;
        }

        public long Id { get; set; }
        public String Descricao { get; set; }
        public String Tamanho { get; set; }
        public String Grupo_Descricao { get; set; }
        public long Quantidade { get; set; }
        public long EstoqueMinimo { get; set; }
        public Double PrecoCusto { get; set; }
        public Double PrecoVenda { get; set; }
        public int EstoqueBaixo { get; set; }

    }
}
