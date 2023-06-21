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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            foreach(var sub in Class1.subjects)
            {
                comboBox1.Items.Add(sub.Name);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var sub in Class1.subjects)
            {
                if (sub.Name==comboBox1.SelectedItem.ToString())
                {
                    if (string.Empty!= textBox1.Text)
                    {
                        sub.Name = textBox1.Text;
                        foreach(var st in Class1.students)
                        {
                            if (st.Sub == comboBox1.SelectedItem.ToString())
                            {
                                st.Sub= textBox1.Text;
                                this.Close();
                            }
                        }
                        
                    }
                    else
                        MessageBox.Show("Дані некорректні");
                }
            }
        }
    }
}
