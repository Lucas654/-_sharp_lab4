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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            foreach (var sub in Class1.subjects)
            {
                comboBox1.Items.Add(sub.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Empty != textBox1.Text && string.Empty != textBox4.Text && comboBox1.SelectedIndex>-1 && int.TryParse(textBox3.Text, out int grade) && grade < 6 && grade > 0)
            {
                foreach (var stud in Class1.students)
                {
                    if (stud.FirstName == textBox1.Text && stud.SecondName == textBox4.Text && stud.Sub == comboBox1.SelectedItem.ToString())
                        stud.Grade = int.Parse(textBox3.Text);
                }
                this.Close();
            }
            else
                MessageBox.Show("Некорректні дані");
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
