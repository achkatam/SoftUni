namespace Promotions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Promotions.Contracts;

    public class TextProductDatabase : IProductsDatabase
    {
        private string path;
        public TextProductDatabase(string path = "../../../products.txt")
        {
            this.path = path;
        }
        public List<Product> GetAll()
        {
           using (StreamReader reader = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
            }
        }

        public void Save(List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(JsonConvert.SerializeObject(products, Formatting.Indented));
            };

        }
    }
}
