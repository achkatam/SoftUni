namespace _04.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Toppings
    {
        private const int CALORIES = 2;
        private string topping;
        private double toppingWeight;

        private Dictionary<string, double> topCalories = new Dictionary<string, double>
        {
        //case sensitive causes breaking the code!!! FIXED!
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        public Toppings(string topping, double toppingWeight)
        {
            this.Topping = topping;
            this.ToppingWeight = toppingWeight;
        }

        public string Topping
        {
            get => this.topping;
            private set
            {
                //case sensitive causes breaking the code!!! FIXED!
                if (!topCalories.ContainsKey(value.ToLower()))
                    throw new ArgumentException(
                        String.Format(ExceptionMessages.InvalidTopping, value));

                this.topping = value;
            }
        }

        public double ToppingWeight
        {
            get => this.toppingWeight;
            private set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException(
                        String.Format(ExceptionMessages.InvalidToppingWeight, this.topping));

                this.toppingWeight = value;
            }
        }
        //case sensitive causes breaking the code!!! FIXED!
        public double ToppingCalories => CALORIES * this.topCalories[this.Topping.ToLower()] * ToppingWeight;

    }
}
