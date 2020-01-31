using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Figure
    {
        Point[] point;
        string nameOfPolygon;

        public Figure(Point A, Point B, Point C)
        {
            nameOfPolygon = "Треугольник";
            point = new Point[3];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            nameOfPolygon = "Квадрат";
            point = new Point[4];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
            this.point[3] = D;
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            nameOfPolygon = "Пятиугольник";
            point = new Point[5];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
            this.point[3] = D;
            this.point[4] = E;
        }

        public string NameOfPolygons { get { return nameOfPolygon; } }

        //Формула нахождения длины стороны от точки до точки: √((B.Y-A.Y)^2+(B.X-A.X)^2)
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - A.X, 2));
        }

        //Формула нахождения периметра многоугольника (не квадрат): A1+A2+...+An
        //Формула нахождения периметра многоугольника (квадрат): A1*количество сторон
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            int i = point.Length - 1;
            while (i>0)
            {
                perimeter += LengthSide(point[i-1],point[i]);
                if (i==1)
                {
                    perimeter += LengthSide(point[i-1],point[point.Length-1]);
                    Console.Write(perimeter);
                }
                i--;
            }    
            //Можно юзать и кусок ниже, если закомментить кусок выше с double perimeter по закрывающую скобку (включительно)
            //double perimeter = 0;
            //for (int i = 0; i < point.Length; i++)
            //{
            //    if (i != (point.Length - 1))
            //        perimeter += LengthSide(point[i], point[i + 1]);
            //    else
            //        perimeter += LengthSide(point[i], point[0]);
            //}
        }
    }
}
