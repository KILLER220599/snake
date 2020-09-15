using System;
using System.Reflection.Metadata.Ecma335;
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


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();


            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');


            upline.DrawLine();
            downline.DrawLine();
            leftline.DrawLine();
            rightline.DrawLine();


            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }

                Thread.Sleep(150);
                snake.Move();
            }   




            Console.ReadLine();
        }


    }
}