using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai08
{
    public partial class Form1 : Form
    {
        long TongTien = 0;
        public class qltt
        {
            public string stk { get; set; }
            public string tenKh { get; set; }
            public string diaChi { get; set; }
            public long soTien { get; set; }

        }
        BindingList<qltt> list;
        public Form1()
        {
            InitializeComponent();
            list = new BindingList<qltt>();
            dataGridView1.DataSource = list;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxSTK.Text == null || textBoxTenKH.Text == null || textBoxDCKH.Text == null || textBoxSoTien.Text == null)
            {
                MessageBox.Show("MISSING INFORMATION. Please fill out all required fields! ", "Warning");
                return;
            }

            long tien;
            while (!long.TryParse(textBoxSoTien.Text, out tien))
            {
                MessageBox.Show("INVALID DATA. Please enter again! ");
                textBoxSoTien.Clear();
                textBoxSoTien.Focus();
                return;
            }
            TongTien += tien;
            textBox1.Text=TongTien.ToString();
            qltt item = new qltt { stk = textBoxSTK.Text, tenKh = textBoxTenKH.Text, diaChi = textBoxDCKH.Text, soTien = tien };
            list.Add(item);
            textBoxSTK.Clear();
            textBoxTenKH.Clear();
            textBoxDCKH.Clear();
            textBoxSoTien.Clear();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("INVALID ROW");
            qltt itemRemove = dataGridView1.SelectedRows[0].DataBoundItem as qltt;

            if (itemRemove == null) return; 

            DialogResult result = MessageBox.Show("Delete this row?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {                
                TongTien -= itemRemove.soTien;
                textBox1.Text = TongTien.ToString(); 

                list.Remove(itemRemove);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
