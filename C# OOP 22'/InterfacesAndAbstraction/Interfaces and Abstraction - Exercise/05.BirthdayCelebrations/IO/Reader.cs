namespace BirthdayCelebrations.IO
{
    using System;

    using BirthdayCelebrations.IO.Interfaces;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
