using System;
using System.Threading;

namespace CustomHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftUniHashSet customSet = new SoftUniHashSet(8);

            customSet.Add("Gosho");
            customSet.Add("Acho");
            customSet.Add("Dimitrichko");

            Console.WriteLine(customSet.Contains("Gosho"));
            Console.WriteLine(customSet.Contains("Acho"));
            Console.WriteLine(customSet.Contains("123"));
        }
    }
}
