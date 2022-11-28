namespace TemplatePattern
{
    using System;
    using TemplatePattern.Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SourDough sourdoughBread = new SourDough();
            sourdoughBread.Make();
            Console.WriteLine();
            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();
            Console.WriteLine();
            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();
        }
    }
}
