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
            //true, false
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine();

            //negation
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine();

            //and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine();

            //or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.ReadLine();
        }    
    }
}
