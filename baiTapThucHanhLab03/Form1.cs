using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTapThucHanhLab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
                int r=random.Next(0,255);
                int g1=random.Next(0,255);
                int b=random.Next(0,255);
                this.BackColor= Color.FromArgb(r,g1,b);
        }
    }
}
