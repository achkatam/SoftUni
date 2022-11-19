namespace BookingTests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        [Test]
        public void WorkingAvailabilityTest()
        {
            Hotel hotel = new Hotel();
            DateTime startDate = new DateTime(2022, 11, 1);
            DateTime endDate = new DateTime(2022, 11, 5);

            hotel.AddReservation(startDate, endDate);

            Assert.AreEqual(1, hotel.Reservations.Count);

            Assert.AreEqual(startDate, hotel.Reservations[0].StartDate);
            Assert.AreEqual(endDate, hotel.Reservations[0].EndDate);

        }


        [Test]
        public void MultipleBookings()
        {
            Hotel hotel = new Hotel();
            DateTime startDate = new DateTime(2022, 11, 1);
            DateTime endDate = new DateTime(2022, 11, 5);



            hotel.AddReservation(startDate.AddDays(10), endDate.AddDays(10));
            hotel.AddReservation(startDate.AddDays(25), endDate.AddDays(25));
            hotel.AddReservation(startDate.AddDays(56), endDate.AddDays(56));


            Assert.AreEqual(3, hotel.Reservations.Count);
        }

        [Test]
        public void TryAddingOverlappingReservationShouldThrow()
        {

            Hotel hotel = new Hotel();
            DateTime startDate = new DateTime(2022, 11, 1);
            DateTime endDate = new DateTime(2022, 11, 5);

            hotel.AddReservation(startDate, endDate);

            DateTime secondstartDate = new DateTime(2022, 11, 4);
            DateTime secondEndDate = new DateTime(2022, 11, 7);

            Assert.Throws<ArgumentException>(() =>
            {

                hotel.AddReservation(secondstartDate, secondEndDate);
            });


        }
    }
}