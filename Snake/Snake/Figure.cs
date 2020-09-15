using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> plst;

        public void DrawLine()
        {
            foreach (Point p in plst)
            {
                p.DrawPoint();
            }
        }
    }
}