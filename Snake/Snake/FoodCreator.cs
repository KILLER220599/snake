using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int widht;
        int height;
        char symb;

        Random random = new Random();

        public FoodCreator(int widht, int height, char symb)
        {
            this.widht = widht; // Либо можно написать widht = _widht  и т.д, но для этого надо менять название переменной в параметрах конструктора(метод FoodCreator)
            this.height = height;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, widht - 2);
            int y = random.Next(2, height - 2);
            return new Point(x, y, symb);
        }
    }
}
