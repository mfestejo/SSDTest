using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTest_Circle
{
    public class Circle
    {
        private decimal radius = 0;
        private decimal area = 0;
        private decimal circumference = 0;
        public const decimal PI = 3.1415926M;
        public decimal Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(decimal r)
        {
            Radius = r;
        }
        public decimal getArea()
        {
            area = PI * Radius * Radius;
            return area;
        }

        public decimal getCircumference()
        {
            circumference = 2 * PI * Radius;
            return circumference;
        }

        public decimal getRadius()
        {
            return Radius;
        }
        public void setRadius(decimal r)
        {
            Radius = r;
        }
    }
}