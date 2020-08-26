using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Classroom
    {
        public Classroom()
        {

        }

        public string ClassName { get; }
        public List<Student> ClassList { get; }
        public DateTime SemesterStart { get; }
    }
}
