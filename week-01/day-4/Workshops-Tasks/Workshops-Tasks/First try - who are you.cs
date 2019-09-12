using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + FirstName + ".");
            Console.WriteLine("And how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");
            Console.ReadLine();
        }
    }
}
