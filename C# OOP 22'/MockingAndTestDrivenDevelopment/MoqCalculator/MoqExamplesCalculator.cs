namespace MoqCalculator
{
    using System;

    using Moq;

    public class MoqExamplesCalculator
    {
        static void Main(string[] args)
        {
            Mock<ICalculator> mockCalculator = new Mock<ICalculator>();

            ICalculator calc = mockCalculator.Object;

            mockCalculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int a, int b) =>
                {
                    Console.WriteLine($"a: {a} + b: {b} = {a+b}");
                    return a + b;
                });

            Console.WriteLine(calc.Add(5, 6));//return 11
        }
    }
    public interface ICalculator
    {
        int Add(int x, int y);
    }
}
