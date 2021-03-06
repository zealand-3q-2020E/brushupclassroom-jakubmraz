﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            if(!CheckMonth(birthMonth))
                throw new Exception();
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public string Name { get; }
        public int BirthMonth { get; }
        public int Birthday { get; }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
                return "Winter";
            if (BirthMonth >= 3 && BirthMonth <= 5)
                return "Spring";
            if (BirthMonth >= 6 && BirthMonth <= 8)
                return "Summer";
            if (BirthMonth >= 9 && BirthMonth <= 11)
                return "Autumn";
            return "You entered something stupid";
        }

        private bool CheckMonth(int month)
        {
            if (month < 1 || month > 12)
                return false;
            return true;
        }

        public override string ToString()
        {
            return $"Student name: {this.Name}; student's birthday: {this.Birthday}. {this.BirthMonth}.";
        }
    }
}
