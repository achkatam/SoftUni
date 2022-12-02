namespace PlanetWars.Repositories
{
    using PlanetWars.Models.MilitaryUnits.Contracts;
    using PlanetWars.Models.Planets.Contracts;
    using PlanetWars.Repositories.Contracts;
    using System.Collections.Generic;

    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.planets.AsReadOnly();

        public IPlanet FindByName(string name)
            => this.planets.Find(x => x.GetType().Name == name);

        public void AddItem(IPlanet model) => this.planets.Add(model);

        public bool RemoveItem(string name) => this.planets.Remove(this.planets.Find(x => x.GetType().Name == name));
    }
}
