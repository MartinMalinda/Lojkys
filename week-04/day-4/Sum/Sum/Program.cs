using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sumList = new List<int> { 34, 23, 4, 7, 5, 2, 42, 52, 25, 76 };
        }
    }            
    public class Summ
    {
        private List<int> sumList = new List<int> { 34, 23, 4, 7, 5, 2, 42, 52, 25, 76 };
        public List<int> SumList { get { return sumList; } private set { } }
        public int SumTheNumbersInList(List<int> numbers)
        {
            int summary = 0;
            foreach (var number in numbers)
            {
                summary += number;
            }
            return summary;
        }
    }
}
