namespace WildFarm.Models.Contracts
{

    public interface IBird : IAnimal
    {
        double WingSize { get; }
    }
}
