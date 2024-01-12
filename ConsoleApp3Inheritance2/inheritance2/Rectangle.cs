using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Inheritance2.inheritance2
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(): base()

        {
          //  Console.WriteLine("Calling Rectangle Constructor");
            this.length = 0.0;
            this.width = 0.0;

        }

        public Rectangle(double length, double width, string color, bool filled): base(color, filled)
        {
         //   Console.WriteLine("Calling Rectangle Constructor");
            this.length = length;
            this.width = width;

        }
        public override double perimeter()
        {
            Console.WriteLine("--- Rectangle Perimeter ---");
            return 2 *(this.length+this.width);
        }
        public override double area()
        {
            Console.WriteLine("--- Rectangle Area ---");
            return (this.length * this.width);
        }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public override void print()
        {
            Console.WriteLine("Rectangle Print()");
            Console.WriteLine("Length: "+this.length);
            Console.WriteLine("Width: " + this.width);
            Console.WriteLine(color);
        }
    }
}
