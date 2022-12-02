namespace Heroes.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Heroes.Core.Contracts;
    using Heroes.Models.Contracts;
    using Heroes.Models.Heroes;
    using Heroes.Models.Map;
    using Heroes.Models.Weapons;
    using Heroes.Repositories;
    using Heroes.Utilities;

    public class Controller : IController
    {
        private HeroRepository heroes;
        private WeaponRepository weapons;

        public Controller()
        {
            this.heroes = new HeroRepository();
            this.weapons = new WeaponRepository();
        }
        public string CreateHero(string type, string name, int health, int armour)
        {
            if (this.heroes.FindByName(name) != null)
                throw new InvalidOperationException((string.Format(ExceptionMessages.ExistingHeroName, name)));

            IHero hero = null;
            switch (type)
            {
                case "Barbarian":
                    hero = new Barbarian(name, health, armour);
                    break;
                case "Knight":
                    hero = new Knight(name, health, armour);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidHeroType);
            }

            this.heroes.Add(hero);
            if (hero.GetType() == typeof(Knight))
                return string.Format(OutputMessages.SuccessfullyKnight, name);
            else
                return string.Format(OutputMessages.SuccessfullyBarbarian, name);
        }
        public string CreateWeapon(string type, string name, int durability)
        {

            if (this.weapons.FindByName(name) != null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.ExistingWeaponName, name));

            IWeapon weapon = null;

            switch (type)
            {
                case "Mace":
                    weapon = new Mace(name, durability);
                    break;
                case "Claymore":
                    weapon = new Claymore(name, durability);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidWeaponType);
            }

            this.weapons.Add(weapon);

            return string.Format(OutputMessages.CreateWeapon, type.ToLower(), name);
        }

        public string AddWeaponToHero(string weaponName, string heroName)
        {
            if (this.heroes.FindByName(heroName) == null)
                throw new InvalidOperationException((string.Format(ExceptionMessages.NonExistingHeroName, heroName)));

            if (this.weapons.FindByName(weaponName) == null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.NonExistingWeaponName, weaponName));

            IHero hero = heroes.FindByName(heroName);
            IWeapon weapon = this.weapons.FindByName(weaponName);

            if (hero.Weapon != null)
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.HeroAlreadyHasWeapon, hero.Name));

            hero.AddWeapon(weapon);
            this.weapons.Remove(weapon);

            return string.Format(OutputMessages.SuccessfullAddedWeaponToHero, hero.Name, weapon.GetType().Name.ToLower());
        }

        public string StartBattle()
        {
            Map map = new Map();
            List<IHero> fighters = this.heroes.Models.Where(x => x.IsAlive && x.Weapon != null).ToList();

            return map.Fight(fighters);
        }
        public string HeroReport()
        {
            var sb = new StringBuilder();

            foreach (var hero in this.heroes.Models.OrderBy(x => x.GetType().Name)
                .ThenByDescending(x => x.Health).ThenBy(x => x.Name))
            {
                sb
                    .AppendLine($"{hero.GetType().Name}: {hero.Name}")
                    .AppendLine($"--Health: {hero.Health}")
                    .AppendLine($"--Armour: {hero.Armour}")
                   .AppendLine(hero.Weapon != null ? $"--Weapon: {hero.Weapon.Name}" : "--Weapon: Unarmed");
            }

            return sb.ToString().Trim();
        }
    }
}
