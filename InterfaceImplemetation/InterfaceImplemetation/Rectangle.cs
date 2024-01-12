using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplemetation
{
    class Rectangle : IShape
    {
        private double length;
        private double width;
        public  static int rollno = 33;

        public Rectangle()
        {

        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public  double area()
        {
            return (this.length * this.width);
        }

        public  double perimeter()
        {
            return 2 * (this.length + this.width);
        }
        public static void Iub()
        {

        }
         

    }
}
