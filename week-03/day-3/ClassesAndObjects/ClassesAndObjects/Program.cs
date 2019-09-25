﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));

            fleet.GetThings()[2].Complete();
            fleet.GetThings()[3].Complete();


            for (int i = 0; i < fleet.GetThings().Count; i++)
            {
                if (fleet.GetThings()[i].GetBoolStatus() == true)
                {
                    Console.WriteLine($"{i + 1}. [x] {fleet.GetThings()[i].GetName()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {fleet.GetThings()[i].GetName()}");
                }
                
            }

            Console.ReadLine();
        }
    }
}
