using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_lab
{
    class Teacher : Human
    {
        private List<Student> studentlist = new List<Student>();
        public void Add(Student student)
        {
            studentlist.Add(student);
        }

        public Teacher(string Name, string Surname, int Age, int ID, Address adress) : base(Name, Surname, Age, ID, adress)
        {

        }

        public List<Student> GetStudents()
        {
            return studentlist;
        }

        public void Delete_student(int delete)
        {
            studentlist.RemoveAt(delete);
        }

        



    }
}
