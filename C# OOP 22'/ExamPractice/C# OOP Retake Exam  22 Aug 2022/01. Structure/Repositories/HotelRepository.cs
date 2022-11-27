namespace BookingApp.Repositories
{
    using BookingApp.Models.Hotels.Contacts;
    using BookingApp.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HotelRepository : IRepository<IHotel>
    {
        private List<IHotel> hotels;

        public HotelRepository()
        {
            this.hotels = new List<IHotel>();
        }

        public void AddNew(IHotel model)
            => this.hotels.Add(model);

        public IReadOnlyCollection<IHotel> All()
            => this.hotels.AsReadOnly();

        public IHotel Select(string hotelName)
            => this.hotels.FirstOrDefault(x => x.FullName== hotelName);
    }
}
