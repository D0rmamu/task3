using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber3
{
    public class Саг : Vehicle
    {
        public  void CR()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите Цену авто:");
            Console.ResetColor();
            Cena = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Cena}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите Скорость авто:");
            Console.ResetColor();
            Skorost = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Skorost}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Напешите Год выпуска авто:");
            Console.ResetColor();
            GVipusk = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GVipusk}");
        }
    }
}
