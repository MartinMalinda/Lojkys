using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));

            Console.ReadLine();
        }

        public static int Fibonacci (int n)
        {
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
