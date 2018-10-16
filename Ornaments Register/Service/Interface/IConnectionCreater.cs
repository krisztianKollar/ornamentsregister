using System.Data.SqlClient;

namespace Ornaments_Register.Service.Interface
{
    interface IConnectionCreater
    {
        SqlConnection connect();
    }
}
