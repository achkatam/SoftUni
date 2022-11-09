namespace Raiding
{
    using Core;
    using Core.Contracts;
    using Factories;
    using Factories.Contracts;
    using IO;
    using IO.Contracts;
  

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            IBaseHeroFactory hero = new BaseHeroFactory();

            IEngine engine = new Engine(reader, writer,hero);
            engine.Run();
        }
    }
}
