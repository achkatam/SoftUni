namespace CompositePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DrawingUtilities
    {
        public static void DrawMatrx(char[,] shape, Position position)
        {
            for (int row = 0; row < shape.GetLength(0); row++)
            {
                for (int col = 0; col < shape.GetLength(1); col++)
                {
                    Console.SetCursorPosition(position.Left + col, position.Top + row);
                    Console.WriteLine(shape[row, col]);
                }
            }
        }
        
    
    }
}
