using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Walls walls = new Walls();
            walls.BuildWalls(80, 30);
            walls.DrawWall();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake();
            snake.BuildSnake(p, 4, Direction.RIGHT);
            snake.DrawLine();
            snake.CountEat();

            FoodCreator foodcreator = new FoodCreator(80, 30, '$');
            Point food = foodcreator.CreateFood();
            food.DrawPoint();

            while (true)
            {
                if (walls.IsHitW(snake) || snake.IsHitTail())
                {
                    GameOver game = new GameOver();
                    snake.CountEatEnd();
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.DrawPoint();
                }

                else
                {
                    snake.MoveS();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }
            }  
            Console.ReadLine();
        }
    }
}