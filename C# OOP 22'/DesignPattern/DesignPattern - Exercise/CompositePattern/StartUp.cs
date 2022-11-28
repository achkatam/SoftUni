namespace CompositePattern
{
    using CompositePattern.Models;
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            GiftBase phone = new SingleGift("Phone", 256);
            phone.GetTotalPrice();
            Console.WriteLine();

            CompositeGift rootBox = new CompositeGift("Rootbox", 0);
            GiftBase truckToy = new SingleGift("Truck", 289);
            GiftBase planeToy = new SingleGift("Plane", 587);

            rootBox.Add(truckToy);
            rootBox.Add(planeToy);

            CompositeGift childBox = new CompositeGift("ChildBox", 0);
            GiftBase soldierToy = new SingleGift("Soldier", 200);
            childBox.Add(soldierToy);

            rootBox.Add(childBox);

            Console.WriteLine($"The total price of this composite gift is: {rootBox.GetTotalPrice()}");
        }
    }
}
