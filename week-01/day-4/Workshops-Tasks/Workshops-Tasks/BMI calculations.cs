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
            // Print the Body mass index (BMI) based on these values

            //Example: Weight = 68 kg, Height = 165 cm (1.65 m)
            //Calculation: 68 ÷ (1.65)2 = 24.98

            double massInKg = 87;
            double heightInM = 1.80;

            Console.WriteLine("BMI = " + massInKg / heightInM * 2);

            Console.ReadLine();
        }
    }
}
