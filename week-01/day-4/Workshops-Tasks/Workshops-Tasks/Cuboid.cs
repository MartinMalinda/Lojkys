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

            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double height = 10;
            double width = 20;
            double lenght = 30;

            Console.WriteLine("Surface area is: " + 2*(lenght*width + height*width + lenght*height));
            Console.WriteLine("Volume is: " + height*width*lenght);

            Console.ReadLine();

        }
    }
}
