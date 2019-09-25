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
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string filePath = @"C:/Users/Lojka/Desktop/my-file.txt"; // If I messed up the path it will call the exception
            
            int i = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    i++;
                }
                Console.WriteLine($"This file has {i} lines.");
            }
            catch (Exception)
            {
                Console.WriteLine("This file can't be reached.");
            }
            

            Console.ReadLine();
        }
    }
}
