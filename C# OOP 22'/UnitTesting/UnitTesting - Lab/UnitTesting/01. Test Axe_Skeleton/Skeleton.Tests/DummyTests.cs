using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private Dummy deadDummy;
        private int health;
        private int experience;

        [SetUp]
        public void Setup()
        {
            health = 10;
            experience = 15;
            dummy = new Dummy(health, experience);
            deadDummy = new Dummy(health, experience);
            deadDummy.TakeAttack(health + 10);
        }

        [Test]
        public void Test_Dummy_Constructor_Should_Set_Data_Correctly()
        {
            Assert.AreEqual(health, dummy.Health);
        }

        [Test]
        public void Test_Dummy_Loses_Health_When_Attacked()
        {
            dummy.TakeAttack(5);
            Assert.AreEqual(health - 5, dummy.Health);
        }

        [Test]
        public void Test_Dummy_Should_ThrowException_When_Health_Is_Zero()
        {
            dummy.TakeAttack(health);

            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(1);
            });
        }

        [Test]
        public void Test_Dummy_Should_ThrowException_When_Health_Is_Below_Zero()
        { 
            Assert.Throws<InvalidOperationException>(() =>
            {
                deadDummy.TakeAttack(1);
            });
        }

        [Test]
        public void Test_DeadDummy_Should_Give_Experience_When_Is_Dead()
        {
            var dummyExp = deadDummy.GiveExperience();

            Assert.AreEqual(experience, dummyExp);
        }

        [Test]
        public void Test_Dummy_Should_ThrowException_When_Dummy_Is_Alive()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }
    }
}