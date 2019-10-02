using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Stringed_Instruments
{
    class Electric_Guitar : StringedInstrument
    {
        public Electric_Guitar()
        {
            numberOfStrings = 6;
        }
        public Electric_Guitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }
        public override void Play()
        {
            Sound();
        }
        public override void Sound()
        {
            string electricGuitarSound = "twangs";
            Console.WriteLine($"Electric Guitar, a {numberOfStrings}-stringed instrument that {electricGuitarSound}");
        }
    }
}
