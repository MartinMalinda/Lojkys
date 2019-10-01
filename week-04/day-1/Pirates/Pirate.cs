using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Pirate
    {
        public string Name { get; private set; }
        public int Gold { get; private set; } = 10;
        public int HealthPoints { get; private set; } = 10;
        public PirateType Type { get; private set; }

        public Pirate(string name, PirateType type)
        {
            this.Name = name;
            this.Type = type;
        }
        public void Work(Pirate pirate)
        {
            if (pirate.Type == PirateType.Captain)
            {
                Gold += 10;
                HealthPoints -= 5;
            }
            else if (pirate.Type != PirateType.Captain)
            {
                Gold++;
                HealthPoints--;
            }
        }
        public void Party(Pirate pirate)
        {
            if (pirate.Type == PirateType.Captain)
            {
                HealthPoints += 10;
            }
            else if (pirate.Type != PirateType.Captain)
            {
                HealthPoints++;
            }
        }
        public string ToString(Pirate pirate)
        {
            if (pirate.Type == PirateType.WoodenLeg)
            {
                string woodenLeg = "Hello, I'm Jack. I have a wooden leg and 20 golds";
                return woodenLeg;
            }
            else if (pirate.Type != PirateType.WoodenLeg)
            {
                string noWoodenLeg = "Hello, I'm Jack. I still have my real legs and 20 golds.";
                return noWoodenLeg;
            }
            return "ToString method doesn't work";
        }
    }
}
