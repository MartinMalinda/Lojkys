using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt article = new PostIt("Orange", "Idea 1", "Blue");
            PostIt article2 = new PostIt("Pink", "Awesome", "Black");
            PostIt article3 = new PostIt("Yellow", "Superb", "Green");

            Console.WriteLine(article.backgroundColor );

            Console.ReadLine();
        }
    }
}
