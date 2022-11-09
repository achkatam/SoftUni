namespace Vehicles.IO
{
    using System;

    using Vehicles.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
