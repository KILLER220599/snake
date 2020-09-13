using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> plst;

        public void Draw()
        {
            foreach (Point p in plst)
            {
                p.Draw();
            }
        }
    }
}
