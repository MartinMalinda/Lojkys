using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyAble
{
    class Helicopter : Vehicle, Flyable
    {
        public Helicopter()
        {

        }
        public Helicopter(string name, int age, string type)
        {
            this.Age = age;
            this.Name = name;
            this.Type = type;
        }
        public void Fly()
        {
            Console.WriteLine("I can Fly!");
        }
        public void Land()
        {
            Console.WriteLine("I'm landing");
        }
        public void TakeOff()
        {
            Console.WriteLine("Taking Off");
        }
    }
}
