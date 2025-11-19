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
        double ans = 0;
        char cal = ' ';
        double memory=0;
        bool isNewNum = true;
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
            if(isNewNum==true)
            {
                richTextBox1.Text = "";
                isNewNum = false;
            }
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
            if(richTextBox1.Text.Length>0) 
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
                    if (currentValue == 0) { richTextBox1.Text = "INVALID VALUE";
                        ans = 0;
                        cal = ' ';
                        isNewNum = true;
                        return; 
                    }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '/';
            richTextBox1.Text = "";
            isNewNum = true;
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
                    if (currentValue == 0) 
                    {
                        richTextBox1.Text = "INVALID VALUE";
                        ans = 0;
                        cal = ' ';
                        isNewNum = true;
                        return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '*';
            richTextBox1.Text = "";
            isNewNum = true;
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
                    if (currentValue == 0) {
                        richTextBox1.Text = "INVALID VALUE";
                        ans = 0;
                        cal = ' ';
                        isNewNum = true;
                        return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '-';
            richTextBox1.Text = "";
            isNewNum = true;
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
                    if (currentValue == 0) {
                        richTextBox1.Text = "INVALID VALUE";
                        ans = 0;
                        cal = ' ';
                        isNewNum = true; return; }
                    ans /= currentValue;
                    break;
                default:
                    ans = currentValue;
                    break;
            }

            cal = '+';
            richTextBox1.Text = "";
            isNewNum = true;
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
                        ans = 0;
                        cal = ' ';
                        isNewNum = true;
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
            isNewNum = true;
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
                ans = 0;
                isNewNum = true;
                return;
            }

            double result = Math.Sqrt(currentValue);
            richTextBox1.Text = result.ToString();
            isNewNum = true;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out double value))
            {
                richTextBox1.Text = (value * 0.01).ToString();
                isNewNum = true; 
            }
        }

        private void button1divx_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
            {
                return;
            }
            else if (currentValue == 0)
            {
                richTextBox1.Text = "INVALID VALUE";
                ans = 0;
                isNewNum = true;
            }
            else
            {
                richTextBox1.Text = (1 / currentValue).ToString();
            }
            isNewNum = true;
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
