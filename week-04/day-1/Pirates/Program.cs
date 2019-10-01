using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship blackPearl = new Ship();
            Pirate pirateOne = new Pirate("Jack", PirateType.Captain);

            pirateOne.Work(pirateOne);
            pirateOne.ToString(pirateOne);

            blackPearl.AddPirate(new Pirate("William", PirateType.WoodenLeg));
            blackPearl.AddPirate(new Pirate("John", PirateType.Captain));
            blackPearl.AddPirate(new Pirate("Murphy", PirateType.WoodenLeg));
            blackPearl.AddPirate(new Pirate("James", PirateType.WoodenLeg));

            blackPearl.GetPoorPirates();

            Console.ReadLine();
        }
    }
}
