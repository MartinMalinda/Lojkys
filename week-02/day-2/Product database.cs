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
            Dictionary<string, int> ProductsAndPrices = new Dictionary<string, int>();
            ProductsAndPrices.Add("Eggs", 200);
            ProductsAndPrices.Add("Milk", 200);
            ProductsAndPrices.Add("Fish", 400);
            ProductsAndPrices.Add("Apples", 150);
            ProductsAndPrices.Add("Bread", 50);
            ProductsAndPrices.Add("Chicken", 550);

            Console.Write("How much is the fish? - ");
            Console.WriteLine(ProductsAndPrices["Fish"] + " CZK");

            Console.Write("Which product is the most expensive? ");
            //foreach (var maxPrice in ProductsAndPrices.Values)
            //{
                //if (maxPrice == ProductsAndPrices.Values.Max())
                //{
                   // Console.WriteLine();
                //}
            //}

            var keys = from entry in ProductsAndPrices
                       where entry.Value == ProductsAndPrices.Values.Max()
                       select entry.Key;

            foreach (var key in keys)
                Console.WriteLine(key);

            Console.Write("The Average price is: ");
            double average = ProductsAndPrices.Values.Average();
            Console.WriteLine(Math.Round(average));
            Console.Write("Can we buy something for 125? ");
            Console.WriteLine(ProductsAndPrices.Values.Contains(125));
            Console.Write("What is the cheapest product? ");
            var lowest = from entry in ProductsAndPrices
                       where entry.Value == ProductsAndPrices.Values.Min()
                       select entry.Key;

            foreach (var key in lowest)
                Console.WriteLine(key);

            Console.WriteLine("How many products is below 300? ");

            int i = 0;
            foreach (var item in ProductsAndPrices.Values)
            {
                if (item < 300)
                {
                    i++;
                }               
            }
            Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
