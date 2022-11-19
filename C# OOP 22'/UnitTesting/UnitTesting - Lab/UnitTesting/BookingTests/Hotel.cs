namespace BookingTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using System.Text;

    public class Hotel
    {
        public Hotel()
        {
            this.Reservations = new List<Reservation>();
        }
        public List<Reservation> Reservations { get; set; }

        public void AddReservation(DateTime startDate, DateTime endDate)
        {
            foreach (var reservation in this.Reservations)
            {
                bool overlap = reservation.StartDate < endDate && startDate < reservation.EndDate;

                if (overlap)
                {
                    throw new ArgumentException($"Hotel is already booked out for {startDate} and {endDate}!");
                }
            }

            this.Reservations.Add(new Reservation() { StartDate = startDate, EndDate = endDate});
        }
    }
}
