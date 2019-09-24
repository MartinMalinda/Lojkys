using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("William A. Lathan", "405 - 709 - 1865");
            phoneBook.Add("John K. Miller", "402 - 247 - 8568");
            phoneBook.Add("Hortensia E. Foster", "606 - 481 - 6467");
            phoneBook.Add("Amanda D. Newland", "319 - 243 - 5613");
            phoneBook.Add("Brooke P. Askew", "307 - 687 - 2982");

            Console.WriteLine(phoneBook["John K. Miller"]);

            Console.WriteLine(phoneBook.ContainsKey("Chris E. Myers"));

            Console.ReadLine();

        }
    }
}
