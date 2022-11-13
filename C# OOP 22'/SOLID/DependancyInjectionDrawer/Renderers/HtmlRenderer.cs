namespace DependancyInjectionDrawer.Renderers
{
    using System;
    using System.IO;
    using System.Text;

    public class HtmlRenderer : IRenderer
    {
        private StringBuilder sb = new StringBuilder();
        private string path = "../../../index.html";

        public void Write(object text)
        {
            sb.Append(text);
            var htmlText = $"<html><head></head><body>{sb}</body></html>";
            using (var writer = new StreamWriter(path, false))
            {
                writer.Write(htmlText);
            }
        }

        public void WriteAt(int y, int x)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(object text)
        {
            sb.Append($"<div>{text.ToString()}</div>");

            var htmlText = $"<html><head></head><body>{sb}</body></html>";
            using (var writer = new StreamWriter(path, false))
            {
                writer.Write(htmlText);
            }
        }
    }
}
