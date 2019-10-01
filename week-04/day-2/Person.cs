using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Person
    {
        public string Name { get; private set; } = "Jane Doe";
        public int Age { get; private set; } = 30;
        public string Gender { get; private set; } = "female";

        public Person()
        {

        }
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender}.");
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment");
        }
    }
}
