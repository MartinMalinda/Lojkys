using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }
        public bool GetBoolStatus()
        {
            return completed;
        }

        public bool Complete()
        {
            return completed = true;
        }
        public string GetName()
        {
            return name;
        }
    }
}
