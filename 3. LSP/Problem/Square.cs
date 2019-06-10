using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.Problem
{
    public class Square: Retancgle
    {
        public override double Heigth
        {
            set { base.Heigth = base.Width = value; }
        }

        public override double Width
        {
            set { base.Heigth = base.Width = value; }
        }
    }
}
