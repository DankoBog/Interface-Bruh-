using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Bruh_
{
    class Triangle : IShape
    {
        private double width, height;
        public Triangle(double w, double h)
        {

        }
        public double Area()
        {
            double triArea = (width * height) / 2;

            return triArea;
        }
        public double Circumference()
        {
            double triCircumference = height + width + (Math.Sqrt(width * width + height * height));

            return triCircumference;
        }
    }
}
