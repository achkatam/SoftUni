namespace UniversityCompetition.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories.Contracts;

    public class UniversityRepository : IRepository<IUniversity>
    {
        private readonly ICollection<IUniversity> univeristies;

        public UniversityRepository()
        {
            this.univeristies = new List<IUniversity>();
        }

        public IReadOnlyCollection<IUniversity> Models => (IReadOnlyCollection<IUniversity>)this.univeristies;

        public void AddModel(IUniversity model)
            => this.univeristies.Add(model);

        public IUniversity FindById(int id)
            => this.univeristies.FirstOrDefault(x => x.Id == id);

        public IUniversity FindByName(string name)
            => this.univeristies.FirstOrDefault(x => x.Name == name);
    }
}
