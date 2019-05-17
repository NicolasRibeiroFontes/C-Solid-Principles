using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class UserService
    {
        ConnectionRepository connection = new ConnectionRepository();
        UserRepository userRepository = new UserRepository();

        public bool SaveUser(User user)
        {
            if (!ValidUser(user))
                return false;

            connection.OpenConnection();

            userRepository.SaveUser(user);

            connection.CloseConnection();

            return true;
        }
        
        private bool ValidUser(User user)
        {
            if (user.Name == "" || user.Email == "" || !user.Email.Contains("@"))
                return false;

            return true;
        }
    }
}
