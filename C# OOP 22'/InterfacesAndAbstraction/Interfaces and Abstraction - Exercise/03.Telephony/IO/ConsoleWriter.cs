namespace Telephony.IO
{
    using System;

    using Telephony.IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void Writeline(string text)
        {
            Console.WriteLine(text);
        }
    }
}
