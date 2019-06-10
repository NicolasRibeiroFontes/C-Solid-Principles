using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ICP.Problem
{
    interface IRegisterService
    {
        bool Valid();

        bool Register();

        void SendMail();
    }
}
