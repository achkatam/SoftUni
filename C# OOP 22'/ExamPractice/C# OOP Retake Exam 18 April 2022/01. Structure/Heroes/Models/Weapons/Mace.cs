namespace Heroes.Models.Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mace : Weapon
    {
        private const int Damage = 25;
        public Mace(string name, int durability)
            : base(name, durability)
        {
        }

        public override int DoDamage()
        {
            this.Durability--;
            if (this.Durability == 0)
                return 0;

            return Damage;
        }
    }
}
