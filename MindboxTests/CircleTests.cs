using System;
using MindboxLibrary.Figures;
using NUnit.Framework;

namespace MindboxTests
{
    [TestFixture]
    internal class CircleTests
    {
        [Test]
        public void CantCreateCircleWithNegativeRadius()
        {
            Assert.Throws<ArgumentException>(delegate { new Circle(-1); });
        }
    }
}
