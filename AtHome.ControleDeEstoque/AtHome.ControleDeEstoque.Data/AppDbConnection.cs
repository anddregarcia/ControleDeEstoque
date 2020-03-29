using System;
using System.Data.SqlClient;
using System.Configuration;


namespace AtHome.ControleDeEstoque.Data
{
    class AppDbConnection : IDisposable
    {
        SqlConnection _conn;

        public SqlConnection Conexao()
        {
            try
            {
                var strConn = ConfigurationManager.ConnectionStrings["ControleDeEstoque"].ConnectionString;
                //var strConn = @"Data Source=NOTEANDRE-PC\ATHOME;Initial Catalog=CONTROLEDEESTOQUE;Integrated Security=SSPI";
                //var strConn = @"Data Source=GA-DE-NB-SPF-61\SQLEXPRESS;Initial Catalog=CONTROLEDEESTOQUE;Integrated Security=SSPI";
                _conn = new SqlConnection(strConn);
            }
            catch (Exception)
            {
            }

            return _conn;
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection cn = Conexao();
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CloseConnection(SqlConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlDataReader ExecuteQuery(string sql)
        {
            SqlCommand sqlComm = new SqlCommand(sql, OpenConnection());
            SqlDataReader reader = sqlComm.ExecuteReader();
            return reader;
        }

        public int ExecuteScalar(string sql)
        {
            SqlCommand sqlComm = new SqlCommand(sql, OpenConnection());
            int id = Convert.ToInt32(sqlComm.ExecuteScalar());
            return id;
        }

        public long ExecuteNonQuery(string sql)
        {
            long regs;

            try
            {
                SqlCommand sqlComm = new SqlCommand(sql, OpenConnection());
                regs = sqlComm.ExecuteNonQuery();

                return regs;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            this.CloseConnection(_conn);
        }
    }
}
