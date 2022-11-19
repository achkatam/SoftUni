namespace CommandPattern.Core
{
    using System;

    using CommandPattern.Core.Contracts;
    using CommandPattern.IO;
    using CommandPattern.IO.Contracts;
    using CommandPattern.Utilities.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter cmdInterpreter;

        private Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer(); 
        }

        public Engine(ICommandInterpreter cmdInterpreter)
            : this()
        {
            this.cmdInterpreter = cmdInterpreter;
        }

         
        public void Run()
        {
            while (true)
            {
                try
                {
                    string command = this.reader.ReadLine();
                    string result = this.cmdInterpreter.Read(command);

                    this.writer.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {
                    this.writer.WriteLine(ioe.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
