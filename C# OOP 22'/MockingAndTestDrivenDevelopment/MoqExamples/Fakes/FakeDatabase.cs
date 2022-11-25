namespace MoqExample.Fakes
{
    using MoqExamples;
    
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FakeDatabase : IDatabase
    {
        public int GetCount => throw new NotImplementedException();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
