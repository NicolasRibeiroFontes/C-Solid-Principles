using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.Solution.Interfaces
{
    public interface IUserRepository
    {
        void Save(User user);
    }
}
