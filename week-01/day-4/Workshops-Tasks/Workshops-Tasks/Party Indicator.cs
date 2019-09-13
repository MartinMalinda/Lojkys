using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("How many girls is coming to the party?");
            int NumberOfGirls = int.Parse(Console.ReadLine());
            Console.WriteLine("How many boys?");
            int NumberOfBoys = int.Parse(Console.ReadLine());
            

            if (NumberOfBoys == NumberOfGirls && NumberOfBoys + NumberOfGirls > 20)
            {
                Console.WriteLine("The Party is excellent");
            }
            else if (NumberOfGirls + NumberOfBoys > 20 && NumberOfBoys != NumberOfGirls)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (NumberOfGirls != 0 &&  NumberOfBoys < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (NumberOfGirls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
 
        }
    }
}