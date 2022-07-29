using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two classes: class Person and class Product. Each person should have a name, money, and a bag of products. Each product should have a name and a cost. 

            var people = new List<Person>();
            var products = new List<Product>();

            //Create variables for people information and products information
            var peopleInfo = Console.ReadLine().Split(";",
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            var productInfo = Console.ReadLine().Split(";",
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in peopleInfo)
            {
                string[] personData = item.Split("=",
                    StringSplitOptions.RemoveEmptyEntries);

                string name = personData[0];
                double money = double.Parse(personData[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }

            foreach (var item in productInfo)
            {
                string[] productData = item.Split("="
                    , StringSplitOptions.RemoveEmptyEntries);

                string productName = productData[0];
                double price = double.Parse(productData[1]);

                Product product = new Product(productName, price);

                products.Add(product);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                //array for input[0] customer input[1] productName 
                var input = command.Split(' '
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
                string customerName = input[0];
                string productName = input[1];

                int customer = people.FindIndex(x => x.Name == customerName);
                int product = products.FindIndex(x => x.Name == productName);

                if (products[product].Price > people[customer].Money)
                {
                    Console.WriteLine($"{customerName} can't afford {productName}");
                }
                else
                {
                    people[customer].Money -= products[product].Price;
                    people[customer].ShoppingBag.Add(products[product]);

                    Console.WriteLine($"{customerName} bought {productName}");
                }

                command = Console.ReadLine();
            }

            foreach (Person person in people)
            {
                if (person.ShoppingBag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.ShoppingBag.Select(x=>x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
    class Product
    {
        public Product(string productName, double price)
        {
            Name = productName;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            ShoppingBag = new List<Product>();

        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ShoppingBag { get; set; }
    }
}
