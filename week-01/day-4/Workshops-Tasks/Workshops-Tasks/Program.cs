using System;
using System.Collections.Generic;

namespace Workshops_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also 
            foreach (var item in fleet.Things)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
