using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.Problem
{
    public class UserService
    {
        public string Save(User user)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.Save(user);

            EmailService emailService = new EmailService();
            emailService.SendMail(user.Name, user.Email, "Registered Successful");

            return "Success!";
        }
    }
}
