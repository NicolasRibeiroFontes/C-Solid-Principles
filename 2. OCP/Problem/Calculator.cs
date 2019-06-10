using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP.Problem
{
    public class Calculator
    {
        public int Execute(int value1, int value2, Operation operation)
        {
            int result = 0;

            if (operation == Operation.Sum)
                result =  value1 + value2;

            if (operation == Operation.Subtract)
                result = value1 - value2;

            return result;
        }
    }
}
