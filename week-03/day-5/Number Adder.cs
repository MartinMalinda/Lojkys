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
            Console.WriteLine("Give me some number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum up from zero to the number is: {NumberAdder(a)}");

            Console.ReadLine();
        }
        public static int NumberAdder(int n)
        {
            //if (n < 1)
            //{
            //    return Console.WriteLine("Oops, you need to put bigger number");
            //}
            if (n == 1)
            {
                return 1;
            }
            return n + NumberAdder(n - 1);
        }
    }
}
