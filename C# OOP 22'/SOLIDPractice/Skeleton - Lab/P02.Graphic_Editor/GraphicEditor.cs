namespace P02.Graphic_Editor
{

    using P02.Graphic_Editor.Models.Contracts;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
