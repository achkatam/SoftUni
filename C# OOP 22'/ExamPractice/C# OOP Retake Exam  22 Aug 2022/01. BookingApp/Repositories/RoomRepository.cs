using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;

namespace BookingApp.Repositories
{
    public class RoomRepository : IRepository<IRoom>
    {
        private readonly ICollection<IRoom> rooms;

        public RoomRepository()
        {
            this.rooms = new List<IRoom>();
        }

        public void AddNew(IRoom model) => this.rooms.Add(model);

        public IReadOnlyCollection<IRoom> All() => (IReadOnlyCollection<IRoom>)this.rooms;

        public IRoom Select(string criteria)
            => this.rooms.FirstOrDefault(x => x.GetType().Name == criteria);
    }
}
