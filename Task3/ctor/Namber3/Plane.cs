using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber3
{
    public class Plane : Vehicle
    {
        public  void PL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите высоту Самолета:");
            Console.ResetColor();
            Koordinate = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Koordinate}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите кол-во пасажиров в самолете:");
            Console.ResetColor();
            Pasagir = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Pasagir}");
        }
      
    }
}
