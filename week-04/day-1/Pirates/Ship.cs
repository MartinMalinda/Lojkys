using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Ship
    {
        private List<Pirate> pirates = new List<Pirate>();
    
        public List<Pirate> GetPirateType(PirateType type)
        {
            var result = new List<Pirate>();
            foreach (var pirate in pirates)
            {
                if (pirate.Type == type)
                {
                    result.Add(pirate);
                }
            }
            return result;
        }
        public void AddPirate(Pirate pirate)
        {
            var captains = GetPirateType(PirateType.Captain);
            if (pirate.Type == PirateType.Captain)
            {
                Console.WriteLine("We don't need more captains");
            }
            pirates.Add(pirate);
        }
        public void GetPoorPirates()
        {
            Console.WriteLine("This is a list of Poor Pirates: ");
            foreach (var pir in pirates)
            {
                if (pir.Type == PirateType.WoodenLeg && pir.Gold < 15)
                {
                    Console.WriteLine(pir.Name);
                }
            }
        }
        public void GetGolds(List<Pirate> pirates)
        {
            int sum = 0;
            foreach (var pirate in pirates)
            {
                sum += pirate.Gold;
            }
        }
        public void LastDayOnTheShip(Pirate party)
        {
            party.Party(party);
        }
        public void PrepareForBattle(Pirate work, Ship ship)
        {
            for (int i = 0; i < 5; i++)
            {
                work.Work(work);
            }
            ship.LastDayOnTheShip(work);          
        }
    }
}
