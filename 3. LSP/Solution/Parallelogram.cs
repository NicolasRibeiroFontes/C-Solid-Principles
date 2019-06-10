using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.Solution
{
    public class Parallelogram
    {
        protected Parallelogram(int heigth, int width)
        {
            Heigth = heigth;
            Width = width;
        }

        public double Heigth { get; private set; }
        public double Width { get; private set; }
        public double Area { get { return Heigth * Width; } }
    }
}
