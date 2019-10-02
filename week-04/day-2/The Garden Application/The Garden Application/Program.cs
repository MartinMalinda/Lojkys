using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden gardenOne = new Garden();
            gardenOne.AddFlower(new Flowers(Flowers.FlowerType.yellow));
            gardenOne.AddFlower(new Flowers(Flowers.FlowerType.blue));
            
            Console.WriteLine();

            gardenOne.AddTree(new Trees(Trees.TreeType.orange));
            gardenOne.AddTree(new Trees(Trees.TreeType.purple));

            gardenOne.WaterTheGarden(0);
            Console.WriteLine();
            gardenOne.WaterTheGarden(40);
            Console.WriteLine();
            gardenOne.WaterTheGarden(70);

            
            Console.ReadLine();
        }
    }
}
