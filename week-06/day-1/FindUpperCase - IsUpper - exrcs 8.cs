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
            string text = "KarlkuAbezelapREsLoku";
            //Write a LINQ Expression to find the uppercase characters in a string.

            var result = text.Where(ch => char.IsUpper(ch)).ToList();
            result.ForEach(ch => Console.Write(ch));

            Console.WriteLine();

            var result2 = from ch in text
                          where char.IsUpper(ch)
                          select ch;
            result2.ToList().ForEach(ch => Console.WriteLine(ch));

            Console.ReadLine();
        }
    }
}
