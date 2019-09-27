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
            //Given a non-negative integer n, return the sum of its digits recursively (without loops).
            //Divide(/) by 10 removes the rightmost digit(e.g. 126 / 10 is 12).
            //Mod (%) by 10 yields the rightmost digit (e.g. 126 % 10 is 6)

            Console.WriteLine(SummDigits(156));

            Console.ReadLine();
        }
        public static int SummDigits(int n)
        {
            if (n != 0)
            {
                return (n % 10 + SummDigits(n / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
