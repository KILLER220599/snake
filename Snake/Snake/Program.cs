using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // Настроили размер окна
            Console.SetBufferSize(80, 25); // Настроили размер командной строки
            Console.CursorVisible = false; // Сделали курсор невидимым в командной строке

            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake) fSnake;

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figure = new List<Figure>();
            figure.Add(fSnake);
            figure.Add(vl);
            figure.Add(hl);

            foreach (var f in figure)
            {
                f.DrawLine();
            }


            Console.ReadLine();
        }   

        static void Draw(Figure figure)
        {
            figure.DrawLine();
        }

       
    }
}