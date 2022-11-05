namespace PersonInfo
{
    //biult-in libraries namespaces
    using System;

    //our projects' namespaces
  

    //downloaded libraries and framworks

    public class Citizen : IPerson

    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
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

      
    }
}
