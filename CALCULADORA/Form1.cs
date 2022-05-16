using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        int op = 0;
        double result = 0, n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            op = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(",")))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //+
            op = 1;
            n = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //-
            op = 2;
            n = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //*
            op = 3;
            n = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                result = n + double.Parse(textBox1.Text);
            }
            else if (op == 2)
            {
                result = n - double.Parse(textBox1.Text);
            }
            else if (op == 3)
            {
                result = n * double.Parse(textBox1.Text);
            }
            else if (op == 4)
            {
                if (double.Parse(textBox1.Text) != 0)
                result = n / double.Parse(textBox1.Text);
            }
            textBox1.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ///
            op = 4;
            n = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
