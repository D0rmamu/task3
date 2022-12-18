using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber2
{
    public class ExcelentStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine(" Учится -> Подобен богу");
        }
        public override void Read()
        {
            Console.WriteLine("Читает -> 20к слов в минуту");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет -> со скоростью света");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхает -> почти умер");
        }
    }
}
