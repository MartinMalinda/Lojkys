using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            var moreThan20 = numbers.Where(n => n * n > 20).ToList();
            moreThan20.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
