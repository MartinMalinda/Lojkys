using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulUtilities.Models
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;
        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
            };

            random = new Random();
        }

        public string Caesar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return $"{text} == {result}";
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public List<string> ValidateEmail(string text)
        {
            var dict = new List<string>();

            if (text.Contains('@') && text.Contains('.'))
            {
                dict.Add("is@this.valid ========= is a valid email address");
                dict.Add("green");
                return dict;
            }
            else
            {
                dict.Add("not_valid_email.com ======== is not a valid email address");
                dict.Add("red");
                return dict;
            }
        }
    }
}
