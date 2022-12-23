namespace UniversityCompetition.Models
{
    using System;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Utilities.Messages;

    public abstract class Subject : ISubject
    {
        private int subjectId;
        private string name;
        private double subjectRate;

        protected Subject(int subjectId, string name, double subjectRate)
        {
            this.Id = subjectId;
            this.Name = name;
            this.Rate = subjectRate;
        }

        public int Id
        {
            get { return subjectId; }
            private set
            {
                this.subjectId++;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                this.name = value;
            }
        }

        public double Rate
        {
            get { return this.subjectRate; }
            private set
            {
                this.subjectRate = value;
            }
        }
    }
}
