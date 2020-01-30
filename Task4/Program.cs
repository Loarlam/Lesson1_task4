/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать классы Point и Figure.  
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get.  
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
Написать программу, которая выводит на экран название и периметр многоугольника. 
 */
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(4, 6, "A");
            Point B = new Point(1, 1, "B");
            Point C = new Point(4, 1, "C");
            Point D = new Point(6, 3, "D");
            Point E = new Point(8, 6, "E");

            //Для примера возьму пятиугольник
            Figure mnogougolnik = new Figure(A, B, C, D, E);

            Console.Write("{0} с периметром = ",mnogougolnik.NameOfPolygons);
            mnogougolnik.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
