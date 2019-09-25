using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Sharpie
    {
        public string color { get; set; }
        public double width { get; set; }
        public double inkAmount { get; set; } = 100;

        public Sharpie(string color, double width)
        {
            this.color = color;
            this.width = width;
        }
        public void Use()
        {
            inkAmount--;
        }
    }
}
