namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Foods;

    public class Owl : Bird
    {
        private const double OWL_WEIGHT_MULTIPLIER = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>() { typeof(Meat) };

        protected override double WeightMultiplier 
            => OWL_WEIGHT_MULTIPLIER;

        public override string ProduceSound() => "Hoot Hoot";
    }
}
