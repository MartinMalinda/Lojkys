using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyAble
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter vehicle = new Helicopter();
            vehicle.Name = "Boeing";
            vehicle.Land();
            Console.WriteLine(vehicle.Name);

            var vehicle2 = new Helicopter();
            vehicle2.Fly();

            Console.ReadLine();
        }
    }
}
