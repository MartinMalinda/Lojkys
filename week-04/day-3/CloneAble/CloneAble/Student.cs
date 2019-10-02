using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAble
{
    class Student : Person, ICloneable
    {
        private string previousOrganization = "The School Of Life";
        private int skippedDays = 0;
        public Student()
        {

        }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public object Clone()
        {
            return this;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

    }
}
