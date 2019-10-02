using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Garden : Plant
    {
        private List<Flowers> flowers = new List<Flowers>();
        private List<Trees> trees = new List<Trees>();
        
        
        public void AddFlower(Flowers flower)
        {
            flowers.Add(flower);
        }
        public void AddTree(Trees tree)
        {
            trees.Add(tree);
        }
        public void PlantsInGarden()
        {
            Console.WriteLine("In garden is: ");
            foreach (var flower in flowers)
            {
                Console.Write(flower.Type + " flower and ");
                Console.WriteLine(flower.WaterStorage + " water storage");
            }
            foreach (var tree in trees)
            {
                Console.WriteLine(tree.Type + " tree");
            }
        }
        public void WaterTheGarden(double AmountOfWateringWater)
        {
            Console.WriteLine($"Watering with {AmountOfWateringWater}");
            AmountOfWateringWater /= 4;
            foreach (var flower in flowers)
            {
                if (flower.WaterStorage < 5)
                {
                    WaterFlower(AmountOfWateringWater);
                    Console.WriteLine($"The {flower.Type} Flower needs water");
                }
                else if (flower.WaterStorage > 5)
                {
                    Console.WriteLine($"The {flower.Type} Flower doesn't need water");
                }
            }
            foreach (var tree in trees)
            {
                if (tree.WaterStorage < 10)
                {
                    WaterTree(AmountOfWateringWater);
                    Console.WriteLine($"The {tree.Type} Tree needs water");
                }
                else
                {
                    Console.WriteLine($"The {tree.Type} Tree doesn't need water");
                }
            }
        }
        private void WaterTree(double amountOfWateringWater)
        {
            foreach (var tree in trees)
            {
                tree.AddingWaterStorageTree(amountOfWateringWater / (10 / 4.0), trees);
            }
        }
        private void WaterFlower(double AmountOfWateringWater)
        {
            foreach (var flower in flowers)
            {
                flower.AddingWaterStorageFlower(AmountOfWateringWater / (10 / 7.5), flowers);
            }
        }
    }
}
