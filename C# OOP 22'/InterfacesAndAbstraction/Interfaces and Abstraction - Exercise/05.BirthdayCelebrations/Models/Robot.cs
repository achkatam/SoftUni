namespace BorderControl.Models
{
    using BorderControl.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Robot : IIdentifiable
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name {get;set;}

        public string Id   { get; set; }

        public void CheckId(string idToCheck)
        {
            if (this.Id.EndsWith(idToCheck))
            {
                Console.WriteLine(this.Id);
            }
        }
    }
}
