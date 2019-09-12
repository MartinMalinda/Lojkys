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
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            int inputNumber;

            Console.WriteLine("Write a number: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                    Console.WriteLine("Even");           
            }
                Console.ReadLine();
            
        }
    }
}
