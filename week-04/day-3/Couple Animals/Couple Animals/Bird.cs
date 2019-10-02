using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couple_Animals
{
    class Bird : Animal
    {
        public Bird()
        {

        }
        public Bird(AnimalType name, int age, GenderType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public override void WantChild()
        {
            Console.WriteLine($"{Name}, want a child from an egg!");
        }
        public override void Greet()
        {
            Console.WriteLine($"Hello, I'm {Name} a {Age} years old. My gender is {Gender}");
        }
        public override void Move()
        {
            
        }
        public override void Sound()
        {
            
        }      
    }
}
