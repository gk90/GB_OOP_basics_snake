﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine line2 = new VerticalLine(15, 25, 10, '#');
            line2.Drow();

            Console.ReadLine();
        }
    }
}
