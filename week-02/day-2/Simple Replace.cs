using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            //string newValue = example.Replace("dishwasher", "galaxy"); 2 WAY WAY WAY WAY WAY 

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected output: In a galaxy far far away

            Console.WriteLine(example.Replace("dishwasher", "galaxy"));
            //Console.WriteLine(newValue); 2 WAY WAY WAY WAY WAY 

            Console.ReadLine();
        }
    }
}
