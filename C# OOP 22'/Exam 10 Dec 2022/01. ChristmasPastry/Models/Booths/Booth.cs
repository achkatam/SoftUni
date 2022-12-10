namespace ChristmasPastryShop.Models.Booths
{
    using System;
 
    using System.Text;
    using ChristmasPastryShop.Models.Booths.Contracts;
  
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories;
    using ChristmasPastryShop.Repositories.Contracts;
    using ChristmasPastryShop.Utilities.Messages;

    public class Booth : IBooth
    {
        private IRepository<IDelicacy> delicacyRepository;
        private IRepository<ICocktail> cocktailRepository;
        private int capacity;

        public Booth(int boothId, int capacity)
        {
            this.BoothId = boothId;
            this.Capacity = capacity;
            this.CurrentBill = 0;
            this.Turnover = 0;
            this.IsReserved = false;
            this.delicacyRepository = new DelicacyRepository();
            this.cocktailRepository = new CocktailRepository();
        }

        public int BoothId { get; private set; }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);

                this.capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => this.delicacyRepository;

        public IRepository<ICocktail> CocktailMenu => this.cocktailRepository;

        public double CurrentBill { get; private set; }

        public double Turnover { get; private set; }

        public bool IsReserved { get; private set; }

        public void ChangeStatus()
        {
            if (this.IsReserved == false)
                this.IsReserved = true;
            else
            {
                this.IsReserved = false;
            }
        }

        public void Charge()
        {
            this.Turnover += this.CurrentBill;

            this.CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"Booth: {this.BoothId}")
                .AppendLine($"Capacity: {this.Capacity}")
                .AppendLine($"Turnover: {this.Turnover:f2} lv")
                .AppendLine($"-Cocktail menu:");

            foreach (var cocktail in this.cocktailRepository.Models)
            {
                sb.AppendLine($"--{cocktail.ToString()}");
            }

            sb.AppendLine($"-Delicacy menu:");

            foreach (var item in delicacyRepository.Models)
            {
                sb.AppendLine($"--{item.ToString()}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
