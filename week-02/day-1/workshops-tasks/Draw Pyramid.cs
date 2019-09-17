using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int numberOfStars = 1;
            int numberOfSpaces = rows - 1;

            for (int i = 0; i < rows; i++)
            {
                // PRINT ROW

                // PRINT SPACES
                for (int spaceI = 0; spaceI < numberOfSpaces; spaceI++)
                {
                    Console.Write(" ");
                }

                // PRINT STARS
                for (int starI = 0; starI < numberOfStars; starI++)
                {
                    Console.Write("*");
                }

                numberOfSpaces--;
                numberOfStars = numberOfStars + 2;
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
