using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Teacher teacher = new Teacher();
            Student student1 = new Student();

            teacher.AddName("Greta");
            student1.Informations("Marek", 20, 1.82);
            //Console.WriteLine($"Students name is {student1.Name} he is {student1.Age} years old and is {student1.Height} tall");
            //teacher.Asnwer(teacher.name);
            //student1.Learn();

            teacher.Teach(student1);

            student1.Question(teacher);

            Console.ReadLine();
        }
    }
}
