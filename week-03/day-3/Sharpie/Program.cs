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
            Sharpie tereza = new Sharpie("Pink", 300);

            tereza.Use();

            Console.WriteLine(tereza.inkAmount);

            Console.ReadLine();
        }
    }
}
