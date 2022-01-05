using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the problem The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1 and the factorial of zero, 0, is defined as being 1. 
            // https://live.withcode.uk/alevel/?id=1 Solve this using both loops and recursion
            Console.WriteLine("welcome to factorial finder");
            int inp = Int32.Parse(Console.ReadLine());

            int factorial(int input)
            {

                int x = input;
                if (input == 0)
                {
                    return 1;
                }


                if (input > 0)
                {

                }


            }

            Console.WriteLine(factorial(inp));


        }
    }
}
