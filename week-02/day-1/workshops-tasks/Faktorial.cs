using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Give me a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Factorio(input);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Factorio (int x)
        {
            int abra = 1;

            for (int i = 1; i <= x; i++)
            {
                abra *= i;
            }
            Console.WriteLine();
            Console.WriteLine(abra);
        }
    }
}
