using System;

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
            Console.ReadLine();
        }
    }
}
