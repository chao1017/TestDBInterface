using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace TestDBInterface.Models
{
    public class DBRepository : IDBRepository
    {
        public bool ConnectDB(string dbType, string dbName)
        {
            bool result = false;
            string connStr = ConfigurationManager.ConnectionStrings[dbType].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                result = true;
            }

            return result;
            //throw new NotImplementedException();
        }
    }
}