using System;
using System.Linq;
using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;

namespace BookingApp.Models.Hotels
{
    public class Hotel : IHotel
    {
        private string fullName;
        private int category;
        private IRepository<IRoom> roomRepository;
        private IRepository<IBooking> bookingRepository;

        public Hotel(string fullName, int category)
        {
            this.FullName = fullName;
            this.Category = category;
            this.roomRepository = new RoomRepository();
            this.bookingRepository = new BookingRepository();
        }

        public string FullName

        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);

                fullName = value;
            }
        }

        public int Category
        {
            get { return category; }
            private set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);

                this.category = value;
            }
        }

        public double Turnover 
            => this.Bookings.All().Sum(x => Math.Round(x.ResidenceDuration * x.Room.PricePerNight, 2));

        public IRepository<IRoom> Rooms => this.roomRepository;

        public IRepository<IBooking> Bookings => this.bookingRepository;
    }
}
