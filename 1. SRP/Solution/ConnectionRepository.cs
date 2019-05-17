using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class ConnectionRepository
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-H6UQ71S\\SQLEXPRESS;Data Source=DESKTOP-H6UQ71S\\SQLEXPRESS;Initial Catalog=SOLID;User ID=solid;Password=solid");

        public SqlConnection OpenConnection()
        {
            connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
