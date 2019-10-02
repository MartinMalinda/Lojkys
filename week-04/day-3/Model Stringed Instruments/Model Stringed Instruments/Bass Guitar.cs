using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Stringed_Instruments
{
    class Bass_Guitar : StringedInstrument
    {
        public Bass_Guitar()
        {
            numberOfStrings = 4;
        }
        public Bass_Guitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }
        public override void Play()
        {
            Sound();
        }
        public override void Sound()
        {
            string electricGuitarSound = "Duum-duum-duum";
            Console.WriteLine($"Bass Guitar, a {numberOfStrings}-stringed instrument that {electricGuitarSound}");
        }
    }
}
