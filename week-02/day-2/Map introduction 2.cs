using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneMap = new Dictionary<string, string>();
            PhoneMap.Add("978-1-60309-452-8", "A Letter to Jo");
            PhoneMap.Add("978-1-60309-459-7", "Lupus");
            PhoneMap.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            PhoneMap.Add("978-1-60309-461-0", "The Lab");

            foreach (var kvp in PhoneMap)
            {
                Console.WriteLine("{0} "+ "(ISBN: {1} ", kvp.Value, kvp.Key);
            }
            
            Console.WriteLine("------------------");
            PhoneMap.Remove("978-1-60309-444-3");
            PhoneMap.Remove("The Lab");

            foreach (var abc in PhoneMap)
            {
                if (abc.Value == "The Lab")
                {
                    PhoneMap.Remove(abc.Key);
                    break;
                }
                Console.WriteLine(abc);
            }
            PhoneMap.Add("978-1-60309-450-4", "They Called Us Enemy");
            PhoneMap.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            Console.WriteLine(PhoneMap.ContainsKey("478-0-61159-424-8"));

            Console.WriteLine("This is showing Value of the Key which is: 978-1-60309-453-5 ->> "+ PhoneMap["978-1-60309-453-5"]);

            Console.ReadLine();

        }
    }
}
