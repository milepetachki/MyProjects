using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
        
    {
        bool plus = false;
        bool minus = false;
        bool devide = false;
        bool multiply = false;
        bool equal = false;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button0_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "0";

        }
        private void CheckIfEqual()
        {
            if (equal)
            {
                textBox1.Text = "";
                equal = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "1";
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            CheckIfEqual();
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains ("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0,1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                plus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
               
                
                
                
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            equal = true;
                
            if (plus)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) + Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            if (multiply)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            if (minus)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            if (devide)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void buttonMultiplie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                multiply = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                devide = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            plus = minus = devide = multiply = equal= false;
            textBox1.Text = "";
            textBox1.Tag = textBox1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
