namespace NavalVessels.Repositories
{
    using NavalVessels.Models.Contracts;
    using NavalVessels.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class VesselRepository : IRepository<IVessel>
    {
        private HashSet<IVessel> vessels;
        public IReadOnlyCollection<IVessel> Models => this.vessels;

        public void Add(IVessel model) => this.vessels.Add(model);

        public IVessel FindByName(string name) => this.vessels.FirstOrDefault(x => x.Name == name);

        public bool Remove(IVessel model) => this.vessels.Remove(model);
    }
}
