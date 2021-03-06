﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> wallList;

        public Wall (int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight -1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');

            wallList.Add(upLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach( var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
