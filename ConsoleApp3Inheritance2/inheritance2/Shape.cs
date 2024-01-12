using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Inheritance2.inheritance2
{
    public class Shape
    {
        protected string color;
        private Boolean filled;

        public Shape()
        {
           // Console.WriteLine("Calling Shape Constructor");
        }

        public Shape(string color)
        {
          //  Console.WriteLine("Calling Shape Constructor");
            this.color = color;

        }

        public Shape(bool filled)
        {
            Console.WriteLine("Calling Shape Constructor");
            this.filled = filled;
        }

        public Shape(string color, bool filled)
        {
         //   Console.WriteLine("Calling Shape Constructor");
            this.color = color;
            this.filled = filled;
        }

        //public string Color { get => color; set => color = value; }
        //public bool Filled { get => filled; set => filled = value; }
        public virtual double area()
        {
            return 0.0;
        }
        public virtual double perimeter()
        {
            return 0.0;
        }
        /*
         * static binding
        public void print()
        {
            Console.WriteLine("Shape Print()");
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Is Filled: " + this.filled);
        }
        */

        //dyanmic binding
        public virtual void print()
        {
            Console.WriteLine("Shape Print()");
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Is Filled: " + this.filled);
        }
    }
}
