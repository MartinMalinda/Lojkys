using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>
            { "Eggs", "milk", "fish", "apples", "bread", "chicken" };

            Console.WriteLine("Do we have a milk on the list?");
            if (true)
            {
                shoppingList.Contains("milk");
                Console.WriteLine("Yes");
            }
            

            Console.WriteLine("Do we have a banana on the list?");
            if (true)
            {
                shoppingList.Contains("banana");
                Console.WriteLine("No");
            }
            


            Console.ReadLine();

        }
    }
}
