namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp] 
        public void SetUp()
        {
            warrior = new Warrior("Advizal", 50, 100);
        }

        //[TestCase("Advizal")]
        //[TestCase("W")]
        //[TestCase("Very very very very very very long name")]
        [Test]
        public void Test_Constructor_Should_Initialize_Warrior_Name()
        {
            string expectedName = "Advizal";
            //Arrange
             warrior = new Warrior(expectedName, 50, 50);

            string actualName = warrior.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        //[TestCase(50)]
        //[TestCase(1823612)]
        //[TestCase(1)]
        [Test]
        public void Test_Constructor_Should_Initialize_Warrior_Damaga( )
        {
            int expectedDamage = 50;
             warrior = new Warrior("Advizal", expectedDamage, 50);
            int actualDamage = warrior.Damage;

            Assert.AreEqual(expectedDamage, actualDamage);
        }

        //[TestCase(12)]
        //[TestCase(12128731)]
        //[TestCase(1)]
        [Test]
        public void Test_Constructor_Should_Initialize_HP()
        {
            int expectedHp = 50;

             warrior = new Warrior("Advizal", 50, expectedHp);
            int actualHp = warrior.HP;

            Assert.AreEqual(expectedHp, actualHp);
        }


        [TestCase("Advizal")]
        [TestCase("W")]
        [TestCase("Very very very very very very long name")]
        public void Test_SetterShouldSetValueWithValidName(string name)
        {
             warrior = new Warrior(name, 50, 100);

            string expectedName = name;

            string actualName = warrior.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("      ")]
        public void Test_NameSetterSouldThrowExceptionWithEmptyOrWhitespaceName(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warriow = new Warrior(name, 50, 100);
            }, "Name should not be empty or whitespace!");
        }

        [TestCase(50)]
        [TestCase(1823612)]
        [TestCase(1)]
        public void Test_DamageSettersShouldSetDamageCorrectly(int damage)
        {
            int expectedDamage = damage;
            Warrior warrior = new Warrior("Advizal", damage, 100);

            int actualDamage = warrior.Damage;
            Assert.AreEqual(expectedDamage, actualDamage);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void Test_DamageSettersShouldThrowExceptionWithZeroOrNegativeDamage(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Advizal", damage, 100);
            }, "Damage value should be positive!");
        }


        [TestCase(100)]
        [TestCase(12128731)]
        [TestCase(1)]
        public void Test_HPSettersShouldSetTheHpCorrectl(int hp)
        {
            int expectedHp = hp;

            Warrior warrior = new Warrior("Advizal", 50, expectedHp);
            int actualHp = warrior.HP;

            Assert.AreEqual(expectedHp, actualHp);
        }
        [TestCase(-12128731)]
        [TestCase(-1)]
        public void Test_HPSettersShouldTrhowExceptionWithNegativeHP(int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Advizal", 50, hp);
            }, ("HP should not be negative!"));
        }

        [Test]
        public void Test_SuccessfullAttackingWarrior_NoKill()
        {
            int w1Damage = 50;
            int w1Hp = 100;

            int w2Damage = 30;
            int w2Hp = 100;
            //Arrange
            Warrior warrior1 = new Warrior("Advizal", w1Damage, w1Hp);
            Warrior warrior2 = new Warrior("Advizalina", w2Damage, w2Hp);
            //Act
            warrior1.Attack(warrior2);

            int w1ExpectedHp = w1Hp - w2Damage;
            int w2ExpectedHp = w2Hp - w1Damage;
            //Assert
            int w1ActualHp = warrior1.HP;
            int w2ActualHp = warrior2.HP;

            Assert.AreEqual(w1ExpectedHp, w1ActualHp);
            Assert.AreEqual(w2ExpectedHp, w2ActualHp);
        }
         
        [TestCase(49)]
        [TestCase(50)] 
        [TestCase(35)] 
        public void Test_SuccessFullAttackingWithKill(int w2Hp)
        {
            int w1Damage = 50;
            int w1Hp = 100;

            int w2Damage = 30;
             
            //Arrange
            Warrior warrior1 = new Warrior("Advizal", w1Damage, w1Hp);
            Warrior warrior2 = new Warrior("Advizalina", w2Damage, w2Hp);
            //Act
            warrior1.Attack(warrior2);

            int w1ExpectedHp = w1Hp - w2Damage;
            int w2ExpectedHp = 0;
            //Assert
            int w1ActualHp = warrior1.HP;
            int w2ActualHp = warrior2.HP;

            Assert.AreEqual(w1ExpectedHp, w1ActualHp);
            Assert.AreEqual(w2ExpectedHp, w2ActualHp);
        }

        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        public void Test_AttackingShoulThrowExceptionIfAttackerHPIsBelowMin(int w1Hp)
        {
            int w1Damage = 50;
            //int w1Hp = w1hp;

            int w2Damage = 30;
            int w2Hp = 100;
            //Arrange
            Warrior warrior1 = new Warrior("Advizal", w1Damage, w1Hp);
            Warrior warrior2 = new Warrior("Advizalina", w2Damage, w2Hp);
            //Act
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            }, "Your HP is too low in order to attack other warriors!");
        }

        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        public void Test_AttackingShoulThrowExceptionIfDefenderHPIsBelowMin(int w2Hp)
        {
            int w1Damage = 50;
            int w1Hp = 100;

            int w2Damage = 30;
            //int w2Hp = 100;
            //Arrange
            Warrior warrior1 = new Warrior("Advizal", w1Damage, w1Hp);
            Warrior warrior2 = new Warrior("Advizalina", w2Damage, w2Hp);
            //Act
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            }, "Enemy HP must be greater than 30 in order to attack him!");

        }

        [TestCase(45, 65)]
        [TestCase(64, 65)]
        public void Test_AttackingShoulThrowExceptionWhenAttackerIsBelowDefenderDamaga(int w1hp, int w2damage)
        {
            int w1Damage = 50;
            int w1Hp = w1hp;

            int w2Damage = w2damage;
            int w2Hp = 100;
            //Arrange
            Warrior warrior1 = new Warrior("Advizal", w1Damage, w1Hp);
            Warrior warrior2 = new Warrior("Advizalina", w2Damage, w2Hp);
            //Act
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            }, "You are trying to attack too strong enemy");
        }
    }
}