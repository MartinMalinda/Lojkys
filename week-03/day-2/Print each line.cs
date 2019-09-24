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
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string path = @"C:\Users\Lojka\Desktop\my-file.txt";

            try
            { 
                string[] content = File.ReadAllLines(path);
                foreach (var con in content)
                {
                    Console.WriteLine(con);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ups, this file does not exists.");
            }

            Console.ReadLine();
        }
    }
}
