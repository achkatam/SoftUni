using Heroes.Models.Contracts;
namespace Heroes.Models.Weapons
{
    using System;

    public abstract class Weapon : IWeapon
    {
        private string name;
        private int durability;

        protected Weapon(string name, int durability)
        {
            this.Name = name;
            this.Durability = durability;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Weapon type cannot be null or empty.");

                this.name = value;
            }
        }

        public int Durability
        {
            get => this.durability;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Durability cannot be below 0.");

                this.durability = value;
            }
        }

        public abstract int DoDamage();
    }
}
