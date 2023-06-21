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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i=0;i<Class1.students.Count;i++)
            {
                if (Class1.students[i].Sub == textBox1.Text)
                {
                    Class1.students.Remove(Class1.students[i]);
                }
            }
            for (var i = 0; i < Class1.subjects.Count; i++)
            {
                if (Class1.subjects[i].Name == textBox1.Text)
                {
                    Class1.subjects.Remove(Class1.subjects[i]);
                }
            }

            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
