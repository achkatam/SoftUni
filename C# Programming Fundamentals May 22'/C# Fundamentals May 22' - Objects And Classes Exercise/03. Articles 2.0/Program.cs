using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                var article = new Article(currArticle[0], currArticle[1], currArticle[2]);

                articles.Add(article);
            }

            string line = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }

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
        public Article()
        {

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{Title} - { Content}: { Author}";

    }
}
