using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            int FirstNumber;
            int SecondNumber;
            int ThirdNumber;
            int FourthNumber;
            int Fifthumber;

            Console.WriteLine("Write 5 numbers");
            FirstNumber = Convert.ToInt32(Console.Read());
            SecondNumber = Convert.ToInt32(Console.Read());
            ThirdNumber = Convert.ToInt32(Console.Read());
            FourthNumber = Convert.ToInt32(Console.Read());
            Fifthumber = Convert.ToInt32(Console.Read());

            Console.WriteLine("Your numbers are: {0} {1} {2} {3} {4}", FirstNumber, SecondNumber, ThirdNumber, FourthNumber, Fifthumber);
            Console.WriteLine("And the average is: " + (FirstNumber + SecondNumber + ThirdNumber + FourthNumber + Fifthumber) / 5.0);

            Console.ReadLine();
            Console.ReadLine();

			


        }
    }
}