
using System.Text;

namespace Person
{
    public class Person
    {
        // private string name;
        private int age;


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Name { get; set; }

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
            }
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
