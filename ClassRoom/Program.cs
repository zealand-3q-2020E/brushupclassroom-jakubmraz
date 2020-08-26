using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

            CountBirthdaysInSeasons(classroom1.ClassList);

            Console.ReadKey();
        }

        static void CountBirthdaysInSeasons(List<Student> students)
        {
            List<Student> springStudents = new List<Student>();
            List<Student> summerStudents = new List<Student>();
            List<Student> autumnStudents = new List<Student>();
            List<Student> winterStudents = new List<Student>();
            foreach (var student in students)
            {
                if(student.Season() == "Spring")
                    springStudents.Add(student);
                if(student.Season() == "Summer")
                    summerStudents.Add(student);
                if(student.Season() == "Autumn")
                    autumnStudents.Add(student);
                if(student.Season() == "Winter")
                    winterStudents.Add(student);
            }

            Console.WriteLine($"Students born in Spring: {springStudents.Count}");
            Console.WriteLine($"Students born in Summer: {summerStudents.Count}");
            Console.WriteLine($"Students born in Autumn: {autumnStudents.Count}");
            Console.WriteLine($"Students born in Winter: {winterStudents.Count}");
        }
    }
}
