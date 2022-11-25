namespace Promotions
{
    public class Product
    {
        public Product(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
         
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id} -- Name: {this.Name} -- Price: {this.Price:f2}";
        }
    }
}