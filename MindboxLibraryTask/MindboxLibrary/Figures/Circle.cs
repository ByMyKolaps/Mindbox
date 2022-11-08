using System;

namespace MindboxLibrary.Figures
{
    public class Circle : IFigure
    {
        public readonly double radius;
        
        public Circle(double radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                throw new ArgumentException("Радиус должен быть положительным");
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
