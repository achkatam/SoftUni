namespace MoqExamples
{
    using Moq;
    using global::MoqExample;
    using System;

    public class MoqExample
    {
        static void Main(string[] args)
        {
            Mock<IDatabase> mockDb = new Mock<IDatabase>();

            IDatabase db = mockDb.Object;

            ProductService service = new ProductService(db);

            Console.WriteLine(db.GetCount);
            db.Save();

            var result = db.GetAll();
            Console.WriteLine(db.GetAll());

            db.Update(new Product());
        }
    }
}
