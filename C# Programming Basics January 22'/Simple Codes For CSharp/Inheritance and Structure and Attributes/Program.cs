using System;
using System.Collections;
using Inheritance_Structure_Attributes;


namespace Inheritance_Structure_Attributes
{
    public class Chef
    {
        //I N H E R I T A N C E S T R U C T U R E A T T R I B U T E S
        public string name;
        public int age;

        public Chef(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef is making a salad.");
        }
        public void MakeSoup()
        {
            Console.WriteLine($"The Chef is making a soup.");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine($"The Chef is making empanadas");
        }

        public virtual void Cooking()
        {
            Console.WriteLine($"Chef {name} is {age} years old.");
        }
    }
    public class ItalianChef : Chef
    {
        public string CountryOfOrigin;
        public ItalianChef(string name, int age, string country)
            : base(name, age)
            
        {
            this.CountryOfOrigin = country;
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine($"The Chef is making chicken parm dinner.");
        }
        public override void Cooking()
        {
            Console.WriteLine($"Chef {name} is {age} years old and comes from {CountryOfOrigin}");
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef("Gordon Ramsey",50);
        chef.MakeSalad();

        ItalianChef italian = new ItalianChef("Gordini Ramsini", 36, "Italy");
        italian.MakeSalad();
        Console.WriteLine();
        chef.MakeSpecialDish();

        Console.WriteLine();
        italian.MakeSpecialDish();

        chef.Cooking();
        italian.Cooking();

    }
}



