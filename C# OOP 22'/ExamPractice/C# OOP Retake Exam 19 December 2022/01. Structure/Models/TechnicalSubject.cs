namespace UniversityCompetition.Models
{
    public class TechnicalSubject : Subject
    {
        private const double rate = 1.3;
        public TechnicalSubject(int subjectId, string name) 
            : base(subjectId, name, rate)
        {
        }
    }
}
