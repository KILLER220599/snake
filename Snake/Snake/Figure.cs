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

        public bool IsHitF(Figure figure)
        {
            foreach (var p in plst)
            {
                if (figure.IsHitP(p))
                    return true;
            }
            return false;
        }

        public bool IsHitP(Point point)
        {
            foreach (var p in plst)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}