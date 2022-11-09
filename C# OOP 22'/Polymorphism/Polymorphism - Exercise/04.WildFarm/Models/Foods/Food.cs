namespace WildFarm.Models.Foods
{

using Contracts;

    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity{get;private set;}

        //practicing Run-Time Polymorphism
        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Quantity}";
        }
    }
}
