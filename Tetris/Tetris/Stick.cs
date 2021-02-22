using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y+1, sym);
            points[2] = new Point(x, y+2, sym);
            points[3] = new Point(x, y+3, sym);
        }
        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
