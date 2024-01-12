using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Inheritance2.inheritance2
{
    class Circle : Shape
    {
        private double radius;

        public Circle() : base()
        {
           // Console.WriteLine("Calling Circle Constructor");
            this.radius = 0.0;

        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
           // Console.WriteLine("Calling Circle Constructor");
            this.radius = radius;
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
        public void test()
        {
            Console.WriteLine(this.radius);
            Console.WriteLine(base.color);
        }
        /*
         * static binding
        public new void print()
        {
            Console.WriteLine("Circle Print()");
            Console.WriteLine(this.radius);
        }
        */
        // dynamic binding
        public override void print()
        {
            Console.WriteLine("Circle Print()");
            Console.WriteLine(this.radius);
            Console.WriteLine(color);
        }
    }
}
