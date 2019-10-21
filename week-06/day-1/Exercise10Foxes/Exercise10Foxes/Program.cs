using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxList = new List<Fox>();

            foxList.Add(new Fox("Karel", "pallida", "green"));
            foxList.Add(new Fox("Honza", "lesni", "white"));
            foxList.Add(new Fox("Pepa", "polni", "black"));
            foxList.Add(new Fox("Jirka", "divoka", "green"));
            foxList.Add(new Fox("Milos", "obecna", "blue"));
            foxList.Add(new Fox("Lubos", "moucni", "green"));
            foxList.Add(new Fox("Milan", "pallida", "green"));
            foxList.Add(new Fox("Vaclav", "obecna", "blue"));

            Console.WriteLine("Green fox: ");
            var greenFox = foxList.Where(fox => fox.Color == "green").ToList();
            greenFox.ForEach(fox => Console.WriteLine($"Fox named {fox.Name} has a {fox.Color} color."));

            Console.WriteLine();

            Console.WriteLine($"Foxes with green color and pallida type: ");
            var pallidaType = foxList.Where(fox => fox.Color == "green" && fox.Type == "pallida").ToList();
            pallidaType.ForEach(fox => Console.WriteLine(fox.Name));

            Console.ReadLine();
        }
    }
}
