using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        private int attackPoints;
        private int durabillityPoint;

        [SetUp]
        public void Setup()
        {
            attackPoints = 10;
            durabillityPoint = 15;
            axe = new Axe(attackPoints, durabillityPoint);

            dummy = new Dummy(100, 100);
        }

        [Test]
        public void Test_AxeShouldSetDataProperly()
        {

            Assert.AreEqual(attackPoints, axe.AttackPoints);
            Assert.AreEqual(durabillityPoint, axe.DurabilityPoints);
        }

        [Test]
        public void Test_AxeShouldLoseDurabillityPontsAfterEachAttack()
        {
            for (int i = 0; i < 5; i++)
            {
                axe.Attack(dummy);
            }
            Assert.AreEqual(durabillityPoint - 5, axe.DurabilityPoints);
        }

        [Test]
        public void Test_AxeShouldThrowExceptionWhenDurabillityPointsAreZero()
        {
            axe = new Axe(10, 0);

            Assert.Throws<InvalidOperationException>((() =>
            {
                axe.Attack(dummy);
            }));
             
        }

        [Test]
        public void Test_AxeShouldThrowExceptionWhenDurabillityPointsAreBelowZero()
        {
            axe = new Axe(10, -5);

            Assert.Throws<InvalidOperationException>((() =>
            {
                axe.Attack(dummy);
            }));
           
        }
    }
}