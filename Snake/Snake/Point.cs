using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int distance, Directions direction)
        {
            if(direction == Directions.RIGHT)
            {
                x = x + distance;
            }
            else if(direction == Directions.LEFT)
            {
                x = x - distance;
            }
            else if (direction == Directions.UP)
            {
                y = y - distance;
            }
            else if (direction == Directions.DOWN)
            {
                y = y + distance;
            }
        } 
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
