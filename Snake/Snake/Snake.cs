using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction; // Если перед переменной не указан модификатор доступа, тогда у него будет модификатор доступа private по стандарту.
        public int count;

        public Snake()
        {

        }

        public void BuildSnake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            plst = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.MoveP(i, direction);
                plst.Add(p);
            }
        }

        internal void MoveS()
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
            nextPoint.MoveP(1, direction);

            return nextPoint;
        }

        public bool IsHitTail()
        {
            var head = plst.Last();
            for (int i = 0; i < plst.Count - 2; i++)
            {
                if (head.IsHit(plst[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch(key)
            {
                case (ConsoleKey.LeftArrow):
                    if (direction != Direction.RIGHT)
                    {
                        direction = Direction.LEFT;
                    }   
                    break;

                case (ConsoleKey.RightArrow):
                    if (direction != Direction.LEFT)
                    {
                        direction = Direction.RIGHT;
                    }
                    break;

                case (ConsoleKey.UpArrow):
                    if (direction != Direction.DOWN)
                        direction = Direction.UP;

                    break;

                case (ConsoleKey.DownArrow):
                    if (direction != Direction.UP)
                        direction = Direction.DOWN;

                    break;
            }       

        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(food))  // Если координаты еды и головы равны, то превращаем еду в символ змеи(часть тело) и добавляем в список точек змеи.
            // if head.x == food.x && head.y == food.y
            {
                food.symb = head.symb;
                food.DrawPoint();
                plst.Add(food);
                count += 1;
                CountEat();
                return true;
            }

            else
            {
                return false;
            }
        }

        public void CountEat()
        {
            //Walls wall = new Walls();
            //Console.SetWindowSize(wall.width, wall.height);
            //Console.SetBufferSize(wall.width, wall.height); // Комментарий, почему не работает такой способ изложены в классе GameOver.
            // Console.SetCursorPosition(wall.width - 13, 0);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Your count: " + count);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
