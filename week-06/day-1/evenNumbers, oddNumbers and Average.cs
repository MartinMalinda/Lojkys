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
            //Write a LINQ Expression to get the even numbers from the following array:

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            evenNumbers.ToList().ForEach(n => Console.WriteLine(n));

            var evenNumbersQuery = from n in numbers
                                   where n % 2 == 0
                                   select n;

            Console.WriteLine();
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            var averageOfOddNumbers = numbers.Where(n => n % 2 != 0).Average();
            Console.WriteLine(averageOfOddNumbers);

            Console.ReadLine();
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
