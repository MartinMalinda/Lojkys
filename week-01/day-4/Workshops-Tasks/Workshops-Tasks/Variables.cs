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
            // string
            string greeting = "Hello my friend";
            Console.WriteLine(greeting);

            // boolean
            bool running = true;
            Console.WriteLine(running);

            // whole number
            int a = 11;
            Console.WriteLine(a);

            // floating point number
            double pi = 3.141592;
            Console.WriteLine(pi);

            // declaring a variable
            int number;

            // assigning a variable, (define its value)
            number = 12;

            Console.WriteLine(number);
            // mutate a variable, (redefine its value)
            number = 23;

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
