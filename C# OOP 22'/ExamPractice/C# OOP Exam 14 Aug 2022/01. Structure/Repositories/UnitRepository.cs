namespace PlanetWars.Repositories
{
    using PlanetWars.Models.MilitaryUnits.Contracts;
    using PlanetWars.Repositories.Contracts;
    using System.Collections.Generic;


    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private List<IMilitaryUnit> units;

        public UnitRepository()
        {
            this.units = new List<IMilitaryUnit>();
        }

        public IReadOnlyCollection<IMilitaryUnit> Models => this.units.AsReadOnly();

        public IMilitaryUnit FindByName(string name)
            => this.units.Find(x => x.GetType().Name == name);

        public void AddItem(IMilitaryUnit model) => this.units.Add(model);

        public bool RemoveItem(string name) => this.units.Remove(this.units.Find(x => x.GetType().Name == name));

    }
}
