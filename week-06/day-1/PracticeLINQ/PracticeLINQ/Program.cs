using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = File.ReadAllText(@"./text.txt");

            var result = fileText.ToLower().Replace("\r", "").Replace("\n", "").Split(' ').GroupBy(w => w).OrderByDescending(w => w.Count()).Take(10).ToList();
            result.ForEach(w => Console.WriteLine(w.Key + " : " + w.Count()));


            //dictionary.ContainsKey(word))
            Console.ReadLine();
        }
    }
}
