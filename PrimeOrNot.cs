using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class PrimeOrNot
    {
        public static void FindPrimeNumber(int number)
        {
            int factors = 0;
            //2,3,5,7,11,13,17...
            for(int i = 1; i <= number; i++)
            {
                if(number%i==0)
                {
                    factors++;
                }
            }
            if(factors==2)
                Console.WriteLine("{0} is prime number", number);
            else
                Console.WriteLine("{0} is not a prime number", number);
        }
    }
}
