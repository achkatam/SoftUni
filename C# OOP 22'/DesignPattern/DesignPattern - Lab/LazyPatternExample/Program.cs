namespace LazyPatternExample
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Lazy<Student> lazy = new Lazy<Student>(() =>
            {
                Console.WriteLine("Called only when lazy is being used");

                return new Student("Jimmy");
            });

            Console.WriteLine("Hey");
            Console.WriteLine();
            Console.WriteLine("Any code");

            Console.WriteLine(lazy.Value.Name);
        }
    }
}
