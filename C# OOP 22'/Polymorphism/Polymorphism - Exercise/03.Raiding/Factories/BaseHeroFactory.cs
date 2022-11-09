namespace Raiding.Factories
{
    using Contracts;
    using Raiding.Exceptions;
    using Raiding.Models;
    using Raiding.Models.Contracts;

    public class BaseHeroFactory : IBaseHeroFactory
    {
        public IBaseHero CreateHero(string heroName, string heroType)
        {
            IBaseHero hero;
            switch (heroType)
            {
                case "Druid":
                    hero = new Druid(heroName);
                    break;
                case "Paladin":
                    hero = new Paladin(heroName);
                    break;
                case "Rogue":
                    hero = new Rogue(heroName);
                    break;
                case "Warrior":
                    hero = new Warrior(heroName);
                    break;
                default:
                    throw new InvalidHeroType
                        (string.Format(ExceptionMessages.InvalidHeroType));
                    break;
            }

            return hero;
        }
    }
}
