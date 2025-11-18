using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;            
            this.FormClosing += Form1_Closing;
            this.FormClosed += Form1_Closed;
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load: form đang load");
        }
       
        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Shown: form đang hiển thị lần đầu");
        }
        bool shown = false;
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (shown == false)
            {
                MessageBox.Show("Activated: form đang focus");
                shown = true;
            }
        }
        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Closing: form đang chuẩn bị đóng");
        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closed: form đã đóng");
        }
       
    }
}
