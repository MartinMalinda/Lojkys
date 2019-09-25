using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost post1 = new BlogPost("John Doe", "Lorem Ipsum", "2000.05.04", "Lorem ipsum dolor sit amet.");
            BlogPost post2 = new BlogPost();
            post2.authorName = "Tim Urban";
            post2.title = "Wait but why";
            post2.text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            post2.publicationDate = "2010.10.10.";
            BlogPost post3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine(post3.text);

            Console.ReadLine();
        }
    }
}
