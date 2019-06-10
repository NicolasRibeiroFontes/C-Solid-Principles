using System.Data.SqlClient;

namespace SRP.Problem
{
    public class User
    {
        string connectionString = @"Your Connection String";

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
