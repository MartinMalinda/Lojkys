using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Forward>();
            list.Add(new Forward());
            list.Add(new Forward());
            list.Add(new Forward());

            Console.WriteLine(list);

            int number = Count(3);
        }

        public static int Count(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                number *= 2;
            }
            return number;
        }
    }
}
