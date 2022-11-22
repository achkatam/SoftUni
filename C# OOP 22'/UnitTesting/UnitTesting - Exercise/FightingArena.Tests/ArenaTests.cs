namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void ConstructorShouldInitializeWarriorsCollection()
        {
            Arena ctorArena = new Arena();

            Assert.IsNotNull(ctorArena.Warriors);
        }

        [Test]
        public void Test_EnrollingNonExistingWarriorShouldBeSuccessfull()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);

            this.arena.Enroll(warrior);

            bool isWarriorEnrolled = this.arena.Warriors.Contains(warrior);

            Assert.IsTrue(isWarriorEnrolled);
        }

        [Test]
        public void Test_EnrollingSameWarriorShouldThrowException()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);

            this.arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(warrior);

            }, "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void Test_EnrollingWarriorWithSameNameShouldThrowException()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);
            Warrior warrior2 = new Warrior("Advizal", 43, 67);

            this.arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(warrior2);

            }, "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void Test_CountShouldReturnWarriorsCount()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);
            Warrior warrior2 = new Warrior("Advizalina", 43, 67);

            this.arena.Enroll(warrior);
            this.arena.Enroll(warrior2);

            int expectedCount = 2;

            int actualCount = this.arena.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Test_CountShouldReturnZeroWhenNooneWasEnrolled()
        {
            int expectedCount = 0;
            int actualCount = this.arena.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Test_FightShouldThrowExceptionWithNonExistingAttacker()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);
            Warrior warrior2 = new Warrior("Advizalina", 43, 67);

            this.arena.Enroll(warrior2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(warrior.Name, warrior2.Name);
            }, $"There is no fighter with name {warrior.Name} enrolled for the fights!");
        }

        [Test]
        public void Test_FightShouldThrowExceptionWithNonExistingDefender()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);
            Warrior warrior2 = new Warrior("Advizalina", 43, 67);

            this.arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(warrior.Name, warrior2.Name);
            }, $"There is no fighter with name {warrior2.Name} enrolled for the fights!");
        }

        [Test]
        public void Test_SuccessfullFishtWhenWarriorsExist()
        {
            Warrior warrior = new Warrior("Advizal", 50, 100);
            Warrior warrior2 = new Warrior("Advizalina", 43, 67);

            this.arena.Enroll(warrior);
            this.arena.Enroll(warrior2);


            int w1ExpectedHp = warrior.HP - warrior2.Damage;
            int w2ExpectedHp = warrior2.HP - warrior.Damage;

            this.arena.Fight(warrior.Name, warrior2.Name);

            int w1ActualHp = warrior.HP; 
            int w2ActualHp = warrior2.HP; 

            Assert.AreEqual(w1ExpectedHp, w1ActualHp);
            Assert.AreEqual(w2ExpectedHp, w2ActualHp);
        }
    }
}
