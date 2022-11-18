namespace CommandPattern.IO
{
using System;
using CommandPattern.IO.Contracts;

    public class Writer : IWriter
    {
        public void Write(object value) => Console.Write(value);

        public void WriteLine(object value) => Console.WriteLine(value);
    }
}
