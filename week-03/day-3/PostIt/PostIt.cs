using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class PostIt
    {
        public string backgroundColor;
        public string text;
        public string textColor;

        public PostIt(string bColor, string text, string textColor)
        {
            this.backgroundColor = bColor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}
