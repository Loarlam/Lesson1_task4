using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Point
    {
        int x, y;
        string nameOfPoint;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string FigureName { get { return nameOfPoint; } }

        public Point(int x, int y, string figureName)
        {
            this.x = x;
            this.y = y;
            this.nameOfPoint = figureName;
        }
    }
}
