using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class EvenOrOddNumbers
    {
        public static string FindEvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Given number is even number";
            else
                return "Given number is odd number";
        }
    }
}
