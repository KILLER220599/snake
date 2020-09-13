using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> plst;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            plst = new List<Point>();

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symb);
                plst.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in plst)
            {
                p.Draw();
            }
        }
    }
}
