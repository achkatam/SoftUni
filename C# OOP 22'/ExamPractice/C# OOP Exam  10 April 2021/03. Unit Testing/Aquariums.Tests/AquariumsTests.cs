namespace Aquariums.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using NUnit.Framework;

    public class AquariumsTests
    {
        private List<Fish> fish;
        private Aquarium tank;
        [SetUp]
        public void Setup()
        {
            tank = new Aquarium("WaterWorld", 34);
            fish = new List<Fish>();
        }

        [Test]
        public void Test_Constructor_Should_Work_Correctly()
        {
            string expectedName = "WaterWorld";
            int expectedCapacity = 34;

            Assert.AreEqual(expectedName, tank.Name);
            Assert.AreEqual(expectedCapacity, tank.Capacity);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_Name_Shoud_Trhow_Exception_If_NullOrEmtyp(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                tank = new Aquarium(name, 34);
            });
        }

        [TestCase(-2)]
        [TestCase(-1)]
        [TestCase(-134)]
        public void Test_Capacity_Shoud_Trhow_Exception_If_Negative(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                tank = new Aquarium("Water", capacity);
            });
        }

        [Test]
        public void Test_Count_ShouldReturnFishCount()
        {
            Fish fish1 = new Fish("Jason");
            Fish fish2 = new Fish("Pink");

            fish.Add(fish1);
            fish.Add(fish2);

            int expectedResult = 2;

            Assert.AreEqual(expectedResult, fish.Count);
        }

        [Test]
        public void Test_AddFishExceptionIfCapacityReached()
        {
            tank = new Aquarium("Water", 1);

            Fish fish1 = new Fish("Jason");
            Fish fish2 = new Fish("Pink");


            tank.Add(fish1);


            Assert.Throws<InvalidOperationException>(() =>
            {
                tank.Add(fish2);

            });
        }

        [Test]
        public void Test_AddFishIncreaseCount()
        {
             
            Fish fish1 = new Fish("Jason"); 
            tank.Add(fish1);

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, tank.Count);
        }
        [Test]
        public void Test_RemoveFishExceptionIfNonExistingFish()
        {
            Fish fishToRemove = fish.FirstOrDefault(x => x.Name == "Angel");

            Assert.Throws<InvalidOperationException>(() =>
            {
                tank.RemoveFish("Angel");
            });
        }

        [Test]
        public void Test_RemoveFishDecreaseCount()
        {

            Fish fish1 = new Fish("Jason");
            tank.Add(fish1);

            int expectedResult = 0;
            tank.RemoveFish("Jason");
            Assert.AreEqual(expectedResult, tank.Count);
        }

        [Test]
        public void TestSelFishExceptionIfNonExistingFish()
        {
            Fish fishToRemove = fish.FirstOrDefault(x => x.Name == "Angel");

            Assert.Throws<InvalidOperationException>(() =>
            {
                tank.SellFish("Angel");
            });
        }

        [Test]
        public void TestSelFish()
        {
            Fish fish1 = new Fish("Jason");
            tank.Add(fish1);
            var expectedFish = fish1;

            Assert.AreEqual(expectedFish, tank.SellFish("Jason"));
        } 
        [Test]
        public void Test_Report()
        {
            Fish fish1 = new Fish("Jason");
            tank.Add(fish1);
           string expeted = $"Fish available at WaterWorld: Jason";

            Assert.AreEqual(expeted, tank.Report());
        }
    }
}
