using System;

namespace Object_And_Classes
{

    public class Book
    {
        public string title;
        public string author;
        public static string staticAttribute = "My Static Attribute";

        public void ReadBook()
        {
            Console.WriteLine($"Reading {this.title} by {this.author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            Console.WriteLine();
            book1.ReadBook();
            Console.WriteLine(book1.title);
            Console.WriteLine(Book.staticAttribute);
        }
    }
}
