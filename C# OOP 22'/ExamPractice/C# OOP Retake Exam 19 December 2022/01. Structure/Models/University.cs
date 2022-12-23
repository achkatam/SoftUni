namespace UniversityCompetition.Models
{
    using System;
    using System.Collections.Generic;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Utilities.Messages;

    public class University : IUniversity
    {
        private int uniId;
        private string name;
        private string category;
        private int capacity;
        private ICollection<int> requiredSubjects;

        public University(int uniId, string name, string category, int capacity, ICollection<int> exams)
        {
            this.Id = uniId;
            this.Name = name;
            this.Category = category;
            this.Capacity = capacity;
            this.requiredSubjects = new List<int>();
        }
        public int Id
        {
            get { return this.uniId; }
            private set
            {
                this.uniId++;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);

                this.name = value;
            }
        }

        public string Category
        {
            get { return this.category; }
            private set
            {
                if (value != "Technical" && value != "Economical" && value != "Humanity")
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.CategoryNotAllowed, value));
                }

                this.category = value;
            }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityNegative);
                }

                this.capacity = value;
            }
        }

        public IReadOnlyCollection<int> RequiredSubjects => (IReadOnlyCollection<int>)this.requiredSubjects;
    }
}
