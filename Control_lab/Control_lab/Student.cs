using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_lab
{
    class Student : Human
    {
        Random random = new Random();
        private marks grade;
        public string Marks { get { return grade.ToString(); } }

        public Student(string Name, string Surname, int Age, int Id, int mark, Address Address) : base(Name, Surname, Age, Id, Address)
        {
            switch (mark)
            {
                case 1:
                    grade = marks.E;
                    break;

                case 2:
                    grade = marks.D;
                    break;

                case 3:
                    grade = marks.C;
                    break;

                case 4:
                    grade = marks.B;
                    break;

                case 5:
                    grade = marks.A;
                    break;
            }
        }

        enum marks
        {
            A = 5,
            B = 4,
            C = 3,
            D = 2,
            E = 1
        }
    }
}
