using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Function
{
    class Program
    {
         static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:


            //Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));

            //  should print: `[0, 1, 4]`
            //Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'
            int dlzkaposratehooutputu = 0;
            int[] vysledky = SubInt(ref dlzkaposratehooutputu,1, new int[] { 1, 11, 34, 52, 61 });
            for (int i = 0; i < dlzkaposratehooutputu; i++)
            {
                Console.WriteLine(vysledky[i]);
            }
            Console.ReadLine();
        }
        

        private static int[] SubInt(ref int k,int v1, int[] v2)
        {
            int[] output = new int[v2.Length];
            
            for (int i = 0; i < v2.Length; i++)
            {
                string str = v2[i].ToString();
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == v1.ToString()[0])
                    {
                        output[k] = i;
                        k++;
                        break;
                    }
                }
            }
            return output;
        }
    }
}
