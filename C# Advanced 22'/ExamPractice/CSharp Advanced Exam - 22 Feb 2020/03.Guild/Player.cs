using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace Guild
{
    public class Player
    {
        //•	Name: string
        //•	Class: string
        //•	Rank: string – "Trial" by default
        //•	Description: string – "n/a" by default
        //The class constructor should receive name and class. Override the ToString() method in the following format:
        //"Player {Name}: {Class}
        //Rank: {Rank }
        //    Description: {Description}"

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.AppendLine($"Description: {Description}");

            return sb.ToString().Trim();
        }

    }
}
