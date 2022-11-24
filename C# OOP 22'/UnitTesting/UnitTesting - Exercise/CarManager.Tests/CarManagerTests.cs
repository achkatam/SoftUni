namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("Ferrari", "F40", 23, 120);
        }

        [Test]
        public void TEST_CONSTRUCTOR_SOULD_SET_FUELAMOUNT_AT_ZERO()
        {
            car = new Car("Ferrari", "F40", 23, 120);

            double expected = 0;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_MAKE_SHOULD_THROW_EXCEPTION_IF_NULL_OR_EMPTY(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, "F40", 25, 120);
            }, "Make cannot be null or empty!");
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_MODEL_SHOULD_THROW_EXCEPTION_IF_NULL_OR_EMPTY(string model)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Ferrari", model, 25, 120);
            }, "Model cannot be null or empty!");
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-22)]
        public void TEST_FUELCONSUMPTION_SHOULD_THROW_EXCEPTION_IF_NEGATIVE_OR_ZERO(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Ferrari", "F40", fuelConsumption, 120);
            }, "Fuel consumption cannot be zero or negative!");
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-22)]
        public void TEST_FUELCAPACITY_SHOULD_THROW_EXCEPTION_IF_NEGATIVE_OR_ZERO(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Ferrari", "F40", 25, fuelCapacity);
            }, "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        public void TEST_CONSTRUCTOR_SHOULD_RETURN_VALID_CAR()
        {
            car = new Car("Ferrari", "F40", 25, 120);

            Assert.AreEqual(car.Make, "Ferrari");
            Assert.AreEqual(car.Model, "F40");
            Assert.AreEqual(car.FuelConsumption, 25);
            Assert.AreEqual(car.FuelCapacity, 120);
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [TestCase(0)]
        [TestCase(-12)]
        [TestCase(-1)]
        public void TEST_REFUEL_METHOD_SHOULD_THROW_EXCEPTION_IF_NEGATIVE_OR_ZERO(double fuelToRefill)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefill);
            }, "Fuel amount cannot be zero or negative!");
        }

        [TestCase(20)]
        [TestCase(12)]
        [TestCase(10)]
        public void TEST_REFUEL_METHOD_SHOULD_INCREASE_FUELAMOUNT(double fuelToRefill)
        {
            car = new Car("Ferrari", "F40", 25, 120);
            double beforeRefuel = car.FuelAmount;

            car.Refuel(fuelToRefill);
            double expected = beforeRefuel + fuelToRefill;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(50)]
        [TestCase(60)]
        public void TEST_REFUEL_SHOULD_RETURN_FUELCAPACITY_IF_TANKEXCEEDED(double fuelToRefill)
        {
            car = new Car("Ferrari", "F40", 25, 40);
            car.Refuel(fuelToRefill);

            double expected = car.FuelAmount;
            double actual = car.FuelCapacity;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TEST_DRIVE_METHOD_SHOULD_DECREASE_FUELAMOUNT()
        {
            ////double fuelNeeded = (distance / 100) * this.FuelConsumption;
            //car = new Car("Ferrari", "F40", 23, 120);
            //car.Refuel(50);

            //car.Drive(30);

            //double expected = 45.4;
            //double actual = car.FuelAmount;

            //Assert.AreEqual(expected, actual);
            car = new Car("Ferrari", "F40", 6, 100);
            car.Refuel(60);
            car.Drive(40);

            double expected = 57.6;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TEST_DRIVE_METHOD_SHOULD_THROW_EXCEPTION_IF_NOT_ENOUGH_FUELAMOUNT()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(20);
            }, "You don't have enough fuel to drive!");
        }

        //[Test]
        //public void TEST_FUELAMOUNT_SHOULD_THROW_EXCEPTION_IF_NEGATIVE()
        //{
        //    MethodInfo method = typeof(Car).GetMethod("FuelAmount", BindingFlags.Instance | BindingFlags.NonPublic);

        //    object[] parameters = { -2 };

        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        object result = method.Invoke(car, parameters);
        //    }, "Fuel amount cannot be negative!");
        //}
    }
}
