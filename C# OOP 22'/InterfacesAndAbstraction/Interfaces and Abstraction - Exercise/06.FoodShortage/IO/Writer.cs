namespace BirthdayCelebrations.IO
{
    using System;

    using BirthdayCelebrations.IO.Interfaces;

    public class Writer : IWriter
    {
        public void Write(string text) => Console.Write(text);


        public void WriteLine(string text) => Console.WriteLine(text);
    }
}
