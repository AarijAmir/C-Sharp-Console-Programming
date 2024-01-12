using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle()
        {
            Console.WriteLine("Calling Rectangle Constructor");
            this.length = 0.0;
            this.width = 0.0;

        }

        public Rectangle(double length, double width)
        {
            Console.WriteLine("Calling Rectangle Constructor");
            this.length = length;
            this.width = width;

        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
    }
}
