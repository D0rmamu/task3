using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber2
{
    public class ClassRoom
    {
        Student[] masStudents;
        public ClassRoom(Student s1, Student s2, Student s3, Student s4)
            {
            masStudents = new Student[] { s1,s2,s3,s4};
            }
        public ClassRoom(Student s1, Student s2, Student s3)
        {
            masStudents = new Student[] { s1, s2, s3 };
        }
        public ClassRoom(Student s1, Student s2)
        {
            masStudents = new Student[] { s1, s2 };
        }
        public void Ychitsa() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Учится: ");
            Console.ResetColor();
            foreach (Student item in masStudents)
            {
                item.Study();
            }
        }
        public void Pishet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Пишет:");
            Console.ResetColor();
            foreach (Student item in masStudents)
            {
                item.Write();
            }
        }
        public void Chitaet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Читает: ");
            Console.ResetColor();
            foreach (Student item in masStudents)
            {
                item.Read();
            }
        }
        public void Otdix()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отдыхает: ");
            Console.ResetColor();
            foreach (Student item in masStudents)
            {
                item.Relax();
            }
        }
    }
}
