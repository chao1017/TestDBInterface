#define _INSERT_DATA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace TestDBInterface.Models
{
    public class DBRepository : IDBRepository
    {
        public bool ConnectDB(string dbType)
        {
            bool result = false;
            string connStr = ConfigurationManager.ConnectionStrings[dbType].ToString();
            
            using (OleDbConnection connection = new OleDbConnection(connStr))
            {
                
                connection.Open();
                result = true;
            }

            return result;
            //throw new NotImplementedException();
        }

    }
}