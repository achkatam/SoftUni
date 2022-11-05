namespace Telephony
{
    using Telephony.Core;
    using Telephony.Core.Contracts;

    using Telephony.IO;
    using Telephony.IO.Contracts;

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
