namespace UniversityCompetition.Repositories
{ 
    using System.Collections.Generic;
    using System.Linq;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories.Contracts;

    public class StudentRepository : IRepository<IStudent>
    {
        private readonly ICollection<IStudent> students;

        public StudentRepository()
        {
            this.students = new List<IStudent>();
        }

        public IReadOnlyCollection<IStudent> Models => (IReadOnlyCollection<IStudent>)this.students;    

        public void AddModel(IStudent model)
            =>this.students.Add(model);

        public IStudent FindById(int id)
            => this.students.FirstOrDefault(x => x.Id == id);

        public IStudent FindByName(string name)
        {
            string[] studentName = name.Split(" ");
            string firstName = studentName[0];
            string lastName = studentName[1];

            return this.students.FirstOrDefault(x => x.FirstName == firstName
            && x.LastName == lastName);
        }
            
    }
}
