using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AtHome.ControleDeEstoque.Data
{
    public class PedidoDAO
    {
        AppDbConnection _appConn;

        public long Save(Pedido data)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append(" insert  into  dbo.tab_pedido ");
                    sql.Append(String.Format("          (pedido_numero, pedido_data_hora, pedido_finalizado, pedido_tipo_operacao, pedido_observacao, pedido_valor) "));
                    sql.Append(String.Format("  output inserted.pedido_id"));
                    sql.Append(String.Format("  values "));
                    sql.Append(String.Format("          ({0}, '{1}', {2}, {3}, '{4}', {5})", data.Numero
                                                                               , DateTime.Now.ToString()
                                                                               , 0 //não finalizado
                                                                               , (int)data.TipoOperacao
                                                                               , data.Observacao
                                                                               , data.Valor.ToString().Replace(",", ".")));

                    data.Id = _appConn.ExecuteScalar(sql.ToString());

                    foreach (var item in data.ItensDoPedido)
                    {
                        sql = new StringBuilder();
                        sql.Append(" insert  into  dbo.tab_pedido_item ");
                        sql.Append(String.Format("          (pedido_id, item_id, item_desc, pedido_item_tamanho, grupo_desc, pedido_quantidade, pedido_valor_unitario, pedido_valor_total) "));
                        sql.Append(String.Format("  values "));
                        sql.Append(String.Format("          ({0}, {1}, '{2}', '{3}', '{4}', {5}, {6}, {7})", data.Id
                                                                                                           , item.IdItem
                                                                                                           , item.Descricao
                                                                                                           , item.Tamanho
                                                                                                           , item.DescricaoGrupo
                                                                                                           , item.QuantidadePedido
                                                                                                           , item.PrecoVenda.ToString().Replace(",", ".")
                                                                                                           , item.ValorTotal.ToString().Replace(",", ".")));

                        _appConn.ExecuteScalar(sql.ToString());

                    }
                }
                return data.Id;
            }
            catch (Exception)
            { throw; }
        }

        public bool FinalizarPedido(long idPedido)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" update  tab_pedido ");
                    sql.Append(String.Format("     set  pedido_finalizado  =  1"));
                    sql.Append(String.Format("   where  pedido_id = {0}", idPedido));

                    regs = _appConn.ExecuteNonQuery(sql.ToString());
                }
            }
            catch (Exception)
            { throw; }

            return (regs > 0);
        }

        public List<Pedido> GetAllPedido()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Pedido>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select a.pedido_id, ");
                    sql.Append(String.Format("       a.pedido_numero, "));
                    sql.Append(String.Format("       a.pedido_data_hora, "));
                    sql.Append(String.Format("       a.pedido_observacao, "));
                    sql.Append(String.Format("       a.pedido_tipo_operacao, "));
                    sql.Append(String.Format("       a.pedido_finalizado, "));
                    sql.Append(String.Format("       a.pedido_valor "));
                    sql.Append(String.Format("  from dbo.tab_pedido a "));
                    sql.Append(String.Format(" where pedido_finalizado = 1 "));
                    sql.Append(String.Format(" order by a.pedido_data_hora desc"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new Pedido
                        {
                            Id = Convert.ToInt64(sdr["pedido_id"].ToString()),
                            Numero = Convert.ToInt64(sdr["pedido_numero"].ToString()),
                            DataHora = (DateTime)(sdr["pedido_data_hora"]),
                            Observacao = sdr["pedido_observacao"].ToString(),
                            //TipoOperacao = (Enumeradores.TipoOperacao)sdr["pedido_tipo_operacao"],
                            //PedidoFinalizado = (bool)(sdr["pedido_finalizado"]),
                            Valor = Convert.ToDouble(sdr["pedido_valor"].ToString())
                        };

                        result.Add(item);
                    }

                    return result;
                }
            }
            catch (Exception)
            { throw; }
        }

        public List<ItemDoPedido> GetAllItensDoPedido(long idPedido)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<ItemDoPedido>();

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append(" select a.pedido_id, ");
                    sql.Append(String.Format("       a.item_id,"));
                    sql.Append(String.Format("       a.item_desc,"));
                    sql.Append(String.Format("       a.grupo_desc,"));
                    sql.Append(String.Format("       a.pedido_item_tamanho,"));
                    sql.Append(String.Format("       a.pedido_quantidade,"));
                    sql.Append(String.Format("       a.pedido_valor_unitario,"));
                    sql.Append(String.Format("       a.pedido_valor_total"));
                    sql.Append(String.Format("  from dbo.tab_pedido_item a"));

                    if (idPedido != 0)
                    {
                        sql.Append(String.Format("  where a.pedido_id = {0}", idPedido.ToString()));
                    }

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new ItemDoPedido
                        {
                            IdPedido = Convert.ToInt64(sdr["pedido_id"].ToString()),
                            IdItem = Convert.ToInt64(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            Tamanho = sdr["pedido_item_tamanho"].ToString(),
                            DescricaoGrupo = sdr["grupo_desc"].ToString(),
                            QuantidadePedido = Convert.ToInt64(sdr["pedido_quantidade"].ToString()),
                            PrecoVenda = Convert.ToDouble(sdr["pedido_valor_unitario"].ToString()),
                            ValorTotal = Convert.ToDouble(sdr["pedido_valor_total"].ToString())
                        };
                        result.Add(item);
                    }

                    return result;
                }
            }
            catch (Exception)
            { throw; }

        }

        public long PegarProximoNumero()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append(" select coalesce(max(a.pedido_numero),0) + 1 as proximo");
                    sql.Append(String.Format("  from dbo.tab_pedido a"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                        return Convert.ToInt64(sdr["proximo"].ToString());
                    else
                        return 1;

                }

            }
            catch (Exception) { throw; }
        }

        public Pedido GetDataById(long idPedido)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new Pedido();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select a.pedido_id, ");
                    sql.Append(String.Format("       a.pedido_numero, "));
                    sql.Append(String.Format("       a.pedido_data_hora, "));
                    sql.Append(String.Format("       a.pedido_observacao, "));
                    sql.Append(String.Format("       a.pedido_tipo_operacao, "));
                    sql.Append(String.Format("       a.pedido_finalizado, "));
                    sql.Append(String.Format("       a.pedido_valor "));
                    sql.Append(String.Format("  from dbo.tab_pedido a "));
                    sql.Append(String.Format(" where pedido_finalizado = 1 "));
                    sql.Append(String.Format("   and pedido_id = {0}", idPedido.ToString()));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new Pedido
                        {
                            Id = Convert.ToInt64(sdr["pedido_id"].ToString()),
                            Numero = Convert.ToInt64(sdr["pedido_numero"].ToString()),
                            DataHora = (DateTime)(sdr["pedido_data_hora"]),
                            Observacao = sdr["pedido_observacao"].ToString(),
                            //TipoOperacao = (Enumeradores.TipoOperacao)sdr["pedido_tipo_operacao"],
                            //PedidoFinalizado = (bool)(sdr["pedido_finalizado"]),
                            Valor = Convert.ToDouble(sdr["pedido_valor"].ToString())
                        };

                        result = item;
                    }

                    return result;
                }
            }
            catch (Exception)
            { throw; }
        }

    }
}
