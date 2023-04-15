using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class ReverseNumber
    {
        public static void FindReverseNumber(int num)
        {
            
            int result = 0;
            int rem = 0;
            while(num!=0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
        }
    }
}
