﻿namespace PromotionsTests.Fakes
{
    using Promotions;
    using Promotions.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DummyProductsDatabase : IProductsDatabase
    {
        
        public List<Product> GetAll()
        {
            return new List<Product>()
           {
               new Product(1, "Test1",5),
               new Product(2, "Test2",6),
               new Product(3, "Test3",7)
           };
        }

        public void Save(List<Product> products)
        {
            this.SaveCallTimes++;
        }

        public int SaveCallTimes { get; set; }
    }
}
