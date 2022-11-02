namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        private Person()
        {
            this.bagOfProducts = new List<Product>();
        }

        public Person(string name, decimal money) : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.WrongName);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.WrongInputForMoneyAndPrice);
                }

                this.money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.bagOfProducts.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            return
                this.bagOfProducts.Any() ?
            $"{this.Name} - {string.Join(", ", this.bagOfProducts.Select(p => p.Name))}" : $"{this.Name} - Nothing bought";
        }
    }
}
