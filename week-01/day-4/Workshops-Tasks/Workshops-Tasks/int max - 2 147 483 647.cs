using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(42);

            Console.WriteLine(3.1415);

            // maximum and minimum value
            // a simple integer is represented in 4 bytes (32bit)

            // maximum value:  2 147 483 647
            int a = 2147483647;

            Console.WriteLine(a);

            // minimum value: -2 147 483 648
            Console.WriteLine(-2147483648);

            Console.WriteLine("How are you?");
            string mood = Console.ReadLine();
            Console.WriteLine("Gooood");
            Console.ReadLine();
        }    
    }
}
