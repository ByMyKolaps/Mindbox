using System;
using MindboxLibrary;
using MindboxLibrary.Figures;
using NUnit.Framework;

namespace MindboxTests
{
    [TestFixture]
    internal class AreaCalculatorTests
    {
        private const double precision = 0.01;
        [TestCase(3, 28.274333882308138)]
        [TestCase(7, 153.93804002589985)]
        [TestCase(2, 12.566370614359172)]
        public void ÑalculatesCircleAreaCorrectly(double radious, double expected)
        {
            IFigure figure = new Circle(radious);
            Assert.AreEqual(expected, figure.CalculateArea(), precision);
        }

        [TestCase(6, 4, 3, 5.3326822519254)]
        [TestCase(15, 13, 17, 93.899880191617)]
        [TestCase(11, 7, 8, 27.928480087538)]
        public void ÑalculatesTriangleAreaCorrectly(double a, double b, double c, double expected)
        {
            IFigure figure = new Triangle(a, b, c);
            Assert.AreEqual(expected, figure.CalculateArea(), precision);
        }

    }
}