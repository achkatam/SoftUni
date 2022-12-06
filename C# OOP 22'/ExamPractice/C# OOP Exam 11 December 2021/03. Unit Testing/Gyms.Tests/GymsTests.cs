namespace Gyms.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GymsTests
    {
        // Implement unit tests here
        private string name = "Achilis";
        private int capacity = 12;
        private Gym gym;
        private List<Athlete> athletes;

        [SetUp]
        public void Setup()
        {
            gym = new Gym(name, capacity);
            this.athletes = new List<Athlete>();
        }

        [Test]
        public void TEST_CONSTUCTOR_SHOULD_SET_DATA_CORRECTLY()
        {
            string expectedName = "Achilis";
            int expectedSize = 12;

            gym = new Gym(name, capacity);

            Assert.AreEqual(expectedName, gym.Name);
            Assert.AreEqual(expectedSize, gym.Capacity);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_CONSTUCTOR_SHOULD_THROW_EXCEPTION_FOR_INVALID_NAME(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                gym = new Gym(name, capacity);
            });
        }

        [TestCase(-2)]
        [TestCase(-12)]
        public void TEST_CONSTUCTOR_SHOULD_THROW_EXCEPTION_FOR_INVALID_CPACITY(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                gym = new Gym(name, capacity);
            });
        }

        [Test]
        public void TEST_CONSTUCTOR_SHOULD_THROW_EXCEPTION_FOR_IF_FULLCAPACITY()
        {
            for (int i = 0; i < capacity; i++)
            {
                gym.AddAthlete(new Athlete(i.ToString()));
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.AddAthlete(new Athlete("Hero"));
            });
        }


        [Test]
        public void TEST_Count_SHOULD_RETURN_ATHLETES_COUNT()
        {
            athletes.Add(new Athlete("John"));
            athletes.Add(new Athlete("Tyson"));

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, athletes.Count);
        }

        [Test]
        public void TEST_REMOVE_SHOULD_DECREASE_ATHLETES_COUNT()
        {
            gym.AddAthlete(new Athlete("John"));
            gym.AddAthlete(new Athlete("Tyson"));

            gym.RemoveAthlete("John");

            int expectedCount = 1;

            Assert.AreEqual(expectedCount, gym.Count);
        }

        [Test]
        public void TEST_REMOVE_SHOULD_THROW_EXCEPTION_IF_NONEXISTING_ATHLETE()
        {
            gym.AddAthlete(new Athlete("John"));
            gym.AddAthlete(new Athlete("Tyson"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.RemoveAthlete("Jason");
            });
        }

        [Test]
        public void TEST_INJURE_ATHLETE_IF_EXISTING()
        {
            gym.AddAthlete(new Athlete("Smith"));

            Athlete injuredAthlete = gym.InjureAthlete("Smith");

            Assert.IsTrue(injuredAthlete.IsInjured);
            Assert.AreEqual("Smith", injuredAthlete.FullName);
        }

        [Test]
        public void TEST_INJURE_THROW_EXCEPTION_IF_NONEXISTING()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.InjureAthlete("Hero");
            });
        }

        [Test]
        public void Test_REPORT_SHOULD_REUTRN_NAMES()
        {
            gym.AddAthlete(new Athlete("Tyson"));
            gym.AddAthlete(new Athlete("Smith"));
            gym.AddAthlete(new Athlete("Jason"));

            Athlete injuredAthlete = gym.InjureAthlete("Tyson");

            gym.Report();
              
            string expectedAthletes = string.Join(", ", athletes.Where(x => !x.IsInjured).Select(f => f.FullName));
            string expectedReport = $"Active athletes at Achilis: Smith, Jason";

            Assert.AreEqual(expectedReport, gym.Report());
        }
    }
}
