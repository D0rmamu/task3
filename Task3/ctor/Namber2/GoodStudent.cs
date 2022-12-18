using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber2
{
    public class GoodStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Учится -> ну такоееееееее...");
        }
        public override void Read()
        {
            Console.WriteLine("Читает -> Войну и Мир");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет -> Вроде чето понятно");
        }
        public override void Relax()
        {
            Console.WriteLine(" Отдыхает -> пол пары");
        }
    }
}
