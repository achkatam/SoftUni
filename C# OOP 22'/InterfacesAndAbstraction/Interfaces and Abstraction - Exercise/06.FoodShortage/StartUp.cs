namespace FoodShortage
{
    using BirthdayCelebrations.IO;
    using BirthdayCelebrations.IO.Interfaces;
    using BorderControl.IO;
    using BorderControl.IO.Interfaces;


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
