using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Write two numbers");

            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());

            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("First number is bigger: {0}", FirstNumber);
            }
            else if (SecondNumber > FirstNumber)
            {
                Console.WriteLine("Second number is bigger than the first one: {0}", SecondNumber);
            }
            Console.ReadLine();
        }
    }
}