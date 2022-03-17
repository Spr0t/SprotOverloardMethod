using System;

namespace LessonHW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Добавить перегрузку, которая принимает длины двух смежных сторон(double) и величину угла между ними.
            //Величину угла принимать как int.
            //Метод должен рассчитывать площадь по формуле:
            //0.5 * ab * ac * sin(alpha)


            formula f = new formula();

            double square1 = f.CalcTriangleSquare(10, 20);
            double square2 = f.CalcTriangleSquare(15, 30, 1);
            double square3 = f.CalcTriangleSquare(10, 20, 45);

            Console.WriteLine($"square1:{square1} square2:{square2} square3:{square3}"); ;
            Console.ReadLine();

        }
    }
}
