namespace UniversityCompetition.Models
{

    public class EconomicalSubject : Subject
    {
        private const double rate = 1.0;

        public EconomicalSubject(int subjectId, string name) 
            : base(subjectId, name, rate)
        {
        }
    }
}
