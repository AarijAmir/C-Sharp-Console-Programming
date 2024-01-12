using ConsoleApp4AbstractClass.abstract_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Circle circle = new Circle("black", true, 3.55);
            //  Console.WriteLine(circle.area());
            Shape shape;
            shape = new Circle("black", true, 3.55);
            Console.WriteLine(shape.area());
            shape = new Rectangle("Red", false, 2.12, 44.52);
            Console.WriteLine(shape.area());

            Console.ReadKey();
        }
    }
}
