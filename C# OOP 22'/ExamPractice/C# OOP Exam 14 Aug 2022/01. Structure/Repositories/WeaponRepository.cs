namespace PlanetWars.Repositories
{
    using PlanetWars.Models.Weapons.Contracts;
    using PlanetWars.Repositories.Contracts;

    using System.Collections.Generic;


    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => this.weapons.AsReadOnly();

        public IWeapon FindByName(string name)
            => this.weapons.Find(x => x.GetType().Name == name);

        public void AddItem(IWeapon model) => this.weapons.Add(model);

        public bool RemoveItem(string name) => this.weapons.Remove(this.weapons.Find(x => x.GetType().Name == name));
    }
}
