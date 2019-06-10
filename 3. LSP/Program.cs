using _3.LSP.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad = new Square()
            {
                Heigth = 10,
                Width = 5
            };

            GetRetancgleArea(quad);
        }

        private static void GetRetancgleArea(Retancgle retancgle)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(retancgle.Heigth + " * " + retancgle.Width);
            Console.WriteLine();
            Console.WriteLine(retancgle.Area);
            Console.ReadKey();
        }
    }
}
