using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт в лоховском формате");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
