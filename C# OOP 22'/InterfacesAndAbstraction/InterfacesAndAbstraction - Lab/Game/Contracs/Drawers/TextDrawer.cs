using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Game.Contracs.Drawers
{
    class TextDrawer : IDrawer
    {
        private string path;

        public TextDrawer(string path)
        {
            this.path = path;
        }

        public void Write(string message)
        {
            using (StreamWriter write = new StreamWriter(path, true))
            {
                write.Write(message);
            }
        }

        public void WriteAt(string message, int x, int y)
        {
            using (StreamWriter write = new StreamWriter(path, true))
            {
                write.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter write = new StreamWriter(path, true))
            {
                write.WriteLine(message);
            }
        }
    }
}
