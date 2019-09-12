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
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            Console.WriteLine("What is your first and last name?");
            string YourName = Console.ReadLine();
            
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is your height in meters?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Here is your data");
            Console.WriteLine(YourName);
            Console.WriteLine(age);          
            Console.WriteLine(height);

            Console.ReadLine();
        }
    }
}
