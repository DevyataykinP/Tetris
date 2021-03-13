﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }
        private Point point;

        public void Draw()
        {
            DrawerProvier.Drawer.DrawPoint(X,Y);
        }

        public Point(int a, int b, char sym)
        {
            X = a;
            Y = b;
            C = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            C = p.C;
        }
        

        internal void Move(Direction dir)
        {
            switch (dir)
            {

                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break; 
            }
        }

        internal void Hide()
        {
            DrawerProvier.Drawer.HidePoint(X,Y);
        }
    }
}
