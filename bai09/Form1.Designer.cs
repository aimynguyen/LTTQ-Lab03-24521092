namespace bai09
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDalete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbMonHoc = new System.Windows.Forms.ListBox();
            this.panelGender = new System.Windows.Forms.Panel();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMonHocDaChon = new System.Windows.Forms.ListBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMonHocDaChon);
            this.groupBox1.Controls.Add(this.btnDalete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbMonHoc);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Controls.Add(this.cbChuyenNganh);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbMSSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnDalete
            // 
            this.btnDalete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDalete.Location = new System.Drawing.Point(548, 304);
            this.btnDalete.Name = "btnDalete";
            this.btnDalete.Size = new System.Drawing.Size(127, 33);
            this.btnDalete.TabIndex = 14;
            this.btnDalete.Text = "Xóa chọn";
            this.btnDalete.UseVisualStyleBackColor = true;
            this.btnDalete.Click += new System.EventHandler(this.btnDalete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(349, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(495, 259);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 33);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(495, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.FormattingEnabled = true;
            this.lbMonHoc.ItemHeight = 21;
            this.lbMonHoc.Items.AddRange(new object[] {
            "Cơ sở dữ liệu",
            "Lập trình trực quan",
            "Hệ điều hành",
            "Mạng máy tính",
            "DSA",
            "OOP"});
            this.lbMonHoc.Location = new System.Drawing.Point(240, 207);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(249, 88);
            this.lbMonHoc.TabIndex = 9;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.rbtnNu);
            this.panelGender.Controls.Add(this.rbtnNam);
            this.panelGender.Location = new System.Drawing.Point(337, 137);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(192, 36);
            this.panelGender.TabIndex = 8;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(113, 4);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(56, 24);
            this.rbtnNu.TabIndex = 1;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(4, 5);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(70, 24);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Items.AddRange(new object[] {
            "Kỹ thuật Phần mềm",
            "Hệ thống Thông tin",
            "Khoa học Máy tính",
            "Trí tuệ Nhân tạo",
            "Công nghệ Thông tin",
            "Công nghệ Thông tin (Việt-Nhật)",
            "Kỹ thuật Máy tính",
            "Mạng máy tính và Truyền thông dữ liệu",
            "Thiết kế vi mạch",
            "Khoa học dữ liệu",
            ""});
            this.cbChuyenNganh.Location = new System.Drawing.Point(337, 99);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(424, 28);
            this.cbChuyenNganh.TabIndex = 7;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(337, 63);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(424, 26);
            this.tbTen.TabIndex = 6;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(337, 27);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(424, 26);
            this.tbMSSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn các môn học tham gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.hoTen,
            this.chuyenNganh,
            this.gioiTinh,
            this.monHoc});
            this.dataGridView1.Location = new System.Drawing.Point(46, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(861, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbMonHocDaChon
            // 
            this.lbMonHocDaChon.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHocDaChon.FormattingEnabled = true;
            this.lbMonHocDaChon.ItemHeight = 21;
            this.lbMonHocDaChon.Location = new System.Drawing.Point(548, 210);
            this.lbMonHocDaChon.Name = "lbMonHocDaChon";
            this.lbMonHocDaChon.Size = new System.Drawing.Size(249, 88);
            this.lbMonHocDaChon.TabIndex = 15;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 8;
            this.MSSV.Name = "MSSV";
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.MinimumWidth = 8;
            this.hoTen.Name = "hoTen";
            // 
            // chuyenNganh
            // 
            this.chuyenNganh.HeaderText = "Chuyên ngành";
            this.chuyenNganh.MinimumWidth = 8;
            this.chuyenNganh.Name = "chuyenNganh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 8;
            this.gioiTinh.Name = "gioiTinh";
            // 
            // monHoc
            // 
            this.monHoc.HeaderText = "Môn Học";
            this.monHoc.MinimumWidth = 8;
            this.monHoc.Name = "monHoc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(962, 648);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.Button btnDalete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbMonHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbMonHocDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc;
    }
}

