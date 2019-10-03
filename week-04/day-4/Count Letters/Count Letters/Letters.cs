using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters
{
    class Letters
    {
        public Letters()
        {

        }
        public void CountLetters(string word)
        {
            Dictionary<char, int> outputDictionary = new Dictionary<char, int>();
            //word.Replace(" ", "");
            foreach (var letter in word)
            {
                if (letter == ' ')
                {
                    continue;
                }
                else if (outputDictionary.ContainsKey(letter))
                {
                    outputDictionary[letter]++;
                }
                else
                {
                    outputDictionary.Add(letter, 1);
                }
            }
            foreach (var item in outputDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value + " ");
            }
        }
    }
}
