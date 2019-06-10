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
        SqlConnection connection = new SqlConnection("Connection String");

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
