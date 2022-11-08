using System;
using MindboxLibrary.Figures;
using NUnit.Framework;

namespace MindboxTests
{
    [TestFixture]
    internal class TriangleTests
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(1, 0, 1)]
        public void CantCreateTriangleWithNegativeSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(delegate { new Triangle(a, b, c); });
        }

        [TestCase(5, 4, 3, true)]
        [TestCase(6, 4, 3, false)]
        public void DefinesRightAngledTriangleСorrectly(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsRectangular());
        }

    }
}
