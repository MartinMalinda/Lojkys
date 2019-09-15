using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int out1 = 0;
            // if a is even increment out by one
            for (int i = 0; i <= a; i++)
            {
                if (a % 2 == 0)
                {
                    out1++;
                }
                Console.WriteLine(out1);
            }

            Console.WriteLine("Give me some number");
            int b = Convert.ToInt32(Console.ReadLine());
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"

            if (b < 20 && b > 10)
            {
                out2 = "Sweet";
            }
            else if (b < 10)
            {
                out2 = "Less";
            }
            else if (b > 20)
            {
                out2 = "More";
            }
            Console.WriteLine(out2);
            
            int c = 100;
            int credits = 40;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (credits >= 50 && isBonus == false)
            {
                c -= 2;
            }
            else if (credits < 50 && isBonus == false)
            {
                c--;
            }

            Console.WriteLine(c);
            

            int d = 9;
            int time = 200;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if (d % 4 == 0 && time <=200)
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run";
            }
            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}
