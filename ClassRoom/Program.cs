using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom classroom1 = new Classroom();
            classroom1.ClassName = "3Q";
            classroom1.SemesterStart = new DateTime(2019, 08, 26);
            classroom1.ClassList = new List<Student>();

            Student jakub = new Student("Jakub", 1, 12);
            Student katerina = new Student("Kateřina", 5, 25);
            Student rania = new Student("Rania", 10, 17);

            classroom1.ClassList.Add(jakub);
            classroom1.ClassList.Add(katerina);
            classroom1.ClassList.Add(rania);

            Console.WriteLine($"Classroom name: {classroom1.ClassName}; Start date: {classroom1.SemesterStart.ToString()}\n");
            foreach (var student in classroom1.ClassList)
            {
                Console.WriteLine($"Student name: {student.Name}; Student's birthday: {student.Birthday}.{student.BirthMonth}.");
            }

            Console.ReadKey();
        }
    }
}
