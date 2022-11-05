namespace BorderControl.Models
{
    using System;

    using BorderControl.Models.Interfaces;

    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string Id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public void CheckId(string idToCheck)
        {
            if (this.Id.EndsWith(idToCheck))
            {
                Console.WriteLine(this.Id);
            }
        }
    }
}
