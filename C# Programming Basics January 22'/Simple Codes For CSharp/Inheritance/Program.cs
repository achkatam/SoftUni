using System;

namespace Inheritance
{
    public class Chef
    {
        //I N H E R I T A N C E
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
    }
    public class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine($"The Chef is making chicken parm dinner.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSalad();

            ItalianChef italian = new ItalianChef();
            italian.MakeSalad();
            Console.WriteLine();
            chef.MakeSpecialDish();

            Console.WriteLine();
            italian.MakeSpecialDish();

        }
    }
}
