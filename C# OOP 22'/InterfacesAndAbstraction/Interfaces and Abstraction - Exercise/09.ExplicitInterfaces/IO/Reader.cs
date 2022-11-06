namespace ExplicitInterfaces.IO
{
    using System;

    using ExplicitInterfaces.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
