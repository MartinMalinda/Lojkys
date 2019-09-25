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
            Animal cat = new Animal();
            Animal dog = new Animal();
            cat.Drink();

            Console.WriteLine(cat.thirst);

            Console.ReadLine();
        }
        
    }
}
