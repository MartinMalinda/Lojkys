using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAble
{
    class Sponsor : Person
    {
        private string company = "Google";
        private int hiredStudents = 0;

        public Sponsor()
        {

        }
        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {

        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudents} students so far.");
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
        public void Hire()
        {
            hiredStudents += 1;
        }
    }
}
