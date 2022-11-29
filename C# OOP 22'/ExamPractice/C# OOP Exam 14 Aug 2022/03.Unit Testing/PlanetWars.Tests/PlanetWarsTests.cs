using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlanetWars.Tests
{
    [TestFixture]
    public class Tests
    {
        private Planet planet;
        private Weapon weapon;
        private List<Weapon> weapons;

        [SetUp]
        public void Setup()
        {
            planet = new Planet("Earth", 24);
            weapons = new List<Weapon>();

            weapon = new Weapon("theMachine", 24.5, 4);

        }

        [Test]
        public void TEST_CONSTRUCTOR_SHOULD_CREATE_PLANET_CORRECTLY()
        {
            string expected = "Earth";
            double expectedBudget = 24;

            Assert.That(expected, Is.EqualTo(planet.Name));
            Assert.That(expectedBudget, Is.EqualTo(planet.Budget));
        }

        [TestCase("")]
        [TestCase(null)]
        public void TEST_NAME_SHOULD_TRHOW_EXCEPTION_IF_NULLOREMPTY(string planetName)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                planet = new Planet(planetName, 22);
            });
        }

        [TestCase(-2)]
        [TestCase(-4)]
        [TestCase(-42)]
        public void TEST_PLANETBUDGET_SHOULD_THROW_EXCEPTION_IF_NEGATIVE(double budget)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                planet = new Planet("Earth", budget);
            });
        }

        [TestCase(200)]
        public void TEST_PROFIT_SHOULD_INCREASE_BUDGET(double amount)
        {
            double expected = 224;
            planet.Profit(amount);

            Assert.That(expected, Is.EqualTo(planet.Budget));
        }

        [TestCase(25)]
        [TestCase(2552)]
        public void TEST_SPENDFUNDS_SHOULD_THROW_EXCEPTION_IF_AMOUNT_BIGGER_THAN_BUDGET(double amount)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                planet.SpendFunds(amount);
            }, "Not enough funds to finalize the deal.");
        }

        [Test]
        public void TEST_MILLITARY_POWER_RATIO_SHOULD_WORK_PROPERLY()
        {
            Weapon secondWeapon = new Weapon("TheRevo", 2, 25);
            int expected = weapon.DestructionLevel + secondWeapon.DestructionLevel;

            planet.AddWeapon(weapon);
            planet.AddWeapon(secondWeapon);

            Assert.AreEqual(expected, planet.MilitaryPowerRatio);
        }

        [TestCase(20)]
        public void TEST_SPENDFNUDS_SHOULD_DECREASE_BUDGET(double amount)
        {
            double expected = 4;
            planet.SpendFunds(amount);
            Assert.AreEqual(expected, planet.Budget);
        }

        [Test]
        public void TEST_ADDWEAPONMETHOD_SHOULD_INCREASE_WEAPONS_COUNT()
        {
            weapon = new Weapon("theMachine", 24.5, 4);
            int expectedCount = 1;
            this.weapons.Add(weapon);
            int actualCount = this.weapons.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TEST_ADDWEAPONMETHOD_SHOULD_THROW_EXCEPTION_IF_NAME_IS_USED()
        {
            weapon = new Weapon("theMachine", 24.5, 4);

            planet.AddWeapon(weapon);

            Assert.Throws<InvalidOperationException>(() =>
            {
                planet.AddWeapon(weapon);
            }, $"There is already a {weapon.Name} weapon.");
        }

        [Test]
        public void TEST_ADDWEAPONMETHOD_SHOULD_INCREASE_PLANETWEAPONS_COUNT()
        {
            weapon = new Weapon("theMachine", 24.5, 4);
            int expectedCount = 1;
            planet.AddWeapon(weapon);
            int actualCount = planet.Weapons.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TEST_REMOVEWEAPONMETHOD_SHOULD_DECREASE_PLANETWEAPONS_COUNT()
        {

            planet.AddWeapon(weapon);
            planet.RemoveWeapon(weapon.Name);

            Assert.AreEqual(0, planet.Weapons.Count);
        }

        [Test]
        public void TEST_INCREASEDESTRUCTINGLEVEL_METHOD_SHOULD_INCREASETHELEVEL()
        {
            planet.AddWeapon(weapon);
            planet.UpgradeWeapon(weapon.Name);

            Assert.AreEqual(5, weapon.DestructionLevel);
        }
        [Test]
        public void TEST_IUPGRADEWEAPONG_SHOULD_THROW_EXPECTION_IF_WEAPON_NONEXISTING()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                planet.UpgradeWeapon("themahcine");
            });
        }

        [Test]
        public void TEST_DESTRUCTOPPONENT_SHOULD_WORK_PROPERLY()
        {
            Planet opponent = new Planet("Opponent", 1);
            planet.AddWeapon(weapon);

            string message = planet.DestructOpponent(opponent);
            Assert.AreEqual(message, $"{opponent.Name} is destructed!");
        }
        [Test]
        public void TEST_DESTRUCTOPPONENT_SHOULD_THROW_EXCEPTION_IF_WEAKER()
        {
            Planet opponent = new Planet("Opponent", 500);
            Weapon opWeapon = new Weapon("theWinnter", 2500, 25);
            opponent.AddWeapon(opWeapon);

            planet.AddWeapon(weapon);

            Assert.Throws<InvalidOperationException>(() =>
            {
                planet.DestructOpponent(opponent);
            });
        }

        //weapon
        [TestCase(-2)]
        [TestCase(-25)]
        [TestCase(-252)]
        public void TEST_WEAPON_CONSTRUCTOR_SHOULD_THROW_EXCEPTION_IF_PRICE_BELOW_ZERO(double price)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                weapon = new Weapon("Terminator", price, 4);
            });
        }

        [Test]
        public void TEST_INCREASE_DESTRUCTIONLEVEL_SHOULD_WORK_PROPERLY()
        {
            int expected = weapon.DestructionLevel + 1;
            weapon.IncreaseDestructionLevel();

            Assert.AreEqual(expected, weapon.DestructionLevel);
        }

        [TestCase(11)]
        [TestCase(10)]
        [TestCase(1011)]
        public void TEST_NUCLEAR_IS_TRUE_IF_DL_MORE_THAN_TEN(int destructionLevel)
        {
            weapon = new Weapon("Gigi", 2, destructionLevel);
            Assert.IsTrue(weapon.IsNuclear);
        }
    }
}
