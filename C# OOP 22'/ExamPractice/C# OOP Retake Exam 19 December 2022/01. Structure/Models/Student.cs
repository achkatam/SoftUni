namespace UniversityCompetition.Models
{
    using System;
    using System.Collections.Generic; 
    using UniversityCompetition.Models.Contracts; 
    using UniversityCompetition.Utilities.Messages;

    public abstract class Student : IStudent
    {
        private int studentId;
        private string firstName;
        private string lastName; 
        private List<int> exams;
        private IUniversity uni;

        public Student()
        {

        }
        public int Id
        {
            get { return studentId; }
            private set
            {
                studentId++;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);

                this.firstName= value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);

                this.lastName = value;
            }
        }

        public IReadOnlyCollection<int> CoveredExams => this.exams;

        public IUniversity University => this.uni;

        public void CoverExam(ISubject subject)
        {
            this.exams.Add(subject.Id);
        }

        public void JoinUniversity(IUniversity university)
            => this.uni = university;
    }
}
