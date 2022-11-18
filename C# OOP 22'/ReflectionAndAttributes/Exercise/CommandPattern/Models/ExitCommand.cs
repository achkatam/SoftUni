namespace CommandPattern.Models
{
    using CommandPattern.Models.Contracts;
    using System;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);

            return null;
        }
    }
}
