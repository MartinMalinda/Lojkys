using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Animal
    {
        public int hunger { get; set; } = 50;
        public int thirst { get; set; } = 50;

        public Animal()
        {
            
        }
        public void Eat()
        {
            hunger -= 1;
        }
        public void Drink()
        {
            thirst -= 1;
        }
        public void Play()
        {
            hunger -= 1;
            thirst -= 1;
        }
    }
}
