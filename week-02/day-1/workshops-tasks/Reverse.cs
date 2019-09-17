using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            int[] abc = new int[5];

            Array.Reverse(aj);

            for (int i = 0; i < aj.Length; i++)
            {
                abc[i] = aj[((aj.Length) - 1) - i];
                //Console.Write(aj[i] + " ");                           
            }
            //for (int i = 0; i < aj.Length; i++)
            //{
               // abc[i] = aj[i];
           // }
            Console.WriteLine();

            foreach (var a in abc)
            {
                Console.Write(a + " ");
            }

            Console.ReadLine();

        }

    }
}
