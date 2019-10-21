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
            char[] text = { 'k', 'r', 'o', 'k', 'o', 'd', 'y', 'l' };
            //Write a LINQ Expression to convert a char array to a string.

            var result = String.Join("", text.Select(ch => ch.ToString()));
            Console.WriteLine(result);

            var result2 = from ch in text
                          select String.Join("", text.Select(c => c.ToString()));

            Console.ReadLine();
        }
    }
}
