﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class CollisionPoint
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public CollisionPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
