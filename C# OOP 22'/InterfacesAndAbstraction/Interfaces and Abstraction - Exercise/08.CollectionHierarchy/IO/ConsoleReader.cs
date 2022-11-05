namespace CollectionHierarchy.IO
{
    using System;

    using CollectionHierarchy.IO.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
