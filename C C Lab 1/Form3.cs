using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_C_Lab_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i=0;i<Class1.students.Count;i++)
            {
                if (Class1.students[i].ID == int.Parse(textBox1.Text))
                    Class1.students.RemoveRange(i, Class1.subjects.Count);
            }
           /* foreach (var stud in Class1.students)
                if (stud.ID == int.Parse(textBox1.Text))
                    Class1.students.RemoveRange(, Class1.subjects.Count);*/
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
