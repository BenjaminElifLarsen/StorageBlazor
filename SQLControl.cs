using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StorageBlazor
{
    public class SQLControl
    {
        private static SqlConnection sqlConnection;

        public static string CreateConnectionString()
        {
            SqlConnectionStringBuilder sqlCnt = new SqlConnectionStringBuilder();
            sqlCnt["Server"] = @"BENJAMIN-ELIF-L\MSSQLSERVER02";
            sqlCnt.InitialCatalog = "NetStorage";
            sqlCnt.IntegratedSecurity = true;
            return sqlCnt.ToString();
        }

        public static bool CreateConnection(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
                sqlConnection = connection;
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
