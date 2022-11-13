namespace DependancyInjection
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DateTime(2022,11,7));

            store.Buy(new Product());
        }
    }
}
