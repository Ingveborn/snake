using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Directions direction;

        public Snake(Point tail, int length, Directions direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        public void KeyHandler(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
                direction = Directions.LEFT;
            else if (key.Key == ConsoleKey.RightArrow)
                direction = Directions.RIGHT;
            else if (key.Key == ConsoleKey.UpArrow)
                direction = Directions.UP;
            else if (key.Key == ConsoleKey.DownArrow)
                direction = Directions.DOWN;
        }
    }
}
