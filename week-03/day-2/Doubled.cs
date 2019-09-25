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
            string[] oldText = File.ReadAllLines(path);

            Reverse(oldText);
            Console.ReadLine();
          
        }
        public static string Reverse(string[] oldText)
        {
           for (int i = 0; i < oldText.Length; i++)
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
