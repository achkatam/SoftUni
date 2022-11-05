namespace BorderControl.Models
{
    using System;

    using BirthdayCelebrations.Models.Interfaces;
    using BorderControl.Models.Interfaces;
    using FoodShortage.Models.Interfaces;

    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string Id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public string Birthdate { get; set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public void CheckBirthday(string birthday)
        {
            if (this.Birthdate.EndsWith(birthday))
                Console.WriteLine(this.Birthdate);
        }
    }
}
