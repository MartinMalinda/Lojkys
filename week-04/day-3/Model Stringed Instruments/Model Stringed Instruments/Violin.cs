using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Stringed_Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
        }
        public Violin(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }
        public override void Play()
        {
            Sound();
        }
        public override void Sound()
        {
            string electricGuitarSound = "screeches";
            Console.WriteLine($"Violin, a {numberOfStrings}-stringed instrument that {electricGuitarSound}");
        }
    }
}
