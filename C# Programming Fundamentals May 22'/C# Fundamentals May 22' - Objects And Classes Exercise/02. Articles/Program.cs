using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] currentArticle = Console.ReadLine().Split(", ");
            var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);

            int numOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfChanges; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");
                string cmd = tokens[0];
                string argument = tokens[1];

                switch (cmd)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Rename(string title) => Title = title;
        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public override string ToString() =>  $"{Title} - { Content}: { Author}";
        
    }
}
