using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private IRepository<IHotel> hotelRepository;

        public Controller()
        {
            this.hotelRepository = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            IHotel hotel = this.hotelRepository.Select(hotelName);

            if (hotel != null)
            {
                return string.Format(OutputMessages.HotelAlreadyRegistered, hotelName);
            }

            hotel = new Hotel(hotelName, category);
            this.hotelRepository.AddNew(hotel);

            return string.Format(OutputMessages.HotelSuccessfullyRegistered, category, hotelName);
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            IHotel hotel = this.hotelRepository.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return string.Format(OutputMessages.RoomTypeAlreadyCreated);
            }

            IRoom room = null;

            switch (roomTypeName)
            {
                case "Studio":
                    room = new Studio();
                    break;
                case "DoubleBed":
                    room = new DoubleBed();
                    break;
                case "Apartment":
                    room = new Apartment();
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }

            hotel.Rooms.AddNew(room);

            return string.Format(OutputMessages.RoomTypeAdded, roomTypeName, hotelName);
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            IHotel hotel = this.hotelRepository.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            var roomTypes = new string[] { "Studio", "Apartment", "DoubleBed" };

            if (!roomTypes.Contains(roomTypeName))
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }

            if (hotel.Rooms.Select(roomTypeName) == null)
            {
                return OutputMessages.RoomTypeNotCreated;
            }

            if (hotel.Rooms.Select(roomTypeName).PricePerNight > 0)
                throw new InvalidOperationException(ExceptionMessages.PriceAlreadySet);

            foreach (var room in hotel.Rooms.All().Where(x => x.GetType().Name == roomTypeName))
            {
                room.SetPrice(price);
            }

            return string.Format(OutputMessages.PriceSetSuccessfully, roomTypeName, hotelName);
        }
        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            var hotels = this.hotelRepository.All().Where(x => x.Category == category)
                .OrderBy(x => x.FullName).ToList();

            if (!hotels.Any())
            {
                return string.Format(OutputMessages.CategoryInvalid, category);
            }

            var rooms = new List<IRoom>();

            foreach (var hotel in hotels)
            {
                foreach (var room in hotel.Rooms.All().Where(x => x.PricePerNight > 0))
                {
                    rooms.Add(room);
                }
            }

            rooms = rooms.OrderBy(x => x.BedCapacity).ToList();

            int totalGuests = adults + children;

            var validRoom = rooms.FirstOrDefault(x => x.BedCapacity >= totalGuests);

            if (validRoom == null)
            {
                return OutputMessages.RoomNotAppropriate;
            }

            IHotel validHotel = hotels.FirstOrDefault(x => x.Rooms.All().Contains(validRoom));
            int bookingNumber = validHotel.Bookings.All().Count() + 1;
            IBooking booking = new Booking(validRoom, duration, adults, children, bookingNumber);

            validHotel.Bookings.AddNew(booking);

            return string.Format(OutputMessages.BookingSuccessful, bookingNumber, validHotel.FullName);
        }

        public string HotelReport(string hotelName)
        {
            var sb = new StringBuilder();

            IHotel hotel = this.hotelRepository.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            sb
                .AppendLine($"Hotel name: {hotelName}")
                .AppendLine($"--{hotel.Category} star hotel")
                .AppendLine($"--Turnover: {hotel.Turnover:F2} $")
                .AppendLine($"--Bookings:")
                .AppendLine();

            if (hotel.Bookings.All().Any())
            {
                foreach (var booking in hotel.Bookings.All())
                {
                    sb.AppendLine(booking.BookingSummary());
                    sb.AppendLine();
                    
                }
            }
            else
            {
                sb.AppendLine("none");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
