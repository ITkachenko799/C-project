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
    public partial class Delete_teacher : Form
    {
        public Delete_teacher()
        {
            InitializeComponent();
        }

        private void CreateComboBox()
        {
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                comboBox1.Items.Add(base_all.teachers[i].Name + " " + base_all.teachers[i].Surname);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < base_all.teachers.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == base_all.teachers[i].Name + " " + base_all.teachers[i].Surname)
                {
                    base_all.teachers.RemoveAt(i);
                    MessageBox.Show("Complete");

                }
            }
        }
        private void Delete_teacher_Load(object sender, EventArgs e)
        {
            CreateComboBox();
        }

        
    }
}
