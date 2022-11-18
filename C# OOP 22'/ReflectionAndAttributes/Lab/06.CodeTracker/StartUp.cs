namespace AuthorProblem
{
    using System;

    [Author("Angel")]
    public class StartUp
    {
        [Author("Kyle")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }

        [Author("Angel")]
        public void PrintName()
        {
            Console.WriteLine("My name is Angel");
        }

        [Author("Smith")]
        public void GreatJob()
        {
            Console.WriteLine("You're doing great job!!!");
        }
    }
}
