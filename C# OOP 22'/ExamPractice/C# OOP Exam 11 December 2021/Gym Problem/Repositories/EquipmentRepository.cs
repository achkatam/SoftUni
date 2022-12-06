namespace Gym.Repositories
{
    using Gym.Models.Equipment.Contracts;
    using Gym.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class EquipmentRepository : IRepository<IEquipment>
    {
        private ICollection<IEquipment> equipments;
        public EquipmentRepository()
        {
            this.equipments = new List<IEquipment>();
        }
        public IReadOnlyCollection<IEquipment> Models => (IReadOnlyCollection<IEquipment>)this.equipments;

        public void Add(IEquipment model) => this.equipments.Add(model);

        public IEquipment FindByType(string type) => this.equipments.FirstOrDefault(x => x.GetType().Name == type);

        public bool Remove(IEquipment model) => this.equipments.Remove(model);
    }
}
