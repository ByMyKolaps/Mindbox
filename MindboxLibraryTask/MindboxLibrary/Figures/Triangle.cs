using System;

namespace MindboxLibrary.Figures
{
    public class Triangle : IFigure
    {
        public readonly double a;
        public readonly double b;
        public readonly double c;

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
                throw new ArgumentException("Стороны треугольника должны быть положительными");
        }

        public double CalculateArea()
        {
            double halfMeter = (a + b + c) / 2;
            return Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));
        }

        public bool IsRectangular()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                    return true;
            }
            return false;
        }

    }
}
