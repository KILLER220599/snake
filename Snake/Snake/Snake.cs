using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            plst = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plst.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = plst.First();
            plst.Remove(tail);
            Point head = GetNextPoint();
            plst.Add(head);

            tail.Clear();
            head.DrawPoint();
        }

        public Point GetNextPoint()
        {
            Point head = plst.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);

            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }

            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }

            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }

            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
    }
}
