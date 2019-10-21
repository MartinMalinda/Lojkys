using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class Program
    {
        public delegate void Greet(string name);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            var squared = numbers.Where(n => n > 0).Select(n => n * n).ToList();
            squared.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
