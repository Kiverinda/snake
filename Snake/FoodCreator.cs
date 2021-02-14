﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class FoodCreator
    {
        public int MapWidth { get; set; }
        public int MapHight { get; set; }
        public char Sym { get; set; }

        public FoodCreator(int mapWidth, int mapHight, char sym)
        {
            MapWidth = mapWidth;
            MapHight = mapHight;
            Sym = sym;
        }

        public Point CreateFood()
        {
            Random randomize = new Random();
            int x = (int)(randomize.Next(1, MapWidth));
            int y = (int)(randomize.Next(1, MapHight));

            return new Point(x, y, Sym);
        }
    }
}
