namespace P03.Detail_Printer.Contracts
{
    using System.Collections.Generic;


    public interface IManager : IEmployee
    {
        IReadOnlyCollection<string> Documents { get; }
    }
}
