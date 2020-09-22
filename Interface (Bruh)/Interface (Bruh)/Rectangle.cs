using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Bruh_
{
    class Rectangle : IShape
    {
        private double width, height;
        public Rectangle(double w, double h)
        {
            width = w;

            height = h;
        }
        public double Area()
        {
            double area = width * height;

            return area;
        }
        public double Circumference()
        {
            double recCircumference = width * 2 + height * 2;

            return recCircumference;
        }
    }
}
