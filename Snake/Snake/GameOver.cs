using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class GameOver : Walls
    {
        public GameOver()
        {

            //Walls wall = new Walls(); // Мы принимаем новые значения(то есть width и height у нас будут по 0), так как создаём новый объект класса, у которого новые переменные,то есть мы создали объект класса,
            // в которм ничего нет, он нигде не использовался и т.д. Поэтому ниже мы не можем поставить рамки, в зависимости от значений, которые ввёл пользователь.
            //Console.SetWindowSize(wall.width, wall.height); // Сдесь создали обьект класса Wall, потом взяли значения глобальных переменных width и height из класса Wall для того,
            //Console.SetBufferSize(wall.width, wall.height); чтобы вывод после окончания игры выводился в центре экрана, в зависимости от того, какой размер окна установит пользователь. 
            //Console.SetCursorPosition((wall.width / 2) - 15, wall.height / 2); Но этот способ не работает. Выдаёт ошибку. Также попробовал сделать в методе CountEat класса Snake.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25, 15);
            Console.WriteLine("Конец игры. Ждём Вас снова!");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(30, 16);
            //Console.WriteLine("Count of eat: " + snake.count);


            //Console.SetWindowSize(width, height);
            //Console.SetBufferSize(width, height);
            //Console.SetCursorPosition((width / 2) - 15, height / 2);
        }
    }
}
