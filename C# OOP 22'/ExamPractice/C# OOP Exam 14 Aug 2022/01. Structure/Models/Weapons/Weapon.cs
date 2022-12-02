namespace PlanetWars.Models.Weapons
{
    using PlanetWars.Models.Weapons.Contracts;
    using PlanetWars.Utilities.Messages;
    using System;

    public abstract class Weapon : IWeapon
    {
        private double price;
        private int destructionLevel;

        protected Weapon(int destructionLevel, double price)
        {
            this.price = price;
            this.DestructionLevel = destructionLevel;
        }

        public double Price
        {
            get => this.price;
            private set => this.price = value;
        }
        public int DestructionLevel
        {
            get => this.destructionLevel;
            private set
            {
                if (value < 1)
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);

                if (value > 10)
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);

                this.destructionLevel = value;
            }
        }
    }
}
