using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive 3 lines of input. On the first line, you will receive a title of an article. On the next line, you will receive the content of that article. On the next n lines until you receive "end of comments" you will get the comments about the article. Print the whole information in HTML format. The title should be in "h1" tag (<h1></h1>); the content in article tag (<article></article>); each comment should be in div tag (<div></div>). 

            string title = Console.ReadLine();
            string articleTag = Console.ReadLine();

            Console.WriteLine($"<h1>\n\t{title}\n</h1>");
            Console.WriteLine($"<article>\n\t{articleTag}\n</article>");

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                Console.WriteLine($"<div>\n\t{comment}\n</div>");

                comment = Console.ReadLine();
            }
        }
    }
}
