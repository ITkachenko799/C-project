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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Student> students()
        {

            List<Student> students = new List<Student>();
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                List<Student> list = base_all.teachers[i].GetStudents();
                for (int j = 0; j < list.Count; j++)
                {
                    students.Add(list[j]);
                }
            }
            return students;
        }


        private void CreateTeacher()
        {

            Address address1 = new Address("Ukraine", "Kherson", "Ushakova,23");
            Address address2 = new Address("Ukraine", "Kherson", "Grinchenko,2A");
            Address address3 = new Address("Ukraine", "Kherson", "Tiraspolskaya,12");
            Address address4 = new Address("Ukraine", "Kherson", "Ushakova,2");
            Address address5 = new Address("Ukraine", "Kherson", "Komkova,35");
            Address address6 = new Address("Ukraine", "Kherson", "Suvorova,6");
            Address address7 = new Address("Ukraine", "Kherson", "Mira,24");
            Address address8 = new Address("Ukraine", "Kherson", "Komkova,12");
            Address address9 = new Address("Ukraine", "Kherson", "Potemkinskaya,10");
            Address address10 = new Address("Ukraine", "Kherson", "Charivna,7A");


            Teacher teacher = new Teacher("Anton", "Nadein", 23, 36699, address1);
            Teacher teacher1 = new Teacher("Danil", "Artemov", 34, 23690, address2);
            Teacher teacher2 = new Teacher("Big", "Boss", 60, 82683, address3);

            Student student1 = new Student("Ivan", "Tkachenko", 18, 00374, 4, address4);
            Student student2 = new Student("Vlad", "Dadaev", 18, 00436, 4, address5);
            Student student3 = new Student("Sasha", "Shishkova", 17, 99327, 5, address6);
            Student student4 = new Student("Yana", "Voronina", 22, 909478, 5, address7);
            Student student5 = new Student("Alex", "Les", 25, 23435, 4, address8);
            Student student6 = new Student("Misha", "Nosov", 17, 68369, 3, address9);
            Student student7 = new Student("Michel", "Norman", 20, 33898, 2, address10);

            base_all.teachers.Add(teacher);
            base_all.teachers.Add(teacher1);
            base_all.teachers.Add(teacher2);

            base_all.teachers[0].Add(student1);
            base_all.teachers[0].Add(student2);
            base_all.teachers[1].Add(student3);
            base_all.teachers[1].Add(student4);
            base_all.teachers[1].Add(student5);
            base_all.teachers[2].Add(student6);
            base_all.teachers[2].Add(student7);


        }


        private void CreateChart(List<Teacher> tch)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < tch.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(tch[i].Name, tch[i].Age);
            }
        }

        private void CreateChart_Student()
        {
            List<Student> std1 = students();

            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < std1.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(std1[i].Name, std1[i].Age);
            }
        }


        private void CreateDatatable()
        {
            List<Student> std1 = students();

            DataTable tab = new DataTable();
            tab.Columns.Add("First Name");
            tab.Columns.Add("Last_Name");
            tab.Columns.Add("Age");
            tab.Columns.Add("ID");
            tab.Columns.Add("Mark");
            tab.Columns.Add("Country");
            tab.Columns.Add("City");
            tab.Columns.Add("Street");

            foreach (Student i in std1)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.Id, i.Marks, i.Adress.Country, i.Adress.City, i.Adress.Street);
            }
            dataGridView1.DataSource = tab;
        }

        private void CreateDatatable(List<Teacher> teachers)
        {
            DataTable tab = new DataTable();
            tab.Columns.Add("First Name");
            tab.Columns.Add("Last_Name");
            tab.Columns.Add("Age");
            tab.Columns.Add("ID");
            tab.Columns.Add("Country");
            tab.Columns.Add("City");
            tab.Columns.Add("Street");

            foreach (Teacher i in teachers)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.Id, i.Adress.Country, i.Adress.City, i.Adress.Street);
            }

            dataGridView2.DataSource = tab;
        }

        private void CreateTree()
        {
            treeView2.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "Teacher";
            root.Name = "Teachers";
            treeView2.Nodes.Add(root);
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                treeView2.Nodes[0].Nodes.Add(base_all.teachers[i].Name + " " + base_all.teachers[i].Surname);
                for (int j = 0; j < base_all.teachers[i].GetStudents().Count(); j++)
                {
                    List<Student> list = base_all.teachers[i].GetStudents();
                    treeView2.Nodes[0].Nodes[i].Nodes.Add(list[j].Name + " " + list[j].Surname);
                }
            }
            treeView2.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeacher();
            CreateDatatable(base_all.teachers);
            CreateChart_Student();
            CreateDatatable();
            CreateTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChart(base_all.teachers);
            CreateDatatable(base_all.teachers);
            CreateChart_Student();
            CreateDatatable();
            CreateTree();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }



        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Students newForm = new Delete_Students();
            newForm.Show();
        }


      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_teacher newForm = new Delete_teacher();
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Last_Name LIKE '%{textBox1.Text}%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Last_Name LIKE '%{textBox2.Text}%'";
        }
    }
}
