using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(150, 50);
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            Console.CursorVisible = false;

            Walls walls = new Walls(148, 49);
            walls.Draw();

            Point p1 = new Point(10, 10, '*');
            Snake snake = new Snake(p1, 7, Direction.RIGHT);
            snake.Draw();
            snake.Move();


            FoodCreator foodCreator = new FoodCreator(149, 48, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            
            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(75, 25);
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey();
                }
                
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(100);

            }

        }
    }
}
