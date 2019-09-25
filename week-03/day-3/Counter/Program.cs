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
            Counter counter = new Counter(200);
            Console.WriteLine(counter.Value);
            counter.Add(30);
            Console.WriteLine(counter.Value);
            counter.Add();
            Console.WriteLine(counter.Value);
            counter.Reset();
            Console.WriteLine(counter.Value);

            //Console.WriteLine(counter.Reset(100));



            Console.ReadLine();
        }
    }
}
