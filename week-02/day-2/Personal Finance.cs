using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> expenses = new List<int> { 500, 1000, 1250, 175, 800, 120 };

            //foreach (var expense in expenses)
            //{
               // Console.WriteLine(expense);
            //}

            int sum = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                sum += expenses[i];
            }
            Console.WriteLine("In total we spend: " + sum + "$");
            int max = expenses.Max();
            Console.WriteLine("Our greatest expense was: "+ max);
            int min = expenses.Min();
            Console.WriteLine();
            double average = expenses.Average();
            Console.WriteLine("This was average expenses: " + average);
            Console.ReadLine();

        }
    }
}
