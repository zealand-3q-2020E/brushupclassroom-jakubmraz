using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            BirthMonth = birthmonth;
            Birthday = birthday;
        }

        public string Name { get; }
        public int BirthMonth { get; }
        public int Birthday { get; }
    }
}
