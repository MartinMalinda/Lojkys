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

            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int dayInSeconds = 24 * 60 * 60;
            int secondsNow = (14 * 60 * 60) + (34 * 60) + 42;

            Console.WriteLine(dayInSeconds - secondsNow);
            Console.ReadLine();

        }
    }
}
