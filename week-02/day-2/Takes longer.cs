using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            int indexIt = quote.IndexOf("It");

            Console.WriteLine(indexIt); // = 18

            string newQuote = quote.Insert(indexIt + 3, "always takes longer than ");

            Console.WriteLine(newQuote);

            Console.ReadLine();
        }
    }
}
