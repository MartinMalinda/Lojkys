using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Plant
    {
        public double WaterStorage { get; private set; } = 0;
        //private new List<Plant> waterFlowers;
        //private new List<Trees> waterTrees;
      
        public Plant()
        {

        }
        //public void SendingLists(List<Flowers> flowers, List<Trees> trees)
        //{
        //    waterFlowers = flowers;
        //    waterTrees = trees;
        //}
        public void AddingWaterStorageTree(double waterStorage, List<Trees> trees)
        {         
            foreach (var tree in trees)
            {
                tree.WaterStorage += waterStorage;
            }           
        }
        public void AddingWaterStorageFlower(double waterStorage, List<Flowers> flowers)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("I'm watering");
                flowers[i].WaterStorage += waterStorage;
            }              
        }
        public void ResetWater()
        {
            this.WaterStorage = 0;
        }
    }
}
