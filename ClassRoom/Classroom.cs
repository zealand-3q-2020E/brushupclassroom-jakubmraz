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

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }
    }
}
