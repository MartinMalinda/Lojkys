using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //var food = new List<string> { "apple", "banana" };
            //food.AddRange(new string[] { "avocado", "pie" });

            List<string> ListA = new List<string>(); //new List<string> { "apple", "banana" };
            ListA.AddRange(new string[] { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" });
            List<string> ListB = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            //List<string> ListB = new List<string>();
            //ListB.AddRange(ListA);

            Console.WriteLine(ListA.Contains("Durian")); //TRUE OR FALSE   

            ListB.Remove("Durian");

            ListA.Insert(3, "Kiwifruit"); //YES IT WORKS 

            foreach (var item in ListA)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n-------------------------");

            Console.WriteLine(ListA.Equals(ListB));

            Console.WriteLine(ListA.IndexOf("Avocado"));

            Console.WriteLine(ListB.IndexOf("Durian")); //DOES NOT EXISTS -1

            ListB.Add("Passion Fruit and Pomelo");

            Console.WriteLine(ListA[2]);

            Console.ReadLine();

        }
    }
}
