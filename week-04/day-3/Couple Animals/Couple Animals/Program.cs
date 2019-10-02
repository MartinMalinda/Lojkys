using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couple_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird(Animal.AnimalType.Parrot, 4, Animal.GenderType.Female);
            bird.Greet();
            var reptile = new Reptile(Animal.AnimalType.Frog, 5, Animal.GenderType.Female);
            var reptile2 = new Reptile(Animal.AnimalType.Crocodile, 3, Animal.GenderType.Male);
            var mammal = new Mammal(Animal.AnimalType.Tiger, 7, Animal.GenderType.Male);

            Console.WriteLine("Who want baby?");
            bird.WantChild();
            Console.WriteLine();
            reptile.WantChild();
            Console.WriteLine();
            reptile2.WantChild();
            Console.WriteLine();
            mammal.WantChild();

            Console.ReadLine();
        }
    }
}
