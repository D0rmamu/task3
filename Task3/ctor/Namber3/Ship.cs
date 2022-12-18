using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber3
{
    public class Ship : Vehicle
    {
        public  void SH()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Напешите кол-во пасажиров на коробле:");
            Console.ResetColor();
            Pasagir = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Pasagir}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите порт преписки:");
            Console.ResetColor();
            Koordinate2 = Console.ReadLine();
            Console.WriteLine($"{Koordinate2}");
        }
    }
}
