using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai06
{
    public partial class Form1 : Form
    {
        double ans = 0f;
        char cal = ' ';
        double memory=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                if (!richTextBox1.Text.Contains("."))
                {
                    if (richTextBox1.Text == null)
                    {
                        richTextBox1.Text = "0.";
                    }
                    else
                    {
                        richTextBox1.Text += ".";
                    }
                }
                return;
            }
            richTextBox1.Text += btn.Text;
        }
        
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            cal = ' ';
            ans = 0f;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=memory.ToString();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            double.TryParse(richTextBox1.Text, out memory);
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }
            memory += currentValue;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }

            switch (cal)
            {
                case '+': ans += currentValue; break;
                case '-': ans -= currentValue; break;
                case '*': ans *= currentValue; break;
                case '/':
                    if (currentValue == 0) { richTextBox1.Text = "INVALID VALUE"; return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '/';
            richTextBox1.Text = "";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {            
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }

            switch (cal)
            {
                case '+': ans += currentValue; break;
                case '-': ans -= currentValue; break;
                case '*': ans *= currentValue; break;
                case '/':
                    if (currentValue == 0) { richTextBox1.Text = "INVALID VALUE"; return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '*';
            richTextBox1.Text = ""; 
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }

            switch (cal)
            {
                case '+': ans += currentValue; break;
                case '-': ans -= currentValue; break;
                case '*': ans *= currentValue; break;
                case '/':
                    if (currentValue == 0) { richTextBox1.Text = "INVALID VALUE"; return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '-';
            richTextBox1.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }

            switch (cal)
            {
                case '+': ans += currentValue; break;
                case '-': ans -= currentValue; break;
                case '*': ans *= currentValue; break;
                case '/':
                    if (currentValue == 0) { richTextBox1.Text = "INVALID VALUE"; return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '+';
            richTextBox1.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }
            switch (cal)
            {
                case '+':
                    ans += currentValue;
                    break;
                case '-':
                    ans -= currentValue;
                    break;
                case '*':
                    ans *= currentValue;
                    break;
                case '/':
                    if(currentValue == 0)
                    {
                        richTextBox1.Text = "INVALID VALUE";
                        return;
                    }
                    ans /= currentValue;
                    break;
                
                default:
                    ans = currentValue;
                    break;
            }
            richTextBox1.Text = ans.ToString();
            cal = ' ';
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }

            if (currentValue < 0)
            {
                richTextBox1.Text = "INVALID VALUE";
                return;
            }

            ans = Math.Sqrt(currentValue);
            richTextBox1.Text = ans.ToString();
            cal = ' '; 
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=(double.Parse(richTextBox1.Text)*0.01).ToString();
        }

        private void button1divx_Click(object sender, EventArgs e)
        {
            if (double.Parse(richTextBox1.Text) == 0)
            {
                richTextBox1.Text = "INVALID VALUE";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
