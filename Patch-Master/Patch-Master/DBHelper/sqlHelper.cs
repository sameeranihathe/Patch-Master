using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Patch_Master.DBHelper
{
    public class sqlHelper
    {
        SqlConnection cn;
        public sqlHelper(String connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
                return true;
            }
        }
        public IList<string> databaseNameList()
        {
            IList<string> databaselist = new List<string>();
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            var sql = "SELECT name as name FROM master.dbo.sysdatabases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
            using var cmd = new SqlCommand(sql, cn);

            using SqlDataReader rdr = cmd.ExecuteReader();
            //Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10}");

            while (rdr.Read())
            {
                databaselist.Add(rdr["name"].ToString());
                //Console.WriteLine($"{rdr.GetInt32(0),-4} {rdr.GetString(1),-10} {rdr.GetInt32(2),10}");
            }

            return databaselist;
        }
    }
}
