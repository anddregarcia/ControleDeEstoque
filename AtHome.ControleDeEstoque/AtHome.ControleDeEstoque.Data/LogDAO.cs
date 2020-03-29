using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Data
{
    public static class LogDAO
    {
        
        /*
                log_data_hora datetime, --data e hora do registro do log
                log_item_id numeric(10), --identificador do item 
                log_item_desc varchar(200), --descricao do item
                log_quantidade numeric(10), --quantidade que ficou no estoque
                log_quantidade_informada numeric(10), --quantidade utilizada na operação
                log_origem varchar(100), --onde ocorre a alteração (em qual tela)
                log_tipo_operacao varchar(20), --tipo da operação
                log_pedido_id numeric(10), --identificador do pedido
                log_pedido_numero numeric(10) --número do pedido
         */
         
        public static void GravarRastreabilidade(this Log log)
        {
            StringBuilder sql = new StringBuilder();

            AppDbConnection _appConn;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" insert into dbo.tab_log");
                    sql.Append(String.Format("     (log_data_hora, log_item_id, log_item_desc, log_quantidade_anterior, log_quantidade, log_quantidade_informada, log_origem, log_tipo_operacao, log_pedido_id, log_pedido_numero)"));
                    sql.Append(String.Format("     values ('{0}', {1}, '{2}', {3}, {4}, {5}, '{6}', '{7}', {8}, {9})", DateTime.Now.ToString()
                                                                                                                     , log.IdItem.ToString()
                                                                                                                     , log.Descricao
                                                                                                                     , log.QuantidadeAnterior.ToString()
                                                                                                                     , log.QuantidadeAtual.ToString()
                                                                                                                     , log.QuantidadeInformada.ToString()
                                                                                                                     , log.Origem
                                                                                                                     , log.TpOperacao.ToString()
                                                                                                                     , log.IdPedido.ToString()
                                                                                                                     , log.PedidoNumero.ToString()
                                                                                                                     ));

                    _appConn.ExecuteNonQuery(sql.ToString());

                }
            }
            catch (Exception)
            { }

        }

        public static List<Log> GetLogByID(long idItem, int dias = 30)
        {

            StringBuilder sql = new StringBuilder();
            List<Log> result = new List<Log>();
            AppDbConnection _appConn;
            SqlDataReader sdr;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("select log_data_hora");
                    sql.Append(String.Format("      ,log_item_id"));
                    sql.Append(String.Format("      ,log_item_desc"));
                    sql.Append(String.Format("      ,log_quantidade_anterior"));
                    sql.Append(String.Format("      ,log_quantidade"));
                    sql.Append(String.Format("      ,log_quantidade_informada"));
                    sql.Append(String.Format("      ,log_origem"));
                    sql.Append(String.Format("      ,log_tipo_operacao"));
                    sql.Append(String.Format("      ,log_pedido_id"));
                    sql.Append(String.Format("      ,log_pedido_numero"));
                    sql.Append(String.Format("  from dbo.tab_log"));
                    sql.Append(String.Format(" where log_data_hora >= '{0}'", Convert.ToString(DateTime.Now.AddDays(dias * (-1)))));
                    sql.Append(String.Format("   and log_item_id = {0}", idItem.ToString()));
                    sql.Append(String.Format(" order by log_data_hora desc"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var log = new Log
                        {
                            DataHora = DateTime.Parse(sdr["log_data_hora"].ToString()),
                            IdItem = Int64.Parse(sdr["log_item_id"].ToString()),
                            Descricao = sdr["log_item_desc"].ToString(),
                            QuantidadeAnterior = Int64.Parse(sdr["log_quantidade_anterior"].ToString()),
                            QuantidadeAtual = Int64.Parse(sdr["log_quantidade"].ToString()),
                            QuantidadeInformada = Int64.Parse(sdr["log_quantidade_informada"].ToString()),
                            Origem = sdr["log_origem"].ToString(),
                            TpOperacaoNome = sdr["log_tipo_operacao"].ToString(),
                            IdPedido = Int64.Parse(sdr["log_pedido_id"].ToString()),
                            PedidoNumero = Int64.Parse(sdr["log_pedido_numero"].ToString())
                        };
                        result.Add(log);
                    }
                }
            }
            catch (Exception)
            { throw;  }
            
            return result;

        }
    }
}
