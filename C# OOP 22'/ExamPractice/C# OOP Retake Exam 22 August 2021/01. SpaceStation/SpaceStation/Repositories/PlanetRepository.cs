using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly ICollection<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => (IReadOnlyCollection<IPlanet>)this.planets;

        public void Add(IPlanet model) => this.planets.Add(model);

        public IPlanet FindByName(string name) => this.planets.FirstOrDefault(x => x.Name == name);

        public bool Remove(IPlanet model) => this.planets.Remove(model);
    }
}
