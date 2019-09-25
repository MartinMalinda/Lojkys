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
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file. 
            string path = @"./Write-multiple-lines6.txt";
            Console.WriteLine("Tell me what you want to be written into the file?");
            string word = Console.ReadLine();
            Console.WriteLine("How many lines you want?");
            int num = Convert.ToInt32(Console.ReadLine());
            WriteIntoFile(path, word, num);

            //Console.WriteLine(File.ReadAllText(@"./Write-multiple-lines.txt"));

            Console.ReadLine();
        }
        public static void WriteIntoFile (string path, string word, int number)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Sorry, this file doesn't exists");
            }
            else
            {
                try
                {
                    using (StreamWriter writer = File.AppendText(path))
                        for (int i = 0; i < number; i++)
                        {
                            writer.WriteLine(word);
                        }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry, error");
                }
            }
        }
    }
}
