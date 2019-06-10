using _5.DIP.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.Solution
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public UserService(IUserRepository userRepository, IEmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public string Save(User user)
        {
            _userRepository.Save(user);

            _emailService.SendMail(user.Name, user.Email, "Registered Successful");

            return "Success!";
        }

    }
}
