using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Stringed_Instruments
{
    abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;
        public abstract void Sound();
    }
}
