using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Greeting
    {
        public long ID { get; set; }
        public string Content { get; set; }

        public static long counter;
        
        public Greeting()
        {
            this.ID = 1;
            this.Content = "Hello, World!";
        }
        public Greeting(long id, string content)
        {
            this.Content = content;
            this.ID = id;
            
        }
    }
}
