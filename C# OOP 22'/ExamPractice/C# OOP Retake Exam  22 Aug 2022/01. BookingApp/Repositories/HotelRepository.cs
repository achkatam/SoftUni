using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories.Contracts;

namespace BookingApp.Repositories
{
    public class HotelRepository : IRepository<IHotel>
    {
        private readonly ICollection<IHotel> hotels;

        public HotelRepository()
        {
            this.hotels = new List<IHotel>();
        }

        public void AddNew(IHotel model) => this.hotels.Add(model);

        public IReadOnlyCollection<IHotel> All() => (IReadOnlyCollection<IHotel>)this.hotels;

        public IHotel Select(string criteria) => this.hotels.FirstOrDefault(x => x.FullName == criteria);
    }
}
