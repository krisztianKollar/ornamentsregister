using System.Data.SqlClient;
using System.Data.SQLite;

namespace Ornaments_Register.Service.Interface
{
    interface IConnectionCreater
    {
        SQLiteConnection connect();
    }
}
