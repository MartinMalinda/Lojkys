using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            int firstNum = 0;

            Console.WriteLine("Give me a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Sum(input);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Sum (int x)
        {
            int abra = 0;

            for (int i = 1; i <= x; i++)
            {
                abra += i;
                
            }
            Console.WriteLine(abra);
        }
    }
}
