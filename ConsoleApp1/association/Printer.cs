using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.association
{
    class Printer
    {
        private string data;

        public Printer(String data)
        {
            this.data = data;
        }

        public string Data { get => data; set => data = value; }

        public void Print()
        {
           // Console.WriteLine("------Start Printing------");
            Console.WriteLine(data);
           // Console.WriteLine("------End Printing------");
        }
    }
}
