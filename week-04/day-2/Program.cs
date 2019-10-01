using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person personLukas = new Person("Lukas", 23, "Male");
            //personLukas.Introduce();
            //personLukas.GetGoal();
            //Console.WriteLine();

            //Student studentPedro = new Student("Pedro",52,"Male","Kelly Walsh High School");          
            //studentPedro.SkipDays(3);
            //studentPedro.Introduce();
            //Console.WriteLine();

            //Mentor esy = new Mentor("Esy", 30, "Male", Mentor.Level.senior);
            //esy.Introduce();
            //Console.WriteLine();

            //Sponsor microsoft = new Sponsor("Bill Gates", 80, "Male", "Microsoft");
            //microsoft.Introduce();
            //microsoft.Hire();
            //microsoft.Hire();


            //Console.ReadLine();

            var people = new List<Person>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            var student = new Student();
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", Mentor.Level.intermediate);
            people.Add(gandhi);
            var mentor = new Mentor();
            people.Add(mentor);
            var sponsor = new Sponsor();
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.Info();

            Console.ReadLine();
        }
    }
}

