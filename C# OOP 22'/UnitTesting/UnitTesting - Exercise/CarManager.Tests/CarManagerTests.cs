namespace CarManager.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new Car("Audi", "A8", 3.4, 70);
        }

        [Test]
        public void Test_Constructor_Initialize_Car_Correctly()
        {
            //Arrange
            //Act
            car = new Car("Audi", "A8", 3.4, 70);

            //Assert
            Assert.AreEqual(car.Make, "Audi");
            Assert.AreEqual(car.Model, "A8");
            Assert.AreEqual(car.FuelConsumption, 3.4);
            Assert.AreEqual(car.FuelCapacity, 70);
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_MAKE_SETTER_SHOULD_THROW_EXCEPTION_IF_NULL_OR_EMPTY(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, "A8", 3.4, 70);
            }, "Model cannot be null or empty!");
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_MODEL_SETTER_SHOULD_THROW_EXCEPTION_IF_NULL_OR_EMPTY(string model)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Audi", model, 3.4, 70);
            }, "Make cannot be null or empty!");
        }

        [TestCase(-2)]
        [TestCase(-24)]
        [TestCase(0)]
        public void TEST_FUELCONSUMPTION_SETTER_SHOULD_THROW_EXCEPTION_IF_ZERO_OR_NEGATIVE(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Audi", "A8", fuelConsumption, 70);
            }, "Fuel consumption cannot be zero or negative!");
        }

        [TestCase(-2)]
        [TestCase(-24)]
        [TestCase(0)]
        public void TEST_FUEL_CAPACITY_SETTER_SHOULD_THROW_EXCEPTION_IF_ZERO_OR_NEGATIVE(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Audi", "A8", 3.4, fuelCapacity);
            }, "Fuel capacity cannot be zero or negative!");
        }

        [TestCase(-4)]
        [TestCase(-42)]
        [TestCase(0)]
        public void TEST_REFUEL_AMOUNT_CANNOT_BE_NEGATIVE_OR_ZERO(double fuelToAdd)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToAdd);
            }, "Fuel amount cannot be zero or negative!");
        }

        [TestCase(11)]
        [TestCase(22)]
        [TestCase(26)]
        public void TEST_REFUEL_AMOUNT_INCREASES_CAR_FUEL_AMOUNT(double fuelToRefuel)
        {
            car = new Car("Audi", "A8", 3.4, 70);
            double beforeRefueling = car.FuelAmount;

            car.Refuel(fuelToRefuel);

            double expectedAmount = beforeRefueling + fuelToRefuel;

            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedAmount, actualFuelAmount);
        }

        [TestCase(74)]
        [TestCase(95)]
        public void TEST_REFUEL_RETURNS_FUELCAPACITY_WHEN_EXCEEDED(double fuelToRefuel)
        {
            car = new Car("Audi", "A8", 3.4, 70);
            car.Refuel(fuelToRefuel);

            double expected = car.FuelCapacity;
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TEST_DRIVE_SHOULD_DECREASE_CAR_FUELAMOUNT_IF_ENOUGH_FUEL()
        {
            //double fuelNeeded = (distance / 100) * this.FuelConsumption;
            car = new Car("Audi", "A8", 3.4, 70);
            //first refuel the car, by default has 0 fuel
            car.Refuel(70);

            car.Drive(45);

            double expected = car.FuelAmount - ((45 / 100) * car.FuelConsumption);
            double actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TEST_DRIVE_SHOULD_THROW_EXCEPTION_IF_NOT_ENOUGH_FUEL()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(10);
            }, "You don't have enough fuel to drive!");
        }
    }
}
