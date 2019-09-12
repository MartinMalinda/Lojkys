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
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            int numberOfChickens;
            int numberOfPigs;

            Console.WriteLine("Hello, farmer! How many chickens, do you have?");
            numberOfChickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And how many pigs?");
            numberOfPigs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You as a farmer have {0} chickens and {1} pigs.", numberOfChickens, numberOfPigs);
            Console.WriteLine("Do you know how many legs they have together?");
            Console.WriteLine("I'll tell you!");
            numberOfChickens *= 2;
            numberOfPigs *= 4;

            Console.WriteLine("It's {0}!", numberOfChickens + numberOfPigs); ;

            Console.ReadLine();

        }
    }
}
