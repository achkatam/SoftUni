using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BookigApp.Tests
{
    public class Tests
    {
        private Hotel hotel;
        private IReadOnlyCollection<Room> rooms;
        private Room room;

        [SetUp]
        public void Setup()
        {
            hotel = new Hotel("Ocean Terrace", 5);
            room = new Room(4, 24);
        }

        [Test]
        public void TEST_CONSTRUCTOR_SHOULD_CREATE_HOTEL_CORRECTLY()
        {
            string expectedName = "Ocean Terrace";
            string actualName = hotel.FullName;

            int expectedCategory = 5;
            int actualCategory = hotel.Category;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedCategory, actualCategory);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_NAME_SHOULD_TRHOW_EXCPETION_IF_NULL_WHITESPACE(string fullName)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                hotel = new Hotel(fullName, 4);
            });
        }

        [Test]
        public void TEST_NAME_SHOULD_BE_COORECT()
        {
            string expectedName = "Ocean Terrace";
            string actualName = hotel.FullName;

            Assert.AreEqual(expectedName, actualName);
        }
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(4)]
        public void TEST_CATEGORY_SHOULD_BE_ONE_TO_FIVE(int category)
        {
            hotel = new Hotel("Ocean", category);
            Assert.AreEqual((int)category, hotel.Category);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-10)]
        public void TEST_CATEGORY_BELOW_ONE_SHOULD_TRHOW_EXCEPTION(int category)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel = new Hotel("Ocean", category);
            });
        }

        [TestCase(40)]
        [TestCase(6)]
        [TestCase(10)]
        public void TEST_CATEGORY_OVER_FIVE_SHOULD_TRHOW_EXCEPTION(int category)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel = new Hotel("Ocean", category);
            });
        }

        [Test]
        public void TEST_TURNOVER()
        {
            Assert.AreEqual(0, hotel.Turnover);
        }

        [Test]
        public void TEST_ROOMS_IS_READONLY_COLLECTION()
        {
            var exoectedCollection = hotel.Rooms;
            Assert.True(exoectedCollection is IReadOnlyCollection<Room>);
        }

        [Test]
        public void TEST_BOOKINGS_IS_READONLY_COLLECTION()
        {
            var expectedCollection = hotel.Bookings;
            Assert.True(expectedCollection is IReadOnlyCollection<Booking>);
        }

        [Test]
        public void TEST_ADDMETHOD_SHOULD_INCREASE_ROOMS_COUNT()
        {
            var roomToCheck = new Room(4, 4);
            hotel.AddRoom(roomToCheck);

            int expectedCount = 1;
            int actualCount = hotel.Rooms.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TEST_ADDBOOKING_SHOULD_ADD_TO_TTHE_COLLECTION()
        {
            hotel.AddRoom(room);
            hotel.BookRoom(2, 2, 2, 200);
            Assert.AreEqual(hotel.Bookings.Count, 1);
        }

        [TestCase(0, 2, 3, 233)]
        [TestCase(-2, 2, 3, 233)]
        [TestCase(-6, 2, 3, 233)]
        public void TEST_ADDBOOKING_ADULTS_SHOULD_TRHOW_EXCEPTION_IF_ZERO_OR_NEGATIVE(int adults, int children, int duration, double budget)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, duration, budget);
            });
        }

        [TestCase(1, -2, 3, 233)]
        [TestCase(2, -12, 3, 233)]
        [TestCase(6, -22, 3, 233)]
        public void TEST_ADDBOOKING_CHILDREN_S_SHOULD_TRHOW_EXCEPTION_IF__NEGATIVE(int adults, int children, int duration, double budget)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, duration, budget);
            });
        }
        [TestCase(2, 2, -3, 233)]
        [TestCase(2, -12, 0, 233)]
        [TestCase(6, -22, -1, 233)]
        public void TEST_ADDBOOKING_DURATION_SHOULD_TRHOW_EXCEPTION_IF_ZERO_OR_NEGATIVE(int adults, int children, int duration, double budget)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, duration, budget);
            });
        }

        [Test]
        public void TEST_HOTEL_BOOKROOM_DOESNT_BOOKIFCAPACITY_LOWER_THAN_BEDS_NEEDED()
        {
            hotel.AddRoom(room);
            hotel.BookRoom(4, 4, 4,4200);
            Assert.AreEqual(hotel.Bookings.Count, 0);
        }

        [Test]
        public void TEST_BOOKROOM_GENERATES_TURNOVERS_CORRECLTY()
        {
            int residenceDuration = 4;
            double pricePerNight = room.PricePerNight;
            double expectedTurnover = residenceDuration * pricePerNight;

            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, residenceDuration, 200.0);
            Assert.AreEqual(expectedTurnover, hotel.Turnover);
        }
    }
}