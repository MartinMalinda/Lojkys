using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            int cheat = 0;

            while (cheat <= 100)
            {
                Console.WriteLine(cheat++ + " I won't cheat on the exam");
            }

            int b = 0;
            for (b = 0; b <= 100; b++)
            {
                Console.WriteLine("\n\n I won't cheat on the exam");
            }

            int c = 0;
            do
            {
                Console.WriteLine(c++);
            } while (c <= 100);

            Console.ReadLine();
        }
    }
}