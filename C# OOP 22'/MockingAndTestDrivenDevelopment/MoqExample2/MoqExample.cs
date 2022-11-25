namespace MoqExample2
{
    using Moq;
    using System;

    public class MoqExample
    {
        static void Main(string[] args)
        {
           Mock<ICalculator> mockCalculator = new Mock<ICalculator>();

            mockCalculator.Setup(c => c.Add(5, 6)).Returns(155);

            Console.WriteLine( mockCalculator.Object.Add(5, 6));//returns 155
            Console.WriteLine( mockCalculator.Object.Add(5, 7));//returns 0

            mockCalculator.Setup(c => c.Add(5, 6)).Returns(155);

            mockCalculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(155);
            Console.WriteLine(mockCalculator.Object.Add(5, 7));//returns 155


            mockCalculator.Setup(c => c.Add(5, 6)).Returns(11);
            Console.WriteLine(mockCalculator.Object.Add(5, 6));//11

            mockCalculator.Setup(c => c.ToString()).Returns("Best calculator ever!");
            Console.WriteLine(mockCalculator.Object);



            mockCalculator.Setup(c => c.Add(-1, -1))
                .Throws<ArgumentException>();
            Console.WriteLine(mockCalculator.Object.Add(-1, -1));//throws exception

        }
    }

    public interface ICalculator
    {
        int Add(int x, int y);
    }
}
