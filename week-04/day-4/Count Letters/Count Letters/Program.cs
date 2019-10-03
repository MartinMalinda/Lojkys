using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCount = "kocka leze po zeleze hleda diru, kterou tam vleze";
            var testObject = new Letters();  
            
            testObject.CountLetters(testCount);
            
            
            Console.ReadLine();
        }
    }
}
