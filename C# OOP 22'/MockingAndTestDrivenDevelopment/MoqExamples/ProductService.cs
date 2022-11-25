namespace MoqExamples
{ 
    public class ProductService
    {
        private IDatabase database;

        public ProductService(IDatabase database)
        {
            this.database = database;
        }
    }
}
