namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Foods;

    public class Hen : Bird
    {
        private const double HEN_WEIGHT_MULTIPLIER = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>()
            { typeof(Meat), typeof(Fruit), typeof(Vegetable), typeof(Seeds) };

        protected override double WeightMultiplier
            => HEN_WEIGHT_MULTIPLIER;

        public override string ProduceSound() => "Cluck";
    }
}
