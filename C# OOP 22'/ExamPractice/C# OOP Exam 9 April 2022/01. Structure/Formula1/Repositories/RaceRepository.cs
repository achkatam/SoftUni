namespace Formula1.Repositories
{
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RaceRepository : IRepository<IRace>
    {

        private List<IRace> models;
        public IReadOnlyCollection<IRace> Models => this.models.AsReadOnly();

        public void Add(IRace model)
            => this.models.Add(model);

        public IRace FindByName(string name)
            => this.models.FirstOrDefault(x => x.RaceName == name);

        public bool Remove(IRace model)
            => this.models.Remove(model);
    }
}
