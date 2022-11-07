namespace MilitaryElite.Models.Contracts
{

    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
