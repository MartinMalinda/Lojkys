using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10Foxes
{
    class Fox
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Color { get; private set; }

        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
}
