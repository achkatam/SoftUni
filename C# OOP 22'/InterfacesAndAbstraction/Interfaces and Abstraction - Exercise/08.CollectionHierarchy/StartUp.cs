namespace CollectionHierarchy
{
    using CollectionHierarchy.Core;
    using CollectionHierarchy.Core.Interfaces;
    using CollectionHierarchy.IO;
    using CollectionHierarchy.IO.Interfaces;
    

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
