namespace Raiding.Factories.Contracts
{
    using Raiding.Models.Contracts;

    public interface IBaseHeroFactory
    {
        IBaseHero CreateHero(string name, string type);
    }
}
