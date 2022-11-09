namespace WildFarm.Models.Animals
{

    using Contracts;

    public abstract class Mammal : Animal, IMamml
    {
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

    }
}
