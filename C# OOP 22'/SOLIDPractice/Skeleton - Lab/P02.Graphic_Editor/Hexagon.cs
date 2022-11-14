namespace P02.Graphic_Editor
{
    using P02.Graphic_Editor.Models.Contracts;

    public class Hexagon : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Drawing the hexagon..");
        }
    }
}
