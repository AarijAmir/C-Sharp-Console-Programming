using ConsoleApp4AbstractClasses.abstractclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  Circle circle = new Circle("black", true, 3.55);
            //  Console.WriteLine(circle.area());
            Shape shape;
            shape = new Circle("black", true, 3.55);
            Console.WriteLine("{0:F2}", shape.area());
            shape = new Rectangle("Red", false, 2.12, 44.52);
            Console.WriteLine("{0:F2}",shape.area());
            */
            Shape[] shape = new Shape[3];
            shape[0] = new Circle("black", true, 3.55);
            shape[1] = new Rectangle("Red", false, 2.12, 44.52);
            shape[2] = new Circle("black", true, 2.87);
            for(int i = 0; i< shape.Length; i++)
            {
                Console.WriteLine("{0:F2}", shape[i].area());
            }

            Console.ReadKey();
        }
    }
}

