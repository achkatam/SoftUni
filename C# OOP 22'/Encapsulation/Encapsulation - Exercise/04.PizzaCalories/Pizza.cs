namespace _04.PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const int TOPPING_AMOUNT = 10;
        private string name;
        private Dough dough;
        private List<Toppings> toppings;

        private Pizza()
        {
            this.toppings = new List<Toppings>();
        }

        public Pizza(string name, Dough dough) : this()
        {
            this.Name = name;
            this.Dough = dough;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                    throw new ArgumentException(ExceptionMessages.WrongPizzaName);

                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            private set => this.dough = value;
        }

        public IReadOnlyCollection<Toppings> Toppings => this.toppings;

        public void AddTopping(Toppings topping)
        {
            if (this.toppings.Count >= TOPPING_AMOUNT)
            {
                throw new ArgumentException(ExceptionMessages.WrongToppingsAmount);
            }

            this.toppings.Add(topping);
        }

        public double GetTotalCalories()
        {
            double result = dough.Calories + toppings.Sum(x => x.ToppingCalories);

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.GetTotalCalories():f2} Calories.";
        }
    }
}
