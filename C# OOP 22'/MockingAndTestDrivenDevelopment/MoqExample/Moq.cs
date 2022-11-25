namespace MoqExample
{
    using Moq;
    using NUnit.Framework;

    public class Tests
    {

        [Test]
        public void Test1()
        {
           Mock<IDatabase> mockDb = new Mock<IDatabase>();
        }
    }
}