using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using Ornaments_Register.Service.Interface;

namespace Ornaments_Register.Service.Simple
{
    class SimpleConnectionCreater : IConnectionCreater
    {
        string connString = ConfigurationManager.ConnectionStrings["plantsConnectionString"].ConnectionString;
      

        public SQLiteConnection connect()
        {
            SQLiteConnection conn = new SQLiteConnection
            {
                ConnectionString = connString
            };
            return conn;
        }
    }
}
