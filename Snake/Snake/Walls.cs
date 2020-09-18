using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList; // Объявляем список в этом месте, так как этот список будет глобальным, и он понадобится в других методах
        public int width;
        public int height;

        public Walls()
        {

        }

        public void BuildWalls(int width, int height)
        {
            wallList = new List<Figure>();

            this.width = width;  // Передаём значения локальных переменных конструктора(метода) глобальным переменным,
            this.height = height; // чтобы использовать внутри класса.

            Console.SetWindowSize(width, height); // Настроили размер окна
            Console.SetBufferSize(width, height); // Настроили размер командной строки
            Console.CursorVisible = false; // Сделали курсор невидимым в командной строке

            HorizontalLine upline = new HorizontalLine(0, width - 2, 1, '+');
            HorizontalLine downline = new HorizontalLine(0, width - 2, height - 1, '+');
            VerticalLine leftline = new VerticalLine(1, height - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(1, height - 1, width - 2, '+');


            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }

        internal bool IsHitW(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHitF(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void DrawWall()
        {
            foreach (var wall in wallList)
            {
                wall.DrawLine();
            }
        }
    }
}
