namespace MoqExample
{
    using NUnit.Framework;
    using Promotions;
    using System.Collections.Generic;

    public interface IDatabase
    {
        public void Save();

        public List<Product> GetAll();
        public void Update(Product product);

        public void Delete(int id);

        public int GetCount { get; }
    }
}
