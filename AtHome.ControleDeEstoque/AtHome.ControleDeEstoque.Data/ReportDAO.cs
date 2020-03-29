using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AtHome.ControleDeEstoque.Data
{
    public class ReportDAO
    {

        AppDbConnection _appConn;

        public ReportDAO()
        {

        }

        public List<ItensParaGerenciamento> ItensParaGerenciamento(String grupos_selecionados, String nome_item, Enumeradores.TipoComparador tpOP, long quantidade, bool abaixo_do_minimo)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            SqlConnection con = new SqlConnection();
            var result = new List<ItensParaGerenciamento>();
            DataTable tabela = new DataTable();

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append("select b.item_id, b.item_desc, ");
                    sql.Append(String.Format("       b.item_tamanho, "));
                    //sql.Append(String.Format("       a.grupo_id, "));
                    sql.Append(String.Format("       a.grupo_desc, "));
                    sql.Append(String.Format("       b.item_qtd_atual, "));
                    sql.Append(String.Format("       b.item_estoque_minimo,"));
                    sql.Append(String.Format("       b.item_preco_custo,"));
                    sql.Append(String.Format("       b.item_preco_venda,"));
                    sql.Append(String.Format("       case when b.item_qtd_atual <= b.item_estoque_minimo"));
                    sql.Append(String.Format("       then 1 else 0 end as estoque_baixo"));
                    sql.Append(String.Format("  from tab_grupo a inner join"));
                    sql.Append(String.Format("       tab_item b on (a.grupo_id = b.grupo_id)"));
                    sql.Append(String.Format(" where 1 = 1"));

                    if (!grupos_selecionados.Equals(String.Empty))
                    {
                        sql.Append(String.Format(" and a.grupo_id in ({0}) ", grupos_selecionados));
                    }

                    if (!nome_item.Equals(String.Empty))
                    {
                        sql.Append(String.Format(" and UPPER(b.item_desc) like '%{0}%' ", nome_item.ToUpper()));
                    }

                    if (!tpOP.Equals(Enumeradores.TipoComparador.Nenhum))
                    {
                        if (tpOP.Equals(Enumeradores.TipoComparador.Maior_que))
                            sql.Append(String.Format(" and b.item_qtd_atual >= {0} ", quantidade.ToString()));

                        if (tpOP.Equals(Enumeradores.TipoComparador.Menor_que))
                            sql.Append(String.Format(" and b.item_qtd_atual <= {0} ", quantidade.ToString()));
                    }

                    if (abaixo_do_minimo)
                    {
                        sql.Append(String.Format(" and b.item_qtd_atual <= b.item_estoque_minimo"));
                    }

                    sql.Append(String.Format(" order by a.grupo_desc, b.item_desc, b.item_qtd_atual"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());
                    while (sdr.Read())
                    {
                        var item = new ItensParaGerenciamento
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            Grupo_Descricao = sdr["grupo_desc"].ToString(),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString()),
                            EstoqueBaixo = Convert.ToInt32(sdr["estoque_baixo"].ToString())
                        };
                        result.Add(item);
                    }

                    /*con = _appConn.Conexao();
                    using (SqlCommand cmd = new SqlCommand(sql.ToString(), con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        tabela.Load(cmd.ExecuteReader());
                    }

                    return tabela;*/
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;            
        }
    }
}
