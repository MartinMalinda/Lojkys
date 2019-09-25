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
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            string path = ".//first-name.txt";
            try
            {
              
                using (StreamWriter lukas = new StreamWriter(path))
                {
                    lukas.WriteLine("Lukas Lojka");
                }
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: first-name.txt");
            }

            Console.ReadLine();
        }
    }
}
