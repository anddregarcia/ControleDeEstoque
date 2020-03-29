using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace AtHome.ControleDeEstoque.Data
{
    public class GrupoDAO
    {
        AppDbConnection _appConn;

        public long Save(Grupo data)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" insert  into  tab_grupo ");
                    sql.Append(String.Format("          (grupo_desc) "));
                    sql.Append(String.Format("  output inserted.grupo_id"));
                    sql.Append(String.Format("  values "));
                    sql.Append(String.Format("          ('{0}')", data.Descricao));

                    data.Id = _appConn.ExecuteScalar(sql.ToString());
                }
            }
            catch (Exception)
            {                
                throw;
            }


            return data.Id;
        }

        public bool Update(Grupo data)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" update  tab_grupo ");
                    sql.Append(String.Format("       set  grupo_desc  =  '{0}'", data.Descricao));
                    sql.Append(String.Format("   where  grupo_id = {0}", data.Id.ToString()));

                    regs = _appConn.ExecuteNonQuery(sql.ToString());

                }
            }
            catch (Exception)
            {                
                throw;
            }

            return (regs > 0);
        }

        public bool Delete(Grupo data)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();
            ItemDAO itemDAO = new ItemDAO();
            List<Item> itens = new List<Item>();

            //TODO: Adicionar verificação de itens associados aos grupos antes de excluir

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" delete  from  tab_grupo ");
                    sql.Append(String.Format(" where  grupo_id = {0}", data.Id));

                    try
                    {
                        regs = _appConn.ExecuteScalar(sql.ToString()); ;
                    }
                    catch (Exception)
                    {
                        throw new SystemException("Este grupo não pode ser excluído pois existem itens relacionados a ele.\nPara excluir o grupo é preciso excluir os itens primeiro.");
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return (regs > 0);
        }

        public List<Grupo> GetData(Grupo data)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Grupo>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  grupo_id ");
                    sql.Append(String.Format("             ,grupo_desc "));
                    sql.Append(String.Format("     from  tab_grupo "));
                    sql.Append(String.Format("    where  grupo_id = {0}", data.Id));
                    sql.Append(String.Format("    order  by grupo_desc"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                    {
                        var grupo = new Grupo
                        {
                            Id = Convert.ToInt32(sdr["grupo_id"].ToString()),
                            Descricao = sdr["grupo_desc"].ToString()
                        };

                        result.Add(grupo);
                    }

                    return result;
                }
            }
            catch (Exception)
            {                
                throw;
            }

        }

        public List<Grupo> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new List<Grupo>();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  grupo_id ");
                    sql.Append(String.Format("          ,grupo_desc "));
                    sql.Append(String.Format("     from  tab_grupo "));
                    sql.Append(String.Format("    order  by grupo_desc"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    while (sdr.Read())
                    {
                        var grupo = new Grupo
                        {
                            Id = Convert.ToInt32(sdr["grupo_id"].ToString()),
                            Descricao = sdr["grupo_desc"].ToString()
                        };
                        result.Add(grupo);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }
            
            return result;

        }

        public Grupo GetDataByID(long id)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new Grupo();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  grupo_id ");
                    sql.Append(String.Format("          ,grupo_desc "));
                    sql.Append(String.Format("     from  tab_grupo "));
                    sql.Append(String.Format("    where  grupo_id = {0}", id));
                    sql.Append(String.Format("    order  by grupo_desc"));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                    {
                        var grupo = new Grupo
                        {
                            Id = Convert.ToInt64(sdr["grupo_id"].ToString()),
                            Descricao = sdr["grupo_desc"].ToString()
                        };
                        result = grupo;
                    }
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
