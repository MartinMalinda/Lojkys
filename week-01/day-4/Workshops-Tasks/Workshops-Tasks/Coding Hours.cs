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

            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int attendanceHoursDay = 6;
            int daysInSemester = 17 * 5;

            Console.Write("Student will code in semester: ");
            Console.WriteLine(attendanceHoursDay*daysInSemester + " hours");


            int WorkingHours = 52;
            int CodingHours = 30;

            Console.Write("Percentages of coding in the week is: ");
            Console.WriteLine(30 * 100 / 52 + "%");

            Console.ReadLine();
           
        }
    }
}
