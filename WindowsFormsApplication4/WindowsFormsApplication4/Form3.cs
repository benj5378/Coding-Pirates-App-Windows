using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int width;
        int height;
        int area;
        string format;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(textBox1.Text);
            height = Convert.ToInt32(textBox2.Text);
            area = width * height;
            textBox3.Text = area.ToString() + " " + format;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            format = comboBox1.Text;
        }
    }
}
