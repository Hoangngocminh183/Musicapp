using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_upform
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=Mervyn1803\SQLEXPRESS;Initial Catalog=Login_signup1;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
