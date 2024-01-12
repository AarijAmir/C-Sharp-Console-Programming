using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance
{
    class Circle : Shape
    {
        private double radius;

        public Circle():base()
        {
            Console.WriteLine("Calling Circle Constructor");
            this.radius = 0.0;

        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            Console.WriteLine("Calling Circle Constructor");
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }
        public void test()
        {
            Console.WriteLine(this.radius);
            Console.WriteLine(base.color);
        }
    }
}
