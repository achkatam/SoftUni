namespace PersonInfo
{
    //biult-in libraries namespaces
    using System;

    //our projects' namespaces


    //downloaded libraries and framworks

    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;


        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Citizen(string name, int age, string id, string birthdate) : this(name, age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace");
                }

                name = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age gotta be a positive number!");
                }

                age = value;
            }
        }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }
    }
}
