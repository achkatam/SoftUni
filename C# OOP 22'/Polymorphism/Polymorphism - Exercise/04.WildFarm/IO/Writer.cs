namespace WildFarm.IO
{
    using System;

    using Contracts;

    public class Writer : IWriter
    {
        public void Write(object value) => Console.Write(value.ToString());

        public void WriteLine(object value) => Console.WriteLine(value.ToString());
    }
}
