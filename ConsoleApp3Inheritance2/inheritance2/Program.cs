using ConsoleApp3Inheritance2.inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * CT- binding/ Early Bindling/ static Binding
       
            Circle circle = new Circle(27.3, "Black", true);
            circle.print();
             Runtime- bindling/ late bindind/ dynamic binding
            Shape shape = circle;
           
            shape.print();
            Console.ReadKey();
            */
            /*
            // Dyanmic Binding
            Circle circle = new Circle(27.3, "Black", true);
            Shape shape = circle;
            circle.print();
            shape.print();
            
            */
            /*
             * Dynamic binding
            Shape s;
            s = new Circle();
            s.print();

            s = new Rectangle();
            s.print();

            s = new Shape();
            s.print();
            */
            Shape[] shape = new Shape[3];
            shape[0] = new Circle(3.55,"black",true);
            shape[1] = new Rectangle(3.4,2.4,"blue",true );
            shape[2] = new Circle(2.11, "pink", false);
            drawShapes(shape);

            Console.ReadKey();
        }
        static void drawShapes(Shape[] arrShapes)
        {
            for(int i = 0; i< arrShapes.Length; i++)
            {
                /*
                1st way of calling
                //Shape myShape = arrShapes[i];
                //myShape.print();
               2nd way of calling
                //arrShapes[i].print();
                */
                Console.WriteLine(arrShapes[i].area());
                Console.WriteLine(arrShapes[i].perimeter());

            }
        }
    }
}
