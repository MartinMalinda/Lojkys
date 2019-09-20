using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Function
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

            int[,] matrix = new int [4, 4];

            int lower = matrix.GetLowerBound(0);
            int upper = matrix.GetUpperBound(0);

            for (int i = lower; i < upper; i++)
            {
                matrix[i, i] = 1;
            }
            for (int i = 0; i <= upper; i++)
            {
                for (int j = 0; j <= upper; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
           

            Console.ReadLine();
        }
    }
}
