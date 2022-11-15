namespace _04.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const int CALORIES = 2;
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private Dictionary<string, double> flourData = new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

        private Dictionary<string, double> bakingTechniqueData = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        public double Calories => CALORIES * this.flourData[this.FlourType.ToLower()] * this.bakingTechniqueData[this.BakingTechnique.ToLower()] * this.Weight;

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (!flourData.ContainsKey(value.ToLower()))
                    throw new ArgumentException(ExceptionMessages.InvalidDough);

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (!bakingTechniqueData.ContainsKey(value.ToLower()))
                    throw new ArgumentException(ExceptionMessages.InvalidDough);

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException(ExceptionMessages.DoughWeight);

                this.weight = value;
            }
        }
    }
}
