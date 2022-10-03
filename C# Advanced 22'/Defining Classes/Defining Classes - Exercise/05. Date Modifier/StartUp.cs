using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secDate = Console.ReadLine();

            int diff = DateModifier.DateTimeDifference(firstDate, secDate);

            Console.WriteLine(diff);
        }
    }
}
