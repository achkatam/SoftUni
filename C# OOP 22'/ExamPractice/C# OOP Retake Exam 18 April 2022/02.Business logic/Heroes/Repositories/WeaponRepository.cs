namespace Heroes.Repositories
{
    using Heroes.Models.Contracts;
    using Heroes.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => this.weapons.AsReadOnly();

        public void Add(IWeapon model) => this.weapons.Add(model);

        public IWeapon FindByName(string name) => this.weapons.Find(x => x.Name == name);   

        public bool Remove(IWeapon model) => this.weapons.Remove(model);
    }
}
