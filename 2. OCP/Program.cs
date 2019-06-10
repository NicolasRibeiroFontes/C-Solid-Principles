//using _2.OCP.Problem;
using _2.OCP.Solution;
using System;

namespace _2.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem
            //Calculator calculator = new Calculator();
            //calculator.Execute(1, 2, Operation.Sum);
            #endregion

            #region Solution
            Calculator calculator = new Sum();
            calculator.Execute(1, 2);
            calculator = new Subtract();
            calculator.Execute(5, 3);
            #endregion
        }
    }
}
