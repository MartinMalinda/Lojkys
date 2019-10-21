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
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "ANKARI" };
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            var result = cities.Where(w => w.StartsWith("A") && w.EndsWith("I")).ToList();
            result.ForEach(w => Console.WriteLine(w));

            var result2 = from w in cities
                          where w.StartsWith("A") && w.EndsWith("I")
                          select w;
            result2.ToList().ForEach(w => Console.WriteLine(w));

            Console.ReadLine();
        }
    }
}
