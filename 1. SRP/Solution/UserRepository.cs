using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class UserRepository
    {
        SqlCommand cmd = new SqlCommand();

        public void SaveUser(User user)
        {
            cmd.CommandText = "INSERT INTO User(Name, Email) VALUES(@name, @email)";
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.ExecuteNonQuery();
        }
    }
}
