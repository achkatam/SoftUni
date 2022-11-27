namespace BookingApp.Models.Hotels
{
    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Models.Hotels.Contacts;
    using BookingApp.Models.Rooms.Contracts;
    using BookingApp.Repositories;
    using BookingApp.Repositories.Contracts;
    using BookingApp.Utilities.Messages;
    using System;
    using System.Security.Cryptography.X509Certificates;

    public class Hotel : IHotel
    {
        private string fullName;
        private int category;
        private double tunover;
        private IRepository<IRoom> rooms;
        private IRepository<IBooking> bookings;

        public Hotel(string fullName, int category)
        {
            this.FullName = fullName;
            this.Category = category;
            this.rooms = new RoomRepository();
            this.bookings= new BookingRepository();
        }

        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);

                this.fullName = value;
            }
        }

        public int Category
        {
            get => this.category;
            private set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);

                this.category = value;
            }
        }

        public double Turnover
        {
            get
            {
                double turnover = 0;
                foreach (var booking in bookings.All())
                {
                    turnover += Math.Round(booking.ResidenceDuration * booking.Room.PricePerNight, 2);
                }

                return turnover;
            }
        }
        public IRepository<IRoom> Rooms => this.rooms;

        public IRepository<IBooking> Bookings => this.bookings;
    }
}
