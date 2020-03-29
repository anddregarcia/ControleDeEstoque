using AtHome.ControleDeEstoque.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Data
{
    public class ConfiguracaoDAO
    {
        AppDbConnection _appConn;

        public void Save(Configuracao data)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" insert  into  dbo.tab_configuracao ");
                    sql.Append(String.Format("          (config_solicita_senha, config_senha, config_rel_cabecalho, config_rel_telefone, config_rel_nome_empresa, config_logotipo) "));
                    sql.Append(String.Format("  values "));
                    sql.Append(String.Format("          ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", Convert.ToInt32(data.ExigeSenha).ToString()
                                                                                                 , data.Senha
                                                                                                 , data.CabecalhoRelatorio
                                                                                                 , data.TelefoneRelatorio
                                                                                                 , data.NomeDaEmpresa
                                                                                                 , data.LogoTipo));

                    _appConn.ExecuteNonQuery(sql.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Update(Configuracao data)
        {
            long regs = 0;
            StringBuilder sql = new StringBuilder();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" update  dbo.tab_configuracao ");
                    sql.Append(String.Format("       set  config_solicita_senha  =  {0},", Convert.ToInt32(data.ExigeSenha).ToString()));
                    sql.Append(String.Format("            config_senha  =  '{0}',", data.Senha));
                    sql.Append(String.Format("            config_rel_cabecalho  =  '{0}',", data.CabecalhoRelatorio));
                    sql.Append(String.Format("            config_rel_telefone  =  '{0}',", data.TelefoneRelatorio));
                    sql.Append(String.Format("            config_rel_nome_empresa  =  '{0}',", data.NomeDaEmpresa));
                    sql.Append(String.Format("            config_logotipo  =  '{0}'", data.LogoTipo));

                    regs = _appConn.ExecuteNonQuery(sql.ToString());

                }

            }
            catch (Exception)
            {

                throw;
            }

            return (regs > 0);
        }

        public Configuracao GetData()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            var result = new Configuracao();

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  config_solicita_senha ");
                    sql.Append(String.Format("          ,config_senha "));
                    sql.Append(String.Format("          ,config_rel_cabecalho "));
                    sql.Append(String.Format("          ,config_rel_telefone "));
                    sql.Append(String.Format("          ,config_rel_nome_empresa "));
                    sql.Append(String.Format("          ,config_logotipo "));
                    sql.Append(String.Format("     from  dbo.tab_configuracao "));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                    {
                        var configuracao = new Configuracao
                        {
                            ExigeSenha = Convert.ToBoolean(Convert.ToInt32(sdr["config_solicita_senha"].ToString())),
                            Senha = sdr["config_senha"].ToString(),
                            CabecalhoRelatorio = sdr["config_rel_cabecalho"].ToString(),
                            TelefoneRelatorio = sdr["config_rel_telefone"].ToString(),
                            NomeDaEmpresa = sdr["config_rel_nome_empresa"].ToString(),
                            LogoTipo = sdr["config_logotipo"].ToString()
                        };
                        result = configuracao;
                    }
                    else
                    {
                        var configuracao = new Configuracao
                        {
                            ExigeSenha = false,
                            Senha = "",
                            CabecalhoRelatorio = "",
                            TelefoneRelatorio = "",
                            NomeDaEmpresa = "",
                            LogoTipo = ""
                        };
                        result = configuracao;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            int result = 0;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select 1 from dbo.tab_configuracao ");
                    result = _appConn.ExecuteScalar(sql.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public bool VerificaSenha(String senhaInformada)
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            String Senha = "";

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  config_senha ");
                    sql.Append(String.Format("     from  dbo.tab_configuracao "));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                        Senha = sdr["config_senha"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }

            return Senha.Equals(senhaInformada);
        }

        public bool ExigirSenha()
        {
            StringBuilder sql = new StringBuilder();
            SqlDataReader sdr;
            bool exige = false;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append(" select  config_solicita_senha ");
                    sql.Append(String.Format("     from  dbo.tab_configuracao "));

                    sdr = _appConn.ExecuteQuery(sql.ToString());

                    if (sdr.Read())
                        exige = Convert.ToBoolean(Convert.ToInt32(sdr["config_solicita_senha"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return exige;
        }


    } //fim da classe
} //fim do namespace
