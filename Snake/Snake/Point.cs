using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {

        }

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;       // Присваиваиваем глобальной переменной x(this.x) значение локальной переменной x(переменной в параметре конструктора(метода))
            this.symb = symb; // для того,чтобы использовать это значение внутри класса, а также,
                              // в данном случае, глобальные переменные можно использовать в других классах, так как стоит модификатор доступа public
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void MoveP(int offset, Direction direction)
        {
            
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }

            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }

            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            symb = ' ';
            DrawPoint();
        }
    }
}
