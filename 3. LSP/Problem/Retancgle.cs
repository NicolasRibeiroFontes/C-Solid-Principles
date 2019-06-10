using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.Problem
{
    public class Retancgle
    {
        public virtual double Heigth { get; set; }
        public virtual double Width { get; set; }
        public double Area { get { return Heigth * Width; } }
    }
}
