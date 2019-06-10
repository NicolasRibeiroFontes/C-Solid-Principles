using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.Solution
{
    public class Square: Parallelogram
    {
        public Square(int heigth, int width)
            : base(heigth, width)
        {
            if (width != heigth)
                throw new ArgumentException("Both side need are equal");
        }
    }
}
