using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber4
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован в бомжовской версии про");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом бомжовском формате, сохранение в остальных форматах доступно только при покупке супер пупер версии Эксперт");
        }
    }
}
