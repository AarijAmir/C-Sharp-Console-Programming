 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.association
{
    class Document
    {
        private string content;
        private string format;
       

        public Document()
        {
         
            this.content = "Dummy Text Printing";
        }
        public Document( string content)
        {
            this.content = content;
           
        }
        public Document(string content, string format)
        {
            this.format = format;
            this.content = content;
        }
        public string Content { get => content; set => content = value; }
        public string Format { get => format; set => format = value; }

        public void PrintDocument()
        {
            Printer printer = new Printer(Content);
            printer.Print();     
        }
        public void FormatOfPrinting()
        {
           
        }
    }

}
