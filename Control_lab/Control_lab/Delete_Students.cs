using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_lab
{
    public partial class Delete_Students : Form
    {
        public Delete_Students()
        {
            InitializeComponent();
        }

        private void Createcomboboxx()
        {
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                List<Student> students = base_all.teachers[i].GetStudents();
                for (int j = 0; j < students.Count; j++)
                {
                    comboBox2.Items.Add(students[j].Name + " " + students[j].Surname);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                List<Student> students = base_all.teachers[i].GetStudents();
                for (int j = 0; j < students.Count; j++)
                {
                    if (comboBox2.SelectedItem.ToString() == students[j].Name + " " + students[j].Surname)
                    {
                        base_all.teachers[i].Delete_student(j);
                        MessageBox.Show("Complete");
                    }
                }
            }
        }


        private void Delete_Students_Load(object sender, EventArgs e)
        {
            Createcomboboxx();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
