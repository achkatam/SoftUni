namespace CommandPattern.Models
{
    using System;
    using CommandPattern.Models.Contracts;

    public class HelloCommand : ICommand
    {
        public string Execute(string[] args) => $"Hello, {args[0]}";
    }
}
