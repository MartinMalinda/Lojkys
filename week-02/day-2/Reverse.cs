using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));

            Console.ReadLine();
        }
        public static string Reverse (string OldText)
        {
            char[] abcd = OldText.ToCharArray();
            Array.Reverse(abcd);
            return new string (abcd);

        }
    }
}
