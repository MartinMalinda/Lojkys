using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500

            int a = 1;

            for (a = 1; a < 500; a++)
            {
                if (a%2 == 1)
                {
                    Console.WriteLine(a);
                }
               
            }
            Console.ReadLine();
        }
    }
}