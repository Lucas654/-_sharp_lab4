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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.subjects.Add(new subject(textBox1.Text));
            foreach (var st in Class1.studen)
                Class1.students.Add(new student(st.ID, st.FirstName, st.SecondName, Class1.subjects[Class1.subjects.Count - 1].Name, Class1.subjects[Class1.subjects.Count - 1].Grade));

            this.Close();
        }
    }
}
