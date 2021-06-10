using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Database
{
    public class ConnectionProvider
    {

        private static string connStr = ConfigurationManager.AppSettings["dbConn"];

  
        public DbConnection CreateInstance()
        {
            return new MySqlConnection(connStr);
        }
    }
}
