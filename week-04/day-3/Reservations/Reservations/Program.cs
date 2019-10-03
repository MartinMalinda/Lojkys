using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Reservation> reservations = new List<Reservation>();
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            reservations.Add(new Reservation());
            Console.WriteLine();
            Reservation reservation1 = new Reservation();
            Reservation reservation2 = new Reservation();
            Reservation reservation3 = new Reservation();
            Reservation reservation4 = new Reservation();

            reservation1.MyReservation();
            reservation2.MyReservation();
            reservation3.MyReservation();
            reservation4.MyReservation();
            Console.WriteLine();

            foreach (var reservation in reservations)
            {
                reservation.MyReservation();
            }

            Console.ReadLine();
        }
    }
}
