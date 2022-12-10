namespace ChristmasPastryShop.Repositories
{
    using System.Collections.Generic;
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Repositories.Contracts;

    public class BoothRepository : IRepository<IBooth>
    {
        private readonly ICollection<IBooth> booths;

        public BoothRepository()
        {
            this.booths = new List<IBooth>();
        }

        public IReadOnlyCollection<IBooth> Models => (IReadOnlyCollection<IBooth>)this.booths;

        public void AddModel(IBooth model) => this.booths.Add(model);
    }
}
