using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Bruh_
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape obj;

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ange en bredd");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ange en höjd:");
                    double height = double.Parse(Console.ReadLine());

                    obj = new Rectangle(width, height);

                    Console.WriteLine("Area: " + obj.Area());
                    Console.WriteLine("Circumference: " + obj.Circumference());

                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Ange en bredd");
                     width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ange en höjd");
                     height = double.Parse(Console.ReadLine());

                    obj = new Triangle(width, height);

                    Console.WriteLine("Area: " + obj.Area());
                    Console.WriteLine("Circumference " + obj.Circumference());

                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Ange en diameter");
                    double diameter = double.Parse(Console.ReadLine());

                    obj = new Circle(diameter);

                    Console.WriteLine("Area: " + obj.Area());
                    Console.WriteLine("Circumference: " + obj.Circumference());

                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }
    }
}
