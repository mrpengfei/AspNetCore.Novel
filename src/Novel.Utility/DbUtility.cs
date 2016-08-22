using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Novel.Utility
{
    public class DbUtility
    {
        public static IDbConnection GetConnection() {
            var connection = new MySqlConnection("Server=127.0.0.1;Database=novel;UId=shipengfei;pwd=12345678;");
            return connection;
        }
    }
}
