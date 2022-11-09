namespace WildFarm.Factories.Contracts
{

using Models.Contracts;

    public interface IFoodFactory
    {
        IFood CreateFood(string type, int quantity);
    }
}
