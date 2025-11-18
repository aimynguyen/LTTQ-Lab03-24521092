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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai09
{
    public partial class Form1 : Form
    {
        public class QLSV
        {
            public string MSSV { get; set; }
            public string hoTen { get; set; }
            public string chuyenNganh { get; set; }
            public string gender { get; set; }
            public List<string> monHoc { get; set; }
            public string monHocc=>string.Join(", ", monHoc);
        }
        BindingList<QLSV> list = new BindingList<QLSV>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkedGT =false;
            string gt="";
            foreach(Control c in panelGender.Controls)
            {
                if(c is RadioButton rb && rb.Checked)
                {
                    checkedGT = true;
                    gt= rb.Text;
                }
            }

            if ((tbMSSV.Text=="" || tbTen.Text == "" || cbChuyenNganh.SelectedItem== null || checkedGT==false || lbMonHocDaChon.Items.Count==0 ))
            {
                MessageBox.Show("MISSING INFORMATION. Please fill out all required fields! ", "Warning");
                return;
            }

            //ds mon hoc
            List<string> monDaChon = new List<string>();
            foreach(var item in lbMonHocDaChon.Items)
            {
                monDaChon.Add(item.ToString());
            }

            //dssv
            QLSV qlsv = new QLSV { MSSV = tbMSSV.Text.ToString(), hoTen=tbTen.Text.ToString(), chuyenNganh=cbChuyenNganh.SelectedItem.ToString(), gender=gt, monHoc=monDaChon};
            list.Add(qlsv);

            tbMSSV.Clear();
            tbTen.Clear();
            cbChuyenNganh.SelectedItem = null;
            foreach (Control c in panelGender.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
            checkedGT = false;
            lbMonHocDaChon.Items.Clear();
        }

        private void btnDalete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count<=0)
            {
                MessageBox.Show("INVALID ROW", "Warning");
                return;
            }
            QLSV itemRemove = dataGridView1.SelectedRows[0].DataBoundItem as QLSV;

            if (itemRemove == null) return;

            DialogResult result = MessageBox.Show("Delete this row?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                list.Remove(itemRemove);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MSSV.DataPropertyName = "MSSV";
            hoTen.DataPropertyName = "hoTen";
            chuyenNganh.DataPropertyName = "chuyenNganh";
            gioiTinh.DataPropertyName = "gender";
            monHoc.DataPropertyName = "monHocc";

            dataGridView1.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbMonHoc.SelectedItem != null)
            {
                lbMonHocDaChon.Items.Add(lbMonHoc.SelectedItem.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbMonHocDaChon.SelectedItem != null)
            {
                lbMonHocDaChon.Items.Remove(lbMonHocDaChon.SelectedItem.ToString());
            }
        }
    }
}
