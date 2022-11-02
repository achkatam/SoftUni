namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Person> people;
        private static List<Product> products;

        static void Main(string[] args)
        {
            people = new List<Person>();
            products = new List<Product>();

            RunEngine();
        }

        static void RunEngine()
        {
            try
            {
                AddPeople();
                CreateProducts();

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] input = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = input[0];
                    string productName = input[1];

                    Person customer = people.FirstOrDefault(x => x.Name == personName);
                    Product product = products.FirstOrDefault(x => x.Name == productName);

                    customer.AddProduct(product);

                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        static void AddPeople()
        {
            string[] personData = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in personData)
            {
                string[] personInfo = person
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                Person customer = new Person(personInfo[0], decimal.Parse(personInfo[1]));

                people.Add(customer);
            }
        }

        static void CreateProducts()
        {
            string[] productsData = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productsData)
            {
                string[] productInfo = product
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                Product newProduct = new Product(productInfo[0], decimal.Parse(productInfo[1]));

                products.Add(newProduct);
            }
        }
    }
}
