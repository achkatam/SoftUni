namespace ExplicitInterfaces
{
    using System;
    using ExplicitInterfaces.Core;
    using ExplicitInterfaces.Core.Contracts;
    using ExplicitInterfaces.IO;
    using ExplicitInterfaces.IO.Contracts;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
