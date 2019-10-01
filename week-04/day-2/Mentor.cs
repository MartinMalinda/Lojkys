using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Mentor : Person
    {
        public enum Level { junior, intermediate, senior };
        public Level TypeOfLevel { get; private set; }
        public Mentor()
        {

        }
        public Mentor(string name, int age, string gender, Level level):base(name, age, gender)
        {
            TypeOfLevel = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine($"Educate brilliant {Mentor.Level.junior} software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {TypeOfLevel} mentor.");
        }
    }
}
