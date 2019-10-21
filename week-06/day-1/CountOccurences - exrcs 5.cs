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
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            var result = numbers.GroupBy(n => n).ToList();
            result.ForEach(n => Console.WriteLine(n.Key + " : " + n.Count()));

            var result2 = from number in numbers
                          group number by number into g
                          select new { g.Key, Count = g.Count() };

            Console.ReadLine();
        }
    }
}
