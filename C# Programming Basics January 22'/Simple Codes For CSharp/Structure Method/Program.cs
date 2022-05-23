using System;

namespace Structure_Method
{
    public class Book
    {
        public string title;
        public string author;
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void ReadBook()
        {
            Console.WriteLine($"Reading {this.title} by {this.author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling");
            Console.WriteLine(book1.title);
            Book book2 = new Book("Lord of the Rings", "JRR Tolkien");
            Console.WriteLine(book2.title);

            Console.WriteLine();

            
        }
    }
}
