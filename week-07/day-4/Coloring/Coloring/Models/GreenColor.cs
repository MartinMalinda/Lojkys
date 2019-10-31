using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coloring.Models
{
    public class GreenColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("This is Green color");
        }
    }
}
