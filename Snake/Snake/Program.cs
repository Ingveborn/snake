using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Directions.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandler(key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
