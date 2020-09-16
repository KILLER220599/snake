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
            this.height = height; // this.height означает то, что глобальной переменной height(int height)(объявляется до методов, но внутри класса) присваевается значение локальной переменной height, т.е. та, ->
            this.symb = symb;     //-> которая указывается в параметрах конструктора(метода) FoodCreator. Далее можно использовать значение глобальной переменной в данном случае только внутри класса, так как модификатор доступа переменной height private. 
        }                         // Также можно и перезаписать значение глобальной переменной как внутри того же конструктора(или метода), так и в другом конструкторе(методе).

        public Point CreateFood()
        {
            int x = random.Next(2, widht - 2);
            int y = random.Next(2, height - 2);
            return new Point(x, y, symb);
        }
    }
}
