namespace Game
{
    using Game.Contracs;
    using Game.Contracs.Drawers;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawables = new List<IDrawable>();


            drawables.Add(new Bird());
            drawables.Add(new Column());

           // IDrawer drawer = new ConsoleDrawer();
            IDrawer drawer = new TextDrawer("../../../text.txt");

            //flappy bird 
            while (true) 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Flap");

                foreach (IDrawable drawable in drawables)
                {
                    drawable.Draw(drawer);
                }
            }

        }
    }
}
