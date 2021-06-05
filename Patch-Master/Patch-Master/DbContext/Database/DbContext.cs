using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace Patch_Master.DbContext.Database
{
    public class DbContext
    {
        string ConnectionString = "";
        SqlConnection con;

        public DbContext()
        {
            ConnectionString = GetConnectionString();
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
    }
}
