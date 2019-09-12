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
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            //int temp = a;
            //a = b;
            //b = temp;

            //(a, b) = (b, a);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
           
        }
    }
}
