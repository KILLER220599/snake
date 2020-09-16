using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            plst = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symb);
                plst.Add(p);
            }

        }

        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.DrawLine();

            //foreach (Point p in plst)
            //{
                //p.DrawPoint();      Ещё можем сделать так, но так как реализация метода такая же, то можно иcпользовать реализацию метода базового(родительского) класса Figure.
            //}

            Console.ForegroundColor = ConsoleColor.White;
           
        }

    }
}
