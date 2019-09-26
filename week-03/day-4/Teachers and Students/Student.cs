using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Height { get; private set; }

        public void Informations(string name, int age, double height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }

        public void Learn()
        {
            Console.WriteLine($"Student {Name} is learning something new");
        }
        public void Question(Teacher teacher)
        {
            teacher.Asnwer(teacher.name);    
        }
    }
}
