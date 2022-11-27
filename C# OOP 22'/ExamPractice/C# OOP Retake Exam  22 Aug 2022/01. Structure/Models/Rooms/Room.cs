namespace BookingApp.Models.Rooms
{
    using System;

    using BookingApp.Models.Rooms.Contracts;
    using BookingApp.Utilities.Messages;

    public class Room : IRoom
    {
        private int bedCapacity;
        private double pricePerNight;

        public Room(int bedCapacity)
        {
            this.bedCapacity = bedCapacity;
            pricePerNight= 0;
        }
        public int BedCapacity => this.bedCapacity;

        public double PricePerNight
        {
            get => this.pricePerNight;
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);

                this.pricePerNight = value;
            }
        }

        public void SetPrice(double price) => this.PricePerNight = price;
    }
}
