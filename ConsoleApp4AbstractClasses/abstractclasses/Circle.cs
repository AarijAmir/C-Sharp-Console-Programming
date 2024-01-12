using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4AbstractClasses.abstractclasses
{
    class Circle : Shape
    {
        private double radius;

        public Circle() : base()
        {

        }
        public Circle(string color, bool isFilled, double radius) : base(color, isFilled)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double area()
        {
            Console.WriteLine("--- Circle Area ---");
            return Math.PI * radius * radius;
        }

        public override double perimeter()
        {
            Console.WriteLine("--- Circle Perimeter ---");
            return 2 * Math.PI * radius;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine("Radius Of Circle {0}, area is {1} and perimeter {2}", this.radius, this.area(), this.perimeter());
        }
    }
}
