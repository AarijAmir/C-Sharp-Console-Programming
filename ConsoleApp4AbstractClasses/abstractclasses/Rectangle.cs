using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4AbstractClasses.abstractclasses
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(string color, bool isFilled, double length, double width) : base(color, isFilled)
        {
            this.length = length;
            this.width = width;
        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override double area()
        {
            Console.WriteLine("--- Rectangle Area ---");
            return (this.length * this.width);
        }

        public override double perimeter()
        {
            Console.WriteLine("--- Rectangle Perimeter ---");
            return 2 * (this.length + this.width);
        }
    }
}
