using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Flowers : Plant
    {
        public enum FlowerType { yellow, blue };
        public FlowerType Type { get; private set; }
        
        public Flowers()
        {

        }
        public Flowers(FlowerType type)
        {
            this.Type = type;
        }
    }
}
