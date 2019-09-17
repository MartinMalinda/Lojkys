using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            map.Add(97, "a");
            map.Add(98, "b");
            map.Add(99, "c");
            map.Add(65, "A");
            map.Add(66, "B");
            map.Add(67, "C");
            Console.WriteLine("PRINTING KEYS: ");
            foreach (var key in map.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("PRINTING VALUES: ");

            foreach (var value in map.Values)
            {
                Console.WriteLine(value);
            }
            //Add value D with the key 68
            Console.WriteLine("...........................");
            map.Add(68, "D");
            Console.WriteLine("...........................");
            Console.WriteLine("There is " + map.Count + " key-value pairs.");
            
            Console.WriteLine(map.ContainsKey(99));

            Console.WriteLine("Getting Key Value");
          
            Console.WriteLine(map[99]);
            Console.WriteLine("...........................");
            Console.WriteLine(map.Remove(97));

            Console.WriteLine("Is there an associated value with key 100 or not?");
            Console.WriteLine(map.ContainsKey(100));

            Console.WriteLine("...........................");
            map.Clear();

            if (map.Count == 0)
            {
                Console.WriteLine("The dictionary is empty");
            }
            else
            {
                Console.WriteLine("You made a mistake");
            }
            Console.ReadLine();
        }
    }
}
