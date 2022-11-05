namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public void CheckBirthday(string birthday)
        {
            if (this.Birthdate.EndsWith(birthday))
                Console.WriteLine(this.Birthdate);
        }
    }
}
