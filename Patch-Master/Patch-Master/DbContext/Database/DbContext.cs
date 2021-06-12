using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace Patch_Master.DbContext.Database
{
    public class DbConnector
    {
        string ConnectionString = "";
        SqlConnection con;

        public DbConnector()
        {
            ConnectionString = GetConnectionString();
            OpenConection();
        }

        public string GetConnectionString()
        {
            NameValueCollection section = new NameValueCollection();

            section = (NameValueCollection)ConfigurationManager.GetSection("MsSQL/Database");

            string ConnString = "";
            string integratedSecurity = section.GetValues("integratedSecurity")[0];
            string Server = section.GetValues("server")[0];
            string Database = section.GetValues("database")[0];
            string ConnectTimeOut = section.GetValues("connecttimeout") == null ? "" : section.GetValues("connecttimeout")[0];
            string Connectionminpoolsize = section.GetValues("connectionminpoolsize") == null ? "" : section.GetValues("connectionminpoolsize")[0];
            string Connectionmaxpoolsize = section.GetValues("connectionmaxpoolsize") == null ? "" : section.GetValues("connectionmaxpoolsize")[0];
            var alwaysEncryptionEnabled = section.GetValues("alwaysEncryptionEnabled") == null ? false : bool.Parse(section.GetValues("alwaysEncryptionEnabled")[0]);

            if (bool.Parse(integratedSecurity))
            {
                ConnString = "Server=" + Server + ";database=" + Database + ";Integrated Security=True";
            }
            else
            {
                string Username = section.GetValues("username")[0];
                string Password = section.GetValues("password")[0];
                //if encryption is needed use a encryption method
                // Password = encryptionHandler.DecryptText(Password);
                ConnString = "Server=" + Server + ";database=" + Database + ";UID=" + Username + ";PWD=" + Password;
            }

            if (!string.IsNullOrEmpty(ConnectTimeOut))
            {
                ConnString += ";Connect Timeout=" + ConnectTimeOut;
            }

            if (!string.IsNullOrEmpty(Connectionminpoolsize))
            {
                ConnString += ";Min Pool Size=" + Connectionminpoolsize;
            }

            if (!string.IsNullOrEmpty(Connectionmaxpoolsize))
            {
                ConnString += ";Max Pool Size=" + Connectionmaxpoolsize;
            }

            return ConnString;
        }


        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        private readonly object syncLock = new object();

        public IDataReader[] ExecuteQueryWithIDataReader(string sql, List<SqlParameter> sqlParams)
        {
            DateTime startTime = DateTime.Now;
            int commandTimeOut = int.Parse(System.Configuration.ConfigurationManager.AppSettings["TimeOut"].ToString());
            string paramValues = "";
            lock (syncLock)
            {
                IDataReader[] result = new IDataReader[1];

                try
                {
                    foreach (SqlParameter sqlParam in sqlParams)
                    {
                        sql = sql.Replace("??" + sqlParam.ParameterName, sqlParam.Value.ToString());
                        sql = sql.Replace("_@" + sqlParam.ParameterName, "_" + sqlParam.Value.ToString());
                        sql = sql.Replace("N@" + sqlParam.ParameterName, "N'" + sqlParam.Value.ToString() + "'");

                        if (null != sqlParam.Value)
                            paramValues = sqlParam.ParameterName + "=" + sqlParam.Value.ToString() + " ";
                    }


                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    foreach (SqlParameter sqlParam in sqlParams)
                    {
                        sqlCommand.Parameters.Add(sqlParam);
                    }

                    sqlCommand.CommandTimeout = commandTimeOut;

                    SqlDataReader drGet = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    result[0] = (IDataReader)drGet;

                    return result;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    //if (ExecutionMode != Execution.Multiple)
                    //  CloseConnection();
                }
            }
        }

        public DataSet ExecuteQueryWithDataSet(string sql, List<SqlParameter> sqlParams)
        {
            DataSet ds = new DataSet();
            DateTime startTime = DateTime.Now;
            int commandTimeOut = int.Parse(System.Configuration.ConfigurationManager.AppSettings["TimeOut"].ToString());
            string paramValues = "";
            try
            {
                foreach (SqlParameter sqlParam in sqlParams)
                {
                    sql = sql.Replace("??" + sqlParam.ParameterName, sqlParam.Value.ToString());
                    sql = sql.Replace("_@" + sqlParam.ParameterName, "_" + sqlParam.Value.ToString());
                    sql = sql.Replace("N@" + sqlParam.ParameterName, "N'" + sqlParam.Value.ToString() + "'");

                    if (null != sqlParam.Value)
                        paramValues = sqlParam.ParameterName + "=" + sqlParam.Value.ToString() + " ";
                }

                SqlCommand com = new SqlCommand(sql, con);
                com.CommandTimeout = commandTimeOut;
                foreach (SqlParameter sqlParam in sqlParams)
                {
                    com.Parameters.Add(sqlParam);
                }
                SqlDataAdapter da = new SqlDataAdapter(com);


                da.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //if (ExecutionMode != Execution.Multiple)
                //    CloseConnection();
            }
        }
    }
}
