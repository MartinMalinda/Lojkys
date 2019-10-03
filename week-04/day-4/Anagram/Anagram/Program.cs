using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me some word: ");
            string str1 = Console.ReadLine();
            Console.Write("Give me second word: ");
            string str2 = Console.ReadLine();

            var nevim = new BoolAnagram();

            Console.WriteLine(nevim.IsAnagram(str1, str2));

            Console.ReadLine();
        }
             
    }
    public class BoolAnagram
    {
        public BoolAnagram()
        {

        }
        public bool IsAnagram(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
