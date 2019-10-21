using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./Reversing.txt";
            List<string> oldText = File.ReadAllLines(path).ToList();

            foreach (var item in oldText)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
            DeleteEverySecondLetter(oldText);
            oldText.Reverse();
            
            Console.ReadLine();
          
        }
        public static string DeleteEverySecondLetter(List<string> oldText)
        {         
            for (int i = 0; i < oldText.Count; i++)
            {
                string characters = "";
                for (int j = 0; j < oldText[i].Length; j += 2)
                {
                    characters += oldText[i][j];                  
                }
                Console.WriteLine(characters);
            }
            return oldText[0];
        }
    }
}
