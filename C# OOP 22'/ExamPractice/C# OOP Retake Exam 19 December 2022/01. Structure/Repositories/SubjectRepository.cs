namespace UniversityCompetition.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories.Contracts;

    public class SubjectRepository : IRepository<ISubject>
    {
        private readonly ICollection<ISubject> subjects;

        public SubjectRepository()
        {
            this.subjects = new List<ISubject>();
        }

        public IReadOnlyCollection<ISubject> Models => (IReadOnlyCollection<ISubject>)this.subjects;

        public void AddModel(ISubject model)
            => this.subjects.Add(model);

        public ISubject FindById(int id) 
            => this.subjects.FirstOrDefault(x => x.Id == id);

        public ISubject FindByName(string name)
            => this.subjects.FirstOrDefault(x => x.Name == name);
    }
}
