using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using Ornaments_Register.Service.Interface;

namespace Ornaments_Register.Service.Simple
{
    class SimpleConnectionCreater : IConnectionCreater
    {
        string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            return conn;
        }
    }
}
