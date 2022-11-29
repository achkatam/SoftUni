using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        private Smartphone smartphone;
        private Shop shop;
        private string modelName = "IPhone 14 Pro Max";
        private int maxCharge = 100;
        private int capacity = 3;

        [SetUp]
        public void Setup()
        {
            smartphone = new Smartphone(modelName, maxCharge);
            shop = new Shop(3);
        }
        [Test]
        public void Test_Constructor_shouldBeSetCorrectly()
        {
            Assert.AreEqual(3, shop.Capacity);
            Assert.AreEqual(0, shop.Count);
        }

        [TestCase(-1)]
        [TestCase(-11)]
        public void Test_Constructor_ShouldTHORWEXCEPTION_WHEN_CAPACITY_NEGATIVE(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                shop = new Shop(capacity);
            });
        }

        [Test]
        public void TEST_ADDMETHOD_INCREASE_COUNT()
        {
            shop.Add(smartphone);

            Assert.AreEqual(1, shop.Count);
        }
        [Test]
        public void TEST_ADDMETHOD_THROWSEXCEPTION_IF_PHONEEXISTED()
        {
            shop.Add(smartphone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(smartphone);
            });
        }

        [Test]
        public void TEST_ADDMETHOD_THROWSEXCEPTION_IF_CAPACITYEEXCEEDED()
        {
            shop.Add(smartphone);
            shop.Add(new Smartphone("2", 23));
            shop.Add(new Smartphone("1", 24));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone("6", 23));
            });
        }

        [Test]
        public void TEST_REMOVEMETHOD_REMOVESPHONE()
        {
            shop.Add(smartphone);

            shop.Remove(modelName);
           
            Assert.AreEqual(0, shop.Count);
        }


        [Test]
        public void TEST_REMOVEMETHOD_THROWSEXCEPTION_IF_NOTFOUND()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Remove ("6");
            });
        }


        [Test]
        public void TEST_TESTPHONESHOULDREDUCEBATTERY()
        {
            shop.Add(smartphone);
            shop.TestPhone(modelName, 40);

            Assert.AreEqual(maxCharge - 40, smartphone.CurrentBateryCharge);
        }

        [Test]
        public void TEST_TESTPHONE_THROWSEXCEPTION_IF_NOTFOUND()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("N/E",4);
            });
        }

        [Test]
        public void TEST_TESTPHONE_THROWSEXCEPTION_IFUSAGE_LARGER_THAN_BATTERYCAHRGE()
        {
            shop.Add(smartphone);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone(modelName, maxCharge + 100);
            });
        }

        [Test]
        public void TEST_CARGE_THROWSEXCEPTION_IF_NOTFOUND()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.ChargePhone("N/E");
            });
        }

        [Test]
        public void TEST_CHARGEMTHOD_SHOULD_RECHARGE_BATTERY_TO_MAX()
        {
            shop.Add(smartphone);

            shop.TestPhone(modelName, 50);

            shop.ChargePhone(modelName);

            Assert.AreEqual(maxCharge, smartphone.CurrentBateryCharge);
        }
    }
}