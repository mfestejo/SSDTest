using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace NUnitTest_Circle
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);
            decimal area = circle.getArea();
            Assert.AreEqual(78.539815, area);
        }

        [Test]
        public void TestCircleCircuference()
        {
            Circle circle = new Circle(5);
            decimal circum = circle.getCircumference();
            Assert.AreEqual(31.415926, circum);
        }

        [Test]
        public void TestCircle2()
        {
            Circle circle = new Circle(5);
            decimal circum = circle.getCircumference();
            Assert.AreEqual(31.415926, circum);
        }

        [Test]
        public void TestCircleRadiusSet()
        {
            Circle circle = new Circle(5);
            circle.setRadius(6);
            decimal rad = circle.getRadius();
            Assert.AreEqual(6, rad);
        }
    }
}
