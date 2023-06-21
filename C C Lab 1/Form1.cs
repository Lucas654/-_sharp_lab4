using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;


namespace C_C_Lab_1
{
   
    public partial class Form1 : Form
    {

      

        public Form1()
        {

            InitializeComponent();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
           

        }


           
        private void Form1_Load(object sender, EventArgs e)
        {

            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sortedPeople1 = from p in Class1.students
                                orderby p.FirstName
                                select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = sortedPeople1;
            dataGridView1.DataSource = binding;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var json = new DataContractJsonSerializer(Class1.students.GetType());
            using (var file = new FileStream("inputS.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(file, Class1.students);
            }
            json= new DataContractJsonSerializer(Class1.subjects.GetType());
            using (var file = new FileStream("inputSub.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(file, Class1.subjects);
            }
            json = new DataContractJsonSerializer(Class1.studen.GetType());
            using (var file = new FileStream("inputStud.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(file, Class1.studen);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var json = new DataContractJsonSerializer(Class1.students.GetType());
            using (var file = new FileStream("inputS.json", FileMode.OpenOrCreate))
            {
                Class1.students = json.ReadObject(file) as List<student>;
            }
            json = new DataContractJsonSerializer(Class1.subjects.GetType());
            using (var file = new FileStream("inputSub.json", FileMode.OpenOrCreate))
            {
                Class1.subjects = json.ReadObject(file) as List<subject>;
            }
            json = new DataContractJsonSerializer(Class1.studen.GetType());
            using (var file = new FileStream("inputStud.json", FileMode.OpenOrCreate))
            {
                Class1.studen = json.ReadObject(file) as List<stud>;
            }
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }

        private void button11_Click(object sender, EventArgs e)
        {
             var People = from p in Class1.students
                                where p.Sub==textBox1.Text
                                select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = People;
            dataGridView1.DataSource = binding;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
            BindingSource binding = new BindingSource();
            binding.DataSource = Class1.students;
            dataGridView1.DataSource = binding;
        }
    }
}
