using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.Solution.Interfaces
{
    public interface IEmailService
    {
        void SendMail(string name, string email, string body);
    }
}
