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
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox1.Text,out int idd))
            {
                foreach (var st in Class1.students)
                {
                    if (st.ID == idd)
                    {
                        i = 1;
                        break;
                    }


                }
            }
            

            if (i!=1)
            {
                if (int.TryParse(textBox1.Text, out int id) && string.Empty != textBox2.Text && string.Empty != textBox3.Text)
                {
                    Class1.studen.Add(new stud(id, textBox2.Text, textBox3.Text));
                    foreach (var sub in Class1.subjects)
                    {
                        Class1.students.Add(new student(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, sub.Name, sub.Grade));
                    }
                    this.Close();
                }
                else
                    MessageBox.Show("Дані некорректні");
                
            }
            else
                MessageBox.Show("Студент за данним ID вже зареєстрованний");

        }
    }
}
