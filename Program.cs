using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below option");
            Console.WriteLine("1.EvenOrOdd\n2.PrimeOrNot\n3.ReverseNumber\n4.ArrayConcept\n5.Factorial");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Please enter integer number to find even or odd");
                    int input = Convert.ToInt32(Console.ReadLine());
                    string res = EvenOrOddNumbers.FindEvenOrOdd(input);
                    Console.WriteLine(res);
                    break;
                case 2:
                    Console.WriteLine("Please enter integer number to find prime or not");
                    input = Convert.ToInt32(Console.ReadLine());
                    PrimeOrNot.FindPrimeNumber(input);
                    break;
                case 3:
                    Console.WriteLine("Please enter integer value");
                    input = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.FindReverseNumber(input);
                    break;
                case 4:
                    ArrayConcept arrayConcept = new ArrayConcept();
                    arrayConcept.ReadArrayElements();
                    arrayConcept.DisplayArrayElements();
                    break;
                case 5:
                    Console.WriteLine("Please Enter number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    //Factorial.FindFactorial(n);
                    Console.WriteLine("Factorial:" + Factorial.FindFactorialUsingRecursion(n));
                    break;
                default:
                    Console.WriteLine("Please choose within given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
