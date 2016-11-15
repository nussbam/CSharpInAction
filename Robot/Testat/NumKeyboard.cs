using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Testat
{
    public partial class NumKeyboard : Form
    {
        public NumKeyboard()
        {
            InitializeComponent();
        }

        private String escZero(String text)
        {
            return (text.StartsWith("0")) ? text.Substring(1) : text;
        }

        private String checkString(String text)
        {
            return (text == "" || text == "-") ? text = "0" : text;
        }

        public Int32 getWert()
        {
            return Int32.Parse(checkString(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text += "9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.StartsWith("-") || textBox1.Text.Length > 1)
            {
                textBox1.Text = escZero(textBox1.Text += "0");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = escZero(textBox1.Text);
            textBox1.Text = escZero(textBox1.Text.StartsWith("-") ? textBox1.Text.Substring(1) : "-" + textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Length > 0 ? textBox1.Text.Remove(textBox1.Text.Length - 1, 1) : textBox1.Text;
            textBox1.Text = textBox1.Text == "-" ? "0" : textBox1.Text;
            textBox1.Text = textBox1.Text == "" ? "0" : textBox1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) + 1).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) + 10).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) + 100).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) - 1).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) - 10).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(checkString(textBox1.Text)) - 100).ToString();
        }
    }
}