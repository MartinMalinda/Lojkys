﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your phone number? \n+ 420 ");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            string myString = string.Format("Phone number: {0:+ 420 ### ### ###}", phoneNumber); 

            Console.WriteLine(myString);

            Console.WriteLine(myString.Substring(6, 6));

            Console.WriteLine(myString.Length());
            Console.ReadLine();  
        }
    }
}
