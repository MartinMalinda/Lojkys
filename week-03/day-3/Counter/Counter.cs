using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Counter
    {
        private int defaultValue = 0;
        public int Value { get; set; }

        public Counter()
        {
            Value = defaultValue;
        }

        public Counter(int number)
        {
            Value = number;
            defaultValue = number;
        }

        public void Add(int number)
        {
            Value += number;
        }
        public void Add()
        {
            Value++;
        }
        public string Get()
        {
            return Value.ToString();
        }
        public void Reset()
        {
           Value = defaultValue;
        }
    }
}
