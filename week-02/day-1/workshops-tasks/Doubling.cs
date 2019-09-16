using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            

            int baseNum = 123;
            Doubling(baseNum);
            
            Console.ReadLine();
            
        }
        public static void Doubling(int x)
        {
            x = x * 2;
            Console.WriteLine(x);
        }
    }
}
