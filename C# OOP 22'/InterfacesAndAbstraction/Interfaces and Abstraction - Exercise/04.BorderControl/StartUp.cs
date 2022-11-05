namespace BorderControl
{
    using BorderControl.IO;
    using BorderControl.IO.Interfaces;
     

    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();

            engine.Run();
        }
    }
}
