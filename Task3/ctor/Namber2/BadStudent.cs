using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber2
{
    public class BadStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Учится -> 2 дня в году");
        }
        public override void Read()
        {
            Console.WriteLine("Читает -> читает этикетки на освежителе воздуха");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет -> не пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхает -> Подобен богу");
        }
    }
}
