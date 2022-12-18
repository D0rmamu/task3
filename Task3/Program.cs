using Task3.ctor.Namber1;
using Task3.ctor.Namber2;
using Task3.ctor.Namber3;
using Task3.ctor.Namber4;

/*Console.WriteLine("Красный");
Printer printer= new Printer();
printer.Print(Console.ReadLine());
Console.WriteLine("Синий");
PrinterBlue printerBlue = new PrinterBlue();
printerBlue.Print2(Console.ReadLine());
Console.WriteLine("зеленый");
PrinterGreen printerGreen = new PrinterGreen();
printerGreen.Print3(Console.ReadLine());
Console.WriteLine("Желтый");
PrinterYellow printerYellow = new PrinterYellow();
printerYellow.Print1(Console.ReadLine());*/

/*ClassRoom CLR = new ClassRoom(new BadStudent(), new GoodStudent(),new ExcelentStudent());
CLR.Ychitsa();
CLR.Chitaet();
CLR.Pishet ();
CLR.Otdix();
Thread.Sleep(1000);*/

/*Vehicle vehicle = new Vehicle();
Plane plane = new Plane();
Ship ship = new Ship();
Саг саг = new Саг();
plane.PL();
ship.SH();
саг.CR();*/


class Program
{
    private const string PRO = "Автобус";
    private const string EXP = "Дота ван лав";

    static void Main(string[] args)
    {

        Console.WriteLine("Нам нужно ваше удоставерение(Ключ):");
        var  E = Console.ReadLine();


        DocumentWorker worker;
        switch (E)
        {
            case PRO: worker = new ProDocumentWorker(); break;
            case EXP: worker = new ExpertDocumentWorker(); break;
            default: worker = new DocumentWorker(); break;
        }


        while (true)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Выберете команду которая вам нужна нажав цифру:\n1)-Открыть документ\n2)-Редактировать документ\n3)-Сохранить документ\n4)-Закрыть операцию");
            Console.ResetColor();
            switch (Console.ReadLine())
            {
                case "1": worker.OpenDocument(); break;
                case "2": worker.EditDocument(); break;
                case "3": worker.SaveDocument(); break;
                case "4": return;
            }
        }
        
    }
}