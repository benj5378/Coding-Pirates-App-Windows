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
    public partial class Form1 : Form
    {
        
        bool insertNumber1 = true;
        bool insertNumber2 = false;
        bool minus = false;
        bool plus = false;
        bool gange = false;
        bool divider = false;
        bool numbertyped = false;
        int number1;
        int number2;
        int result;
        bool number1typed = false;
        bool number2typed = false;
        bool firstnumber2 = false;
        bool number2typed2 = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Result_Click(object sender, EventArgs e)
        {   
            if (number2typed == false && number1typed == true && number2typed2 == true)
            {
                number2 = Convert.ToInt32(textBox1.Text);
                bool insertNumber1 = true;
                bool insertNumber2 = false;
            }
            if (plus == true)
            {
                result = number1 + number2;
                textBox1.Text = result.ToString();
                bool insertNumber1 = true;
                bool insertNumber2 = false;
                number1typed = false;
                number2typed = false;
                number2typed2 = false;
                number2 = 0;
                number1 = 0;
            }
            else if (minus == true)
            {
                result = number1 - number2;
                textBox1.Text = result.ToString();
                number1typed = false;
                number2typed = false;
                number2typed2 = false;
                number2 = 0;
                number1 = 0;
            }
            else if (divider == true)
            {
                if (number1 % 2 == 0)
                {
                    result = number1 / number2;
                    textBox1.Text = result.ToString();
                    number1typed = false;
                    number2typed = false;
                    number2typed2 = false;
                    number2 = 0;
                    number1 = 0;
                }
                else if (number2 % 2 == 0)
                {
                    result = number1 / number2;
                    textBox1.Text = result.ToString();
                    number1typed = false;
                    number2typed = false;
                    number2typed2 = false;
                    number2 = 0;
                    number1 = 0;
                }
                else
                {
                    MessageBox.Show("One of the 2 numbers shall go up in 2");
                }
            }
            else if (gange == true)
            {
                result = number1 * number2;
                textBox1.Text = result.ToString();
                number1typed = false;
                number2typed = false;
                number2typed2 = false;
                number2 = 0;
                number1 = 0;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (numbertyped == true)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + " " + "+" + " ";
                plus = true;
                insertNumber1 = false;
                insertNumber2 = true;
                number1typed = true;
                firstnumber2 = true;
            }
            else
            {
                MessageBox.Show("Type number first!");
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (numbertyped == true)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + " " + "-" + " ";
                minus = true;
                insertNumber1 = false;
                insertNumber2 = true;
                number1typed = true;
                firstnumber2 = true;
            }
            else
            {
                MessageBox.Show("Type number first!");
            }
        }
        
        private void Divider_Click(object sender, EventArgs e)
        {
            if (numbertyped == true)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + " " + "/" + " ";
                divider = true;
                insertNumber1 = false;
                insertNumber2 = true;
                number1typed = true;
                firstnumber2 = true;
            }
            else
            {
                MessageBox.Show("Type number first!");
            }
        }
        
        private void Gange_Click(object sender, EventArgs e)
        {
            if (numbertyped == true)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + " " + "*" + " ";
                gange = true;
                insertNumber1 = false;
                number1typed = true;
                firstnumber2 = true;
            }
            else
            {
                MessageBox.Show("Type number first!");
            }
        }
        
        private void Number1_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "1";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                number2typed = true;
            }
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "2";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                number2typed = true;
            }
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "3";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                number2typed = true;
            }
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "4";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                number2typed = true;
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "5";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                number2typed = true;
            }
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "6";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                number2typed = true;
            }
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "7";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                number2typed = true;
            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "8";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "8";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                number2typed = true;
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "9";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "9";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                number2typed = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumberZero_Click(object sender, EventArgs e)
        {
            if (insertNumber1 == true)
            {
                textBox1.Text = textBox1.Text + "0";
                numbertyped = true;
            }
            else if (firstnumber2 == true)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "0";
                number2typed = false;
                number2typed2 = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            bool insertNumber1 = true;
            bool insertNumber2 = false;
            bool minus = false;
            bool plus = false;
            bool gange = false;
            bool divider = false;
            textBox1.Text = "";
            number1typed = false;
            number2typed = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void valutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

               
    }
}
