using System;
using System.Collections.Generic;
using System.Text;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        private double price;

        public Room(int bedCapacity)
        {
            this.BedCapacity = bedCapacity;
        }
        public int BedCapacity { get; private set; }

       
        public double PricePerNight
        {
            get { return price; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);

                this.price = value;
            }
        }

        public void SetPrice(double price)
            => this.PricePerNight = price;
    }
}
