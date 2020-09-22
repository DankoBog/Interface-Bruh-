using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Bruh_
{
    class Circle : IShape
    {
        private double diameter;
        public Circle(double d)
        {
            diameter = d;
        }
        public double Area()
        {
            double r = diameter * 0.5;

            double area = r * r * Math.PI;

            return area;
        }
        public double Circumference()
        {
            double circumference = diameter * Math.PI;

            return circumference;
        }
    }
}
