using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class GameOver
    {
        public GameOver()
        {

            //Walls wall = new Walls();
            //Console.SetWindowSize(wall.width, wall.height); // Сдесь создали обьект класса Wall, потом взяли значения глобальных переменных width и height из класса Wall для того,
            //Console.SetBufferSize(wall.width, wall.height); чтобы вывод после окончания игры выводился в центре экрана, в зависимости от того, какой размер окна установит пользователь. 
            //Console.SetCursorPosition((wall.width / 2) - 15, wall.height / 2); Но этот способ не работает. Выдаёт ошибку. Также попробовал сделать в методе CountEat класса Snake.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25, 15);
            Console.WriteLine("Конец игры. Ждём Вас снова!");

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Snake snake = new Snake();
            Console.SetCursorPosition(30, 16);
            snake.CountEat();
            //Console.WriteLine("Count of eat: " + snake.count);
            
        }
    }
}
