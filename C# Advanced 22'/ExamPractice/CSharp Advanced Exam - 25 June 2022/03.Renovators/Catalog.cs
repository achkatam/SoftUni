using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        //Next, a class named Catalog is given that has a collection (renovators) of type Renovator. All the entities of the renovators collection have the same properties. The Catalog has also some additional properties:
        //•	Name: string
        //•	NeededRenovators: int
        //•	Project: string

        //The constructor of the Catalog class should receive the name, neededRenovators and project
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public string Name { get; }
        public int NeededRenovators { get; }
        public string Project { get; }
        public List<Renovator> Renovators { get; set; }

        public int Count { get { return Renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            //o	If the name or specialty are null or empty, return "Invalid renovator's information.".
            if (renovator.Name == null || renovator.Type == null
                || renovator.Name == String.Empty || renovator.Type == string.Empty) return "Invalid renovator's information.";
            //o If renovators are no more needed, return "Renovators are no more needed.".Renovators are needed when the count of the added renovators is less than the NeededRenovators property of the Catalog.
            if (Count >= NeededRenovators) return "Renovators are no more needed.";
            //o If the rate is above 350 BGN, return "Invalid renovator's rate.".
            if (renovator.Rate > 350) return "Invalid renovator's rate.";
            //o Otherwise, return: "Successfully added {renovatorName} to the catalog.".
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            return Renovators.Remove(Renovators.Find(x => x.Name == name));
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            return Renovators.RemoveAll(x => x.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = Renovators.Find(x => x.Name == name);
            if (renovator != null) renovator.Hired = true;

            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = Renovators.Where(x => x.Days >= days).ToList();

            return renovators;
        }

        public string Report()
        {
            //returns a string with information about the catalog and renovators who are not hired in the following format:	
            //"Renovators available for Project {project}:
            //{ Renovator1}
            //{ Renovator2}
            return $"Renovators available for Project {this.Project}:" + Environment.NewLine +
                string.Join(Environment.NewLine, Renovators.FindAll(x => x.Hired == false));

        }
    }
}
