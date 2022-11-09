namespace WildFarm.IO
{
    using System;

    using WildFarm.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
