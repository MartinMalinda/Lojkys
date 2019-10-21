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
            string[] names = new string[] { "lukas", "pepa", "vlada", "martin", "marek", "lukas", "pavel", "pepa", "lukas", "honza" };
            //Write a LINQ Expression to find the frequency of characters in a given string.

            var result = names.GroupBy(w => w).ToList();
            result.ForEach(w => Console.WriteLine(w.Key + " : " + w.Count()));
            Console.WriteLine();
            var result2 = from word in names
                          group word by word into g
                          select g;
            result2.ToList().ForEach(w => Console.WriteLine(w.Key + " : " + w.Count()));
            Console.ReadLine();
        }
    }
}
