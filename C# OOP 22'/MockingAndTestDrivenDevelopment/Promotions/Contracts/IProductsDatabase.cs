namespace Promotions.Contracts
{

    using System.Collections.Generic;

    public interface IProductsDatabase
    {
        public void Save(List<Product> products);
        public List<Product> GetAll();
    }
}
