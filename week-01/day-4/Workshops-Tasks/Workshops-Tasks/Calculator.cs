using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            // Get the first number:
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            // int number2 = ...

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

            // Get the operation from standard input:
            string operation = Console.ReadLine();
            double result = 0.0;

            switch (operation)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;
                default:
                    Console.WriteLine("This is not a right input");
                    break;
            }

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

            

            Console.WriteLine($"The result of the calculation is {result}");

            Console.ReadLine();
        }
    }
}