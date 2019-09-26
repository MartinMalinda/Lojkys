using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Teacher
    {
        public string name;
        public void AddName(string name)
        {
            this.name = name;
        }

        public void Asnwer(string teachersName)
        {
            Console.WriteLine($"Teacher called {teachersName} is answering a question");
        }
        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
