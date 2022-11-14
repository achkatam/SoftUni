namespace P02.Graphic_Editor
{
    
    using P02.Graphic_Editor.Models.Contracts;

    class Program
    {

        static void Main()
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape square = new Square();

            GraphicEditor e = new GraphicEditor();

            e.DrawShape(circle);
            e.DrawShape(rectangle);
            e.DrawShape(square);

            //Added the new shape hexagon
            IShape hexagon = new Hexagon();

            e.DrawShape(hexagon);
        }
    }
}
