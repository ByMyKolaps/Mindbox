using System;
using MindboxLibrary;
using MindboxLibrary.Figures;

namespace MindboxApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure triangle = new Triangle(15, 13, 17);
            IFigure circle = new Circle(4);
            Console.WriteLine(triangle.CalculateArea());
            Console.WriteLine(circle.CalculateArea());
        }
    }
}
