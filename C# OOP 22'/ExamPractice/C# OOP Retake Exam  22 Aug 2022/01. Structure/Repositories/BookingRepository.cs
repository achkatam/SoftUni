namespace BookingApp.Repositories
{
    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class BookingRepository : IRepository<IBooking>
    {
        private List<IBooking> bookings;

        public BookingRepository()
        {
            this.bookings = new List<IBooking>();
        }

        public void AddNew(IBooking model)
        {
            this.bookings.Add(model);
        }

        public IReadOnlyCollection<IBooking> All() => this.bookings.AsReadOnly();

        public IBooking Select(string bookingNumberToString)
            => this.bookings.FirstOrDefault(x => x.BookingNumber.ToString() == bookingNumberToString);
    }
}
