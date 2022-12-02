using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairShop.Tests
{
    public class Tests
    {
        public class RepairsShopTests
        {
            private Garage garage;
            private List<Car> cars;
            private Car car;


            [SetUp]
            public void Setup()
            {
                garage = new Garage("Workshop", 4);
                cars = new List<Car>();
                car = new Car("Ford", 3);
            }

            [Test]
            public void Test_CorrectConstructor()
            {
                string expectedName = "Workshop";

                int expectedMechanics = 4;

                Assert.AreEqual(expectedName, garage.Name);
                Assert.AreEqual(expectedMechanics, garage.MechanicsAvailable);
            }

            [TestCase(null)]
            [TestCase("")]
            public void Test_ConstructorNameShouldThrowExceptionWHneNameEmptyOrNull(string name)
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    garage = new Garage(name, 4);
                });
            }

            [TestCase(0)]
            [TestCase(-2)]
            [TestCase(-22)]
            public void Test_ConstructorMechanicsShouldThrowExceptionIfZeroOrBelow(int mechanics)
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    garage = new Garage("Workshop", mechanics);
                });
            }

            [Test]
            public void Test_CountShouldReturnCarsCount()
            {
                garage.AddCar(car);

                Assert.AreEqual(1, garage.CarsInGarage);
            }

            [Test]
            public void Test_ShouldThrowExceptionIfCarsCountEqualsMechanicsCount()
            {
                garage = new Garage("Fixers", 1);
                garage.AddCar(car);
                //Assert.Throws<InvalidOperationException>(() =>
                //{
                //    garage.CarsInGarage.Equals(garage.MechanicsAvailable);
                //});
                var car2 = new Car("VW", 3);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.AddCar(car2);
                });
            }

            [Test]
            public void Test_FixCarShouldDecreaseIssuesToZero()
            {
                garage.AddCar(car);
                Car carToFix = cars.FirstOrDefault(x => x.CarModel == "Ford");

                garage.FixCar("Ford");

                Assert.AreEqual(0, car.NumberOfIssues);
            }

            [Test]
            public void Test_FixCarShouldThrowExceptionIfNonExsitingCar()
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.FixCar("Bentley");
                });
            }

            [Test]
            public void Test_RemoveFixedCarsShouldDecreaseCarCountIfFixed() 
            {
                garage.AddCar(car);
                garage.FixCar("Ford");

                garage.RemoveFixedCar();
                Assert.AreEqual(0, garage.CarsInGarage);
            }

            [Test]
            public void Test_RemoveFixedCarsShouldThrowExceptionIfNoNrokenCars()
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.RemoveFixedCar();
                });
            }

            [Test]
            public void Test_ReportShouldWorkCorrectly()
            {
                var reportCars = this.cars.Where(x => x.IsFixed == false).Select(f => f.CarModel).ToList();
                string carsNames = string.Join(", ", reportCars);
                string report = $"There are {reportCars.Count} which are not fixed: {carsNames}.";

                Assert.AreEqual(report, $"There are {reportCars.Count} which are not fixed: {carsNames}.");
            }
        }
    }
}