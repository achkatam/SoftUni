namespace Formula1.Repositories
{
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PilotRepository : IRepository<IPilot>
    {

        private List<IPilot> models;

        public PilotRepository()
        {
            this.models = new List<IPilot>() ;
        }

        public IReadOnlyCollection<IPilot> Models => this.models.AsReadOnly();

        public void Add(IPilot model)
            => this.models.Add(model);

        public IPilot FindByName(string name)
            => this.models.FirstOrDefault(x => x.FullName == name);

        public bool Remove(IPilot model)
            => this.models.Remove(model);
    }
}
