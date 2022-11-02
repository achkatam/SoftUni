﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Contracs
{
     interface IDrawer
    {
        void Write(string message);

        void WriteLine(string message);

        void WriteAt(string message, int x ,int y);
    }
}
