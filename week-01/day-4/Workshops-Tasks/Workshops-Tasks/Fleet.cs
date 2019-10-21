using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshops_Tasks
{
    class Fleet
    {
        public List<Thing> Things { get; private set; }
        public Fleet()
        {
            Things = new List<Thing>();
        }
        public void Add(Thing thing)
        {
            Things.Add(thing);
        }
    }
}
