using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Reservation : IReservation
    {
        public Reservation()
        {

        }
        public void MyReservation()
        {
            Console.WriteLine($"Booking# {GetCodeBooking()} for {GetDowBooking()}");
        }
        public string GetCodeBooking()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }   
        public string GetDowBooking()
        {
            string[] days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            var random = new Random();         
            return days[random.Next(days.Length)];          
        }
    }
}
