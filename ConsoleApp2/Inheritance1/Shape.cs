using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance
{
    public class Shape
    {
        protected string color;
        private Boolean filled;

        public Shape()
        {
            Console.WriteLine("Calling Shape Constructor");
        }

        public Shape(string color)
        {
            Console.WriteLine("Calling Shape Constructor");
            this.color = color;

        }

        public Shape(bool filled)
        {
            Console.WriteLine("Calling Shape Constructor");
            this.filled = filled;
        }

        public Shape(string color, bool filled)
        {
            Console.WriteLine("Calling Shape Constructor");
            this.color = color;
            this.filled = filled;
        }

        //public string Color { get => color; set => color = value; }
        //public bool Filled { get => filled; set => filled = value; }
        public double area()
        {
            return 0.0;
        }
        public double perimeter()
        {
            return 0.0;
        }
        public void print()
        {
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Is Filled: " + this.filled);
        }
    }
}
