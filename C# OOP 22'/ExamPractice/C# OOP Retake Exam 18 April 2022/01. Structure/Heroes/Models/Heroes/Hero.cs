using Heroes.Models.Contracts;
using System;

namespace Heroes.Models.Heroes
{

    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        protected Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Hero name cannot be null or mepty.");

                this.name = value;
            }
        }

        public int Health
        {
            get => this.health;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Hero health cannot be below 0.");

                this.health = value;
            }
        }

        public int Armour
        {
              
                get => this.armour;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Hero health cannot be below 0.");

                this.armour = value;
            }
        }
    

        public IWeapon Weapon
        {
            get => this.weapon;
            private set
            {
                if (value == null)
                    throw new ArgumentException("Weapon cannot be null.");

                this.weapon = value;
            }
        }

        public bool IsAlive => this.Health > 0;

        public void AddWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void TakeDamage(int points)
        {
            int leftoverPoints = 0;

            armour -= points;
            if (armour <= 0)
            {
                leftoverPoints = Math.Abs(Armour);
                armour = 0;
            }

            if (leftoverPoints > 0)
            {
                health -= leftoverPoints;

                if (health < 0)
                {
                    health = 0;
                }
            }
        }
    }
}
