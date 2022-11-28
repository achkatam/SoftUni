namespace CompositePattern.Models
{
    using System;
    using System.Collections.Generic;
 
    using CompositePattern.Contracts;

    public class CompositeGift : GiftBase, IGiftOperation
    {
        private ICollection<GiftBase> nestedGifts;
        public CompositeGift(string name, int price) 
            : base(name, price) 
        {
            this.nestedGifts= new HashSet<GiftBase>();
        }

        public void Add(GiftBase gift)
            => this.nestedGifts.Add(gift);
        public void Remove(GiftBase gift)
           => this.nestedGifts.Remove(gift);
        public override int GetTotalPrice()
        {
            int sum = 0;

            Console.WriteLine($"{this.name} contains the following products with prices:");

            foreach (GiftBase nestedGift in this.nestedGifts)
            {
                sum += nestedGift.GetTotalPrice();
            }

            return sum;
        }
    }
}
