using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("William");
            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count);
            Console.WriteLine(names.Contains("William"));

            if (names.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("The list has [" + names.Count + "] elements");
            }

            Console.WriteLine(names.Count);

            Console.WriteLine(names[2]);
            Console.WriteLine("..................................");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("..................................");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + names[i]);
            }

            Console.WriteLine("..................................");
            names.RemoveAt(1);
            Console.WriteLine("John was deleted");
            Console.WriteLine("..................................");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("............REVERSE......................");

            names.Reverse();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("............REVERSE...222...................");

            for (int i = names.Count; i > 0; i--)
            {
                Console.WriteLine(names[i-1]);
            }


            Console.WriteLine("..................................");
            names.Clear();
            if (names.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("The list has [" + names.Count + "] elements");
            }

            Console.ReadLine();
        }
    }
}
