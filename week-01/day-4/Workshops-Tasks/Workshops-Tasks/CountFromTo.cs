using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Give me two numbers");

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And?");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 <= num1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else 
            {
                Console.WriteLine();
                while (num2 > num1)
                {
                    
                    Console.WriteLine(num1);
                    num1++;
                }
            }
            Console.ReadLine();
        }
    }
}