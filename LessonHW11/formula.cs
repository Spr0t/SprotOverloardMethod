using System;

namespace LessonHW11
{
    internal class formula
    {
        public double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p*(p - ab)*(p - bc)*(p - ac));
        }

        public double CalcTriangleSquare(double b, double h )
        {
            return 0.5 * b * h;
        }

        public double CalcTriangleSquare(double ab, double ac, int alpha)
        {
            return 0.5 *ab * ac * Math.Sin(alpha);
        }



    }
}
