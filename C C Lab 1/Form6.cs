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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text,out int _))
            {
                foreach (var stud in Class1.students)
                {
                    if (stud.ID == int.Parse(textBox1.Text))
                        if (textBox2.Text == "" && textBox3.Text == "")
                        {
                            MessageBox.Show("Некорректні дані");
                        }
                        else if (textBox2.Text == "" && textBox3.Text != "")
                        {
                            stud.SecondName = textBox3.Text;
                            this.Close();

                        }
                        else if (textBox2.Text != "" && textBox3.Text == "")
                        {
                            stud.FirstName = textBox2.Text;
                            this.Close();
                        }
                        else
                        {
                            stud.FirstName = textBox2.Text;
                            stud.SecondName = textBox3.Text;
                            this.Close();
                        }

                }

                foreach (var stud in Class1.studen)
                {
                    if (stud.ID == int.Parse(textBox1.Text))
                        if (textBox2.Text == "" && textBox3.Text == "")
                        {
                            MessageBox.Show("Некорректні дані");
                        }
                        else if (textBox2.Text == "" && textBox3.Text != "")
                        {
                            stud.SecondName = textBox3.Text;
                            this.Close();

                        }
                        else if (textBox2.Text != "" && textBox3.Text == "")
                        {
                            stud.FirstName = textBox2.Text;
                            this.Close();
                        }
                        else
                        {
                            stud.FirstName = textBox2.Text;
                            stud.SecondName = textBox3.Text;
                            this.Close();
                        }

                }
            }
            else
                MessageBox.Show("Некорректні дані");


        }

        public void UpdateT(string FirstName, string SecondName)
        {
            
            if (FirstName == "" && SecondName == "")
            {
                MessageBox.Show("Incorrect data");
            }
            else if (FirstName == "" && SecondName != "")
            {
                
               
            }
            else if (FirstName != "" && SecondName == "")
            {
                
            }
            else
            {
               
            }

        }
    }
}
