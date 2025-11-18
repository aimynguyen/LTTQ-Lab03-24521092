using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double input = 0;
            if (double.TryParse(textBox1.Text, out input))
                sum += input;
            else 
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            if (double.TryParse(textBox2.Text, out input))
                sum += input;
            else
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sub = 0;
            double input = 0;
            if (double.TryParse(textBox1.Text, out input))
                sub = input;
            else 
            { 
                MessageBox.Show("Khong hop le!");
                return;
            }
            if (double.TryParse(textBox2.Text, out input))
                sub -= input;
            else
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mul = 1;
            double input = 0;
            if (double.TryParse(textBox1.Text, out input))
                mul = input;
            else
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            if (double.TryParse(textBox2.Text, out input))
                mul *= input;
            else
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double div = 1;
            double input = 0;
            if (double.TryParse(textBox1.Text, out input))
                div = input;
            else
            {
                MessageBox.Show("Khong hop le!");
                return;
            }
            if (!double.TryParse(textBox2.Text, out input))                
                    {
                        MessageBox.Show("Khong hop le!");
                        return;
                    }
            else
            {
                if (input == 0)
                {
                    MessageBox.Show("Khong the chia cho 0");
                    return;
                }
                else
                    div /= input;
                textBox3.Text = div.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
