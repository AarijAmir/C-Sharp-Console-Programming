using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplemetation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Circle circle = new Circle(3.0);
            Console.WriteLine("{0:F3}", circle.area());
            Console.ReadKey();
            */
            /*           IShape shape = new Circle(4.5);
            Console.WriteLine("{0:F3}", shape.area());
            Console.ReadKey();
            */
            Rectangle rec1 = new Rectangle();
            

            IShape[] shape = new IShape[3];
            shape[0] = new Circle(3.4);
            shape[1] = new Rectangle(33.4, 34.3);
            shape[2] = new Circle(33.2);
            drawShapes(shape);
            Console.ReadKey();
        }
        static void drawShapes(IShape[] arrShapes)
        {
            for (int i = 0; i < arrShapes.Length; i++)
            {
               
                Console.WriteLine(arrShapes[i].area());
                Console.WriteLine(arrShapes[i].perimeter());

            }
        }
    }
}
