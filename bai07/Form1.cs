using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai07
{
    
    public partial class Form1 : Form
    {
        int total = 0;        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 16; i++)
            {
                list[i] = false;
            }

        }
        bool[] list = new bool[16];
        public void Button_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            int price=0;
            switch (seat.Text.ToString()) 
            {
                case "1": case "2": case "3": case "4": case "5":
                    price = 5000; break;
                case "6": case "7": case "8": case "9": case "10":
                    price = 6500; break;
                case "11": case "12": case "13": case "14": case "15":
                    price = 8000; break;
            }
            if (seat.BackColor == Color.LavenderBlush) 
            {
                seat.BackColor = Color.LightBlue;//chon ghe
                list[int.Parse(seat.Text)] = true;
                total += price;
                tbTotal.Text = total.ToString();
            }
            else if(seat.BackColor == Color.LightBlue)
            {
                seat.BackColor = Color.LavenderBlush;// bo ghe
                list[int.Parse(seat.Text)] = false;
                total -= price;
                tbTotal.Text = total.ToString();
            }
            else if( seat.BackColor == Color.LemonChiffon)//ghe da chon
            {
                MessageBox.Show("Ghế ở vị trí này đã được bán. Vui lòng chọn ghế khác! ");
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c is Button seat && seat.BackColor == Color.LightBlue)
                {
                    seat.BackColor = Color.LemonChiffon;
                }
            }
            MessageBox.Show("Bạn đã mua thành công! Tổng tiền: " + total, "Mua vé thành công");
            total = 0;
            tbTotal.Text = "0";
          
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Button seat && seat.BackColor == Color.LightBlue)
                {
                    seat.BackColor = Color.LavenderBlush;
                }
            }
            total = 0;
            tbTotal.Text = "0";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
