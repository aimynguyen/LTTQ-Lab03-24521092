using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;      
        }

        bool isDrawing = false;
        Point curPoint;
        List<Point> points = new List<Point>();

        Font font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {           
            Graphics g = e.Graphics;
            foreach (Point p in points)
            {
                g.DrawString("Hello", font, Brushes.Chocolate, p);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            points.Add(e.Location);
            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                points.Add(e.Location);
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
