using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.WriteLine("What is the distance in miles?");
            double distanceInMiles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And your distance in kilometers is "+ distanceInMiles * 1.609344 + " km");

            Console.ReadLine();

        }
    }
}
