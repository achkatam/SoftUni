namespace ChristmasPastryShop.Models.Cocktails
{
    using System;

    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Utilities.Messages;

    public abstract class Cocktail : ICocktail
    {
        private string name;
        private double price;

        protected Cocktail(string name, string size, double price)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);

                this.name = value;
            }
        }


        public string Size { get; private set; }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (this.Size == "Large")
                {
                    this.price = value;
                }
                else if (this.Size == "Middle")
                {

                    this.price = (2 / 3.0) * value;

                }
                else if (this.Size == "Small")
                {
                    this.price = (1 / 3.0) * value;
                }
            }
        }
        public override string ToString()
            => $"{this.Name} ({this.Size}) - {this.Price:f2} lv";
    }
}
