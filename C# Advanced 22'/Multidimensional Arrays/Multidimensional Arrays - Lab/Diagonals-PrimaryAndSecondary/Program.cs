using System;

namespace Diagonals_PrimaryAndSecondary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRIMARY DIAGONAL
            int[,] matrix = new int[,]
            {
                    {1,2,3,4 },
                    {5,6,7,8},
                    {9,10,11,12},
                    {13,14,15,16},
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(matrix[row, row]);
            }


            //SECONDARY DIAGONAL - the oposite way of the primary diagonal

            int[,] opMatrix = new int[,]
            {
                {1,2,3,4 },
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16},
            };

            for (int row = 0; row < opMatrix.GetLength(0); row++)
            {
                //Each time subtract 1 - row, so it goes from last top num down to 1st left num
                Console.WriteLine(opMatrix[row, opMatrix.GetLength(0) - row - 1]);
            }
        }
    }
}
