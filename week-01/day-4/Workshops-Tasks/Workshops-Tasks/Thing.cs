using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops_Tasks
{
    class Thing
    {
        public string Name { get; private set; }
        public Thing(string name)
        {
            this.Name = name;
        }
    }
}
