using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Trees : Plant
    {
        public enum TreeType { purple, orange};
        public TreeType Type { get; private set; }

        public Trees()
        {

        }
        public Trees(TreeType type)
        {
            this.Type = type;
        }
    }
}
