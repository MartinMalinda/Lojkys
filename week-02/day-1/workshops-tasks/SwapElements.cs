using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = { "first", "second", "third" };

            (a, b) = (b, a)

            string temp;
            temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach (var ab in abc)
            {
                Console.WriteLine(ab);
            }

            Console.ReadLine();
        }
    }
}
