using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Mul
    {
        public int MulMe(int a, int b)
        {
            int totalValue;
            Console.WriteLine("You Are going to Multiply two  no");
            totalValue = (a * b);
            return totalValue;
        }

        public int DividwMe(int a, int b)
        {
            int totalValue;
            Console.WriteLine("You Are going to Divide two  no");
            totalValue = (a / b);
            return totalValue;

        }
    }
}
