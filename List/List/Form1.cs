using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        internal class Student
        {
            public string name;
            public string surname;
            public string id;
            private int age;

           /* public void Age(int x)
            {
                if (x < 0) age = -x;
                else age = x;
            }
            public int gAge()
            { return age; } */

            public int Age
            {
                set
                {
                    if (value < 0) age = -value;
                    else age = value;
                }
                get
                {
                    return age;
                }
            }
        }

        public Form1() //constructor
        {
            InitializeComponent(); //method
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string, Student> School
    = new Dictionary<string, Student>();

        private void button3_Click(object sender, EventArgs e)
        {

            Student st= new Student();

            /* st.Age(Convert.ToInt32(textBox4.Text));
            textBox3.Text = st.gAge().ToString(); */

            /* st.Age = Convert.ToInt32(textBox4.Text);
            textBox3.Text = st.Age.ToString(); */

            st.name = textBox1.Text;
            st.surname = textBox2.Text;
            st.id = textBox3.Text;
            st.Age = Convert.ToInt32(textBox4.Text);
            School.Add(st.id, st);
            comboBox1.Items.Add(st.id);

            MessageBox.Show("a record added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = comboBox1.SelectedItem.ToString();
            Student s = new Student();
            s = School[comboBox1.SelectedItem.ToString()];
            textBox1.Text = s.name;
            textBox2.Text = s.surname;
            textBox3.Text = s.id;
            textBox4.Text = s.Age.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
