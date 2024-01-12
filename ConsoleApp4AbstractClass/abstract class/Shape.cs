using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4AbstractClass.abstract_class
{
   abstract class Shape
    {
        private String color;
        private bool filled;
        protected Shape()
        {

        }
        protected Shape(String color, bool isFilled)
        {
            this.Filled = Filled;
            this.Color = color;
        }

        public bool Filled { get => filled; set => filled = value; }
        public string Color { get => color; set => color = value; }
        public abstract double area();
        public abstract double perimeter();
        public virtual void print()
        {
            Console.WriteLine("The color of this shape is {0} ",this.color);
        }
    }
}
