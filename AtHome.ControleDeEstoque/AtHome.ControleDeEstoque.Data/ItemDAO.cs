using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AtHome.ControleDeEstoque.Data
{
    public class ItemDAO
    {
        AppDbConnection _appConn;

        public long Save(Item data)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append(" insert  into  dbo.tab_item ");
                    sql.Append(String.Format("          (item_desc, grupo_id, item_qtd_atual, item_estoque_minimo, item_tamanho, item_preco_custo, item_porcetagem_lucro, item_preco_venda) "));
                    sql.Append(String.Format("  output inserted.item_id"));
                    sql.Append(String.Format("  values "));
                    sql.Append(String.Format("          ('{0}', {1}, {2}, {3}, '{4}', {5}, {6}, {7})", data.Descricao
                                                                                                     , data.GrupoId
                                                                                                     , data.Quantidade.ToString()
                                                                                                     , data.EstoqueMinimo.ToString()
                                                                                                     , data.Tamanho
                                                                                                     , data.PrecoCusto.ToString().Replace(",", ".")
                                                                                                     , data.PorcentagemLucro.ToString().Replace(",", ".")
                                                                                                     , data.PrecoVenda.ToString().Replace(",", ".")));

                    data.Id = _appConn.ExecuteScalar(sql.ToString());

                }
            }
            catch (Exception)
            {
                throw;
            }

            return data.Id;
        }

        public bool Update(Item data)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" update  dbo.tab_item ");
                    sql.Append(String.Format("       set  item_desc  =  '{0}', ", data.Descricao));
                    sql.Append(String.Format("            grupo_id  =  {0}, ", data.GrupoId));
                    sql.Append(String.Format("            item_qtd_atual  =  {0}, ", data.Quantidade.ToString()));
                    sql.Append(String.Format("            item_estoque_minimo  =  {0}, ", data.EstoqueMinimo.ToString()));
                    sql.Append(String.Format("            item_tamanho  =  '{0}', ", data.Tamanho));
                    sql.Append(String.Format("            item_preco_custo  =  {0}, ", data.PrecoCusto.ToString().Replace(",", ".")));
                    sql.Append(String.Format("            item_porcetagem_lucro  =  {0}, ", data.PorcentagemLucro.ToString().Replace(",", ".")));
                    sql.Append(String.Format("            item_preco_venda  =  {0} ", data.PrecoVenda.ToString().Replace(",", ".")));
                    sql.Append(String.Format("   where  item_id = {0}", data.Id.ToString()));

                    regs = _appConn.ExecuteNonQuery(sql.ToString());

                }
            }
            catch (Exception)
            {
                throw;
            }

            return (regs > 0);
        }

        public bool Delete(Item data)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" delete  from  dbo.tab_item ");
                    sql.Append(String.Format(" where  item_id = {0}", data.Id));

                    regs = _appConn.ExecuteScalar(sql.ToString()); ;
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return (regs > 0);
        }

        public List<Item> GetData(Item data)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Item>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select item_id,item_desc, grupo_id, item_qtd_atual, item_estoque_minimo, item_tamanho, item_preco_custo, item_porcetagem_lucro, item_preco_venda ");
                    sql.Append(String.Format("     from  dbo.tab_item "));
                    sql.Append(String.Format("    where  item_id = {0}", data.Id));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                    {
                        var item = new Item
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            GrupoId = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PorcentagemLucro = Convert.ToDouble(sdr["item_porcetagem_lucro"].ToString()),
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString())
                        };

                        result.Add(item);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;
        }

        public List<Item> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Item>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  item_id, item_desc, grupo_id, item_qtd_atual, item_estoque_minimo, item_tamanho, item_preco_custo, item_porcetagem_lucro, item_preco_venda ");
                    sql.Append(String.Format("     from  dbo.tab_item "));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new Item
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            GrupoId = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PorcentagemLucro = Convert.ToDouble(sdr["item_porcetagem_lucro"].ToString()),
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString())
                        };
                        result.Add(item);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;
            
        }

        public Item GetDataByID(long id)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new Item();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select item_id,item_desc, grupo_id, item_qtd_atual, item_estoque_minimo, item_tamanho, item_preco_custo, item_porcetagem_lucro, item_preco_venda ");
                    sql.Append(String.Format("     from  dbo.tab_item "));
                    sql.Append(String.Format("    where  item_id = {0}", id));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                    {
                        var item = new Item
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            GrupoId = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PorcentagemLucro = Convert.ToDouble(sdr["item_porcetagem_lucro"].ToString()),
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString())
                        };
                        result = item;
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;
            
        }

        public List<Item> GetDataByGrupoId(long grupoId)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Item>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  item_id, item_desc, item_tamanho, grupo_id, item_qtd_atual, item_estoque_minimo, item_preco_custo, item_porcetagem_lucro, item_preco_venda ");
                    sql.Append(String.Format("     from  dbo.tab_item "));
                    sql.Append(String.Format("    where  grupo_id = {0}", grupoId));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new Item
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            GrupoId = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PorcentagemLucro = Convert.ToDouble(sdr["item_porcetagem_lucro"].ToString()) / 100,
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString())
                        };
                        result.Add(item);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;
           
        }

        public void AlterarQuantidadeEstoque(long idItem, long quantidade)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" update  dbo.tab_item ");
                    sql.Append(String.Format("       set  item_qtd_atual  =  {0} ", quantidade.ToString()));
                    sql.Append(String.Format("   where  item_id = {0}", idItem.ToString()));

                    _appConn.ExecuteNonQuery(sql.ToString());
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public List<Item> RetornaItensParaLista(long grupos, String descricao_item)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Item>();
            GrupoDAO grupoDAO = new GrupoDAO();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  a.item_id, ");
                    sql.Append(String.Format("           a.item_desc, "));
                    sql.Append(String.Format("           a.grupo_id, "));
                    sql.Append(String.Format("           b.grupo_desc, "));
                    sql.Append(String.Format("           a.item_qtd_atual, "));
                    sql.Append(String.Format("           a.item_estoque_minimo, "));
                    sql.Append(String.Format("           a.item_tamanho, "));
                    sql.Append(String.Format("           a.item_preco_custo, "));
                    sql.Append(String.Format("           a.item_porcetagem_lucro, "));
                    sql.Append(String.Format("           a.item_preco_venda "));
                    sql.Append(String.Format("     from  dbo.tab_item a "));
                    sql.Append(String.Format("    inner  join dbo.tab_grupo b on (a.grupo_id = b.grupo_id)"));
                    sql.Append(String.Format("    where  1=1"));

                    if (grupos != 0)
                    {
                        sql.Append(String.Format("      and  a.grupo_id in ({0})", grupos));
                    }

                    if (descricao_item != String.Empty)
                    {
                        sql.Append(String.Format("      and  a.item_desc like '%{0}%'", descricao_item));
                    }

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var item = new Item
                        {
                            Id = Convert.ToInt32(sdr["item_id"].ToString()),
                            Descricao = sdr["item_desc"].ToString(),
                            GrupoId = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Grupo = grupoDAO.GetDataByID(Convert.ToInt32(sdr["grupo_id"].ToString())),
                            Quantidade = Convert.ToInt64(sdr["item_qtd_atual"].ToString()),
                            EstoqueMinimo = Convert.ToInt64(sdr["item_estoque_minimo"].ToString()),
                            Tamanho = sdr["item_tamanho"].ToString(),
                            PrecoCusto = Convert.ToDouble(sdr["item_preco_custo"].ToString()),
                            PorcentagemLucro = Convert.ToDouble(sdr["item_porcetagem_lucro"].ToString()) / 100,
                            PrecoVenda = Convert.ToDouble(sdr["item_preco_venda"].ToString())
                        };
                        result.Add(item);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return result;
            
        }

        //public void GravarRastreabilidade(long idItem, String descricao, long quantidade, long quantidadeInformada, String origem, Enumeradores.TipoOperacao tpOp, long idPedido, long pedidoNumero)
        //{
        //    StringBuilder sql = new StringBuilder();

        //    try
        //    {

        //        using (_appConn = new AppDbConnection())
        //        {
        //            sql.Append(" insert into dbo.tab_log");
        //            sql.Append(String.Format("     (log_data_hora, log_item_id, log_item_desc, log_quantidade_anterior, log_quantidade, log_quantidade_informada, log_origem, log_tipo_operacao, log_pedido_id, log_pedido_numero)"));
        //            sql.Append(String.Format("     values ('{0}', {1}, '{2}', {3}, {4}, '{5}', '{6}', {7}, {8}, {9})", DateTime.Now.ToString()
        //                                                                                            , idItem.ToString()
        //                                                                                            , descricao
        //                                                                                            , quantidadeAnterior.ToString()
        //                                                                                            , quantidade.ToString()
        //                                                                                            , quantidadeInformada.ToString()
        //                                                                                            , origem
        //                                                                                            , tpOp.ToString()
        //                                                                                            , idPedido.ToString()
        //                                                                                            , pedidoNumero.ToString()
        //                                                                                            ));

        //            _appConn.ExecuteNonQuery(sql.ToString());

        //        }
        //    }
        //    catch (Exception)
        //    {}

        //}

    } //fechamento da classe
} //fechamento do namespace
