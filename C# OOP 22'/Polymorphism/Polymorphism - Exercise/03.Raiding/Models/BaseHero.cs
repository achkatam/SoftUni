namespace Raiding.Models
{

    using Contracts;

    public abstract class BaseHero : IBaseHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public abstract int Power { get; }

        public virtual string CastAbility()
            => $"{this.GetType().Name} - {this.Name} ";
    }
}
