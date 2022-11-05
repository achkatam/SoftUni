namespace Telephony.IO
{
    using System;

    using Telephony.IO.Contracts;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        => Console.ReadLine();
    }
}
