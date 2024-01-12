using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplemetation
{
    class Circle : IShape
    {

        private double radius;
         
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

    
        public double area()
        {
            Console.WriteLine("--- Circle Area ---");
            return Math.PI * radius * radius;
        }

        public double perimeter()
        {
            Console.WriteLine("--- Circle Perimeter ---");
            return 2 * Math.PI * radius;
        }
    }
}
