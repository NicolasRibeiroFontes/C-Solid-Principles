using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Problem
{
    public class User
    {
        string connectionString = @"Server=.\sqlexpress;Database=SOLID;Trusted_Connection=True;";

        public User()
        {}

        public string Name { get; set; }
        public string Email { get; set; }

        public bool SaveUser()
        {
            if (Name == "" || Email == "" || !Email.Contains("@"))
                return false;

            string sql = "INSERT INTO [User](Name, Email) VALUES(@name, @email)";

            SqlConnection connection = new SqlConnection(connectionString);            
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.ExecuteNonQuery();

            connection.Close();

            return true;
        }
    }
}
