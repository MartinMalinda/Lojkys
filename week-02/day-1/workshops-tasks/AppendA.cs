using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            string[] animals = { "koal", "pand", "zebr" };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + "a";
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }



            Console.ReadLine();
        }
    }
}
