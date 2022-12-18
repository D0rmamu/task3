using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber1
{
    public class PrinterGreen
    {
        public void Print3(string value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
