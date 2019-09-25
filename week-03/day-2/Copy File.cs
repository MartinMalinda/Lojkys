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
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string path = @"./I-am-copying.txt";
            string path2 = @"./Copied File.txt";
            WriteToFile(path);
            CopyFiles(path, path2);

            Console.ReadLine();
        }
        public static void CopyFiles(string firstFile, string secondFile)
        {
            if (!File.Exists(firstFile) || !File.Exists(secondFile))
            {
                Console.WriteLine("Both or one of the files does not exists");
            }
            else
            {
                bool result = false;
                try
                {
                    string[] content = File.ReadAllLines(firstFile);
                    File.WriteAllLines(secondFile, content);
                    result = true;
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    result = false;
                }
            }           
            
        }
        public static void WriteToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
                for (int i = 0; i < 7; i++)
                {
                    writer.WriteLine("Karel");
                }
        }
    }
}
