using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(27.3,"Black",true);
            //  Rectangle rectangle = new Rectangle();
            circle.test();
            Console.ReadKey();
        }
    }
}
