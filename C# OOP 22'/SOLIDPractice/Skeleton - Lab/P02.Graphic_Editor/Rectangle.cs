namespace P02.Graphic_Editor
{
    using System;

    using P02.Graphic_Editor.Models.Contracts;

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
