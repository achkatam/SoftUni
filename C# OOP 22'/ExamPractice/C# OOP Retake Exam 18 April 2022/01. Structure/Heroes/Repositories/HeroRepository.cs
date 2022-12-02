namespace Heroes.Repositories
{
    using Heroes.Models.Contracts;
    using Heroes.Repositories.Contracts;
    using System.Collections.Generic;

    public class HeroRepository : IRepository<IHero>
    {
        private List<IHero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Models => this.heroes.AsReadOnly();

        public void Add(IHero model)
        {
            this.heroes.Add(model);
        }

        public IHero FindByName(string name)
        {
          return this.heroes.Find(x => x.Name == name);
        }

        public bool Remove(IHero model)
        {
            return this.heroes.Remove(model);
        }
    }
}
