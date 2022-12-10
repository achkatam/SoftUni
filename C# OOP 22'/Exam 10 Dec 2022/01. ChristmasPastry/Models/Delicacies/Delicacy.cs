namespace ChristmasPastryShop.Models.Delicacies
{
    using System; 
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Utilities.Messages;

    public abstract class Delicacy : IDelicacy
    {
        private string name;

        protected Delicacy(string name, double price)
        {
            this.Name = name;
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

        public double Price { get; private set; }

        public override string ToString()
            => $"{this.Name} - {this.Price:f2} lv";
    }
}
