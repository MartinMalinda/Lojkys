using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] matrix = new int [8, 8];

            for (int x = 0; x < 8; x++)
            {
                matrix[x, x] = 1;
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
