namespace UniversityCompetition.Models
{
    public class HumanitySubject : Subject
    {
        private const double rate = 1.15;

        public HumanitySubject(int subjectId, string name) 
            : base(subjectId, name, rate)
        {
        }
    }
}
