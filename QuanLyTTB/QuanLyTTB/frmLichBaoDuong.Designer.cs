namespace QuanLyTTB
{
     partial class frmLichBaoDuong
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
               this.btnThem = new System.Windows.Forms.Button();
               this.panel9 = new System.Windows.Forms.Panel();
               this.btnHuy = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.tbTimKiem = new System.Windows.Forms.TextBox();
               this.btnSua = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label9 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.tbDonVi = new System.Windows.Forms.TextBox();
               this.tbMaLBD = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.tbMaCB = new System.Windows.Forms.TextBox();
               this.tbKip = new System.Windows.Forms.TextBox();
               this.tbNgay = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.tbCongViec = new System.Windows.Forms.TextBox();
               this.tbMaLLV = new System.Windows.Forms.TextBox();
               this.panel9.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // btnThem
               // 
               this.btnThem.Location = new System.Drawing.Point(29, 9);
               this.btnThem.Margin = new System.Windows.Forms.Padding(2);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(75, 46);
               this.btnThem.TabIndex = 2;
               this.btnThem.Text = "Thêm";
               this.btnThem.UseVisualStyleBackColor = true;
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // panel9
               // 
               this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.panel9.Controls.Add(this.btnHuy);
               this.panel9.Controls.Add(this.label2);
               this.panel9.Controls.Add(this.tbTimKiem);
               this.panel9.Controls.Add(this.btnSua);
               this.panel9.Controls.Add(this.btnThem);
               this.panel9.Controls.Add(this.btnLuu);
               this.panel9.Controls.Add(this.btnXoa);
               this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel9.Location = new System.Drawing.Point(0, 0);
               this.panel9.Margin = new System.Windows.Forms.Padding(2);
               this.panel9.Name = "panel9";
               this.panel9.Size = new System.Drawing.Size(1056, 64);
               this.panel9.TabIndex = 95;
               // 
               // btnHuy
               // 
               this.btnHuy.Location = new System.Drawing.Point(486, 9);
               this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
               this.btnHuy.Name = "btnHuy";
               this.btnHuy.Size = new System.Drawing.Size(75, 46);
               this.btnHuy.TabIndex = 8;
               this.btnHuy.Text = "Hủy";
               this.btnHuy.UseVisualStyleBackColor = true;
               this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(646, 14);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(49, 13);
               this.label2.TabIndex = 94;
               this.label2.Text = "Tìm kiếm";
               // 
               // tbTimKiem
               // 
               this.tbTimKiem.Location = new System.Drawing.Point(720, 11);
               this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
               this.tbTimKiem.Multiline = true;
               this.tbTimKiem.Name = "tbTimKiem";
               this.tbTimKiem.Size = new System.Drawing.Size(261, 32);
               this.tbTimKiem.TabIndex = 93;
               this.tbTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTimKiem_KeyDown);
               // 
               // btnSua
               // 
               this.btnSua.Location = new System.Drawing.Point(155, 9);
               this.btnSua.Margin = new System.Windows.Forms.Padding(2);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(75, 46);
               this.btnSua.TabIndex = 2;
               this.btnSua.Text = "Sửa";
               this.btnSua.UseVisualStyleBackColor = true;
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // btnLuu
               // 
               this.btnLuu.Location = new System.Drawing.Point(383, 9);
               this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
               this.btnLuu.Name = "btnLuu";
               this.btnLuu.Size = new System.Drawing.Size(75, 46);
               this.btnLuu.TabIndex = 2;
               this.btnLuu.Text = "Lưu";
               this.btnLuu.UseVisualStyleBackColor = true;
               this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
               // 
               // btnXoa
               // 
               this.btnXoa.Location = new System.Drawing.Point(270, 9);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(75, 46);
               this.btnXoa.TabIndex = 2;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.UseVisualStyleBackColor = true;
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(414, 96);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(631, 425);
               this.dataGridView1.TabIndex = 99;
               this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(411, 81);
               this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(136, 13);
               this.label9.TabIndex = 100;
               this.label9.Text = "Danh sách Lịch bảo dưỡng";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(44, 113);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(46, 13);
               this.label3.TabIndex = 97;
               this.label3.Text = "Mã LBD";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(44, 173);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(39, 13);
               this.label5.TabIndex = 101;
               this.label5.Text = "Đơn Vị";
               // 
               // tbDonVi
               // 
               this.tbDonVi.Location = new System.Drawing.Point(119, 170);
               this.tbDonVi.Margin = new System.Windows.Forms.Padding(2);
               this.tbDonVi.Multiline = true;
               this.tbDonVi.Name = "tbDonVi";
               this.tbDonVi.Size = new System.Drawing.Size(159, 32);
               this.tbDonVi.TabIndex = 102;
               // 
               // tbMaLBD
               // 
               this.tbMaLBD.Location = new System.Drawing.Point(119, 110);
               this.tbMaLBD.Margin = new System.Windows.Forms.Padding(2);
               this.tbMaLBD.Multiline = true;
               this.tbMaLBD.Name = "tbMaLBD";
               this.tbMaLBD.Size = new System.Drawing.Size(159, 32);
               this.tbMaLBD.TabIndex = 103;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(46, 233);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(44, 13);
               this.label1.TabIndex = 104;
               this.label1.Text = "Mã LLV";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(44, 302);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(42, 13);
               this.label4.TabIndex = 105;
               this.label4.Text = "Mã  CB";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(44, 372);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(32, 13);
               this.label6.TabIndex = 106;
               this.label6.Text = "Ngày";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(44, 481);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(24, 13);
               this.label7.TabIndex = 107;
               this.label7.Text = "Kíp";
               // 
               // tbMaCB
               // 
               this.tbMaCB.Location = new System.Drawing.Point(119, 299);
               this.tbMaCB.Margin = new System.Windows.Forms.Padding(2);
               this.tbMaCB.Multiline = true;
               this.tbMaCB.Name = "tbMaCB";
               this.tbMaCB.Size = new System.Drawing.Size(159, 32);
               this.tbMaCB.TabIndex = 109;
               // 
               // tbKip
               // 
               this.tbKip.Location = new System.Drawing.Point(119, 478);
               this.tbKip.Margin = new System.Windows.Forms.Padding(2);
               this.tbKip.Multiline = true;
               this.tbKip.Name = "tbKip";
               this.tbKip.Size = new System.Drawing.Size(159, 32);
               this.tbKip.TabIndex = 110;
               // 
               // tbNgay
               // 
               this.tbNgay.Location = new System.Drawing.Point(119, 369);
               this.tbNgay.Margin = new System.Windows.Forms.Padding(2);
               this.tbNgay.Multiline = true;
               this.tbNgay.Name = "tbNgay";
               this.tbNgay.Size = new System.Drawing.Size(159, 32);
               this.tbNgay.TabIndex = 111;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(44, 431);
               this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(56, 13);
               this.label8.TabIndex = 112;
               this.label8.Text = "Công Việc";
               // 
               // tbCongViec
               // 
               this.tbCongViec.Location = new System.Drawing.Point(119, 428);
               this.tbCongViec.Margin = new System.Windows.Forms.Padding(2);
               this.tbCongViec.Multiline = true;
               this.tbCongViec.Name = "tbCongViec";
               this.tbCongViec.Size = new System.Drawing.Size(159, 32);
               this.tbCongViec.TabIndex = 113;
               // 
               // tbMaLLV
               // 
               this.tbMaLLV.Location = new System.Drawing.Point(119, 230);
               this.tbMaLLV.Margin = new System.Windows.Forms.Padding(2);
               this.tbMaLLV.Multiline = true;
               this.tbMaLLV.Name = "tbMaLLV";
               this.tbMaLLV.Size = new System.Drawing.Size(159, 32);
               this.tbMaLLV.TabIndex = 108;
               // 
               // frmLichBaoDuong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1056, 556);
               this.Controls.Add(this.tbCongViec);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.tbNgay);
               this.Controls.Add(this.tbKip);
               this.Controls.Add(this.tbMaCB);
               this.Controls.Add(this.tbMaLLV);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.tbMaLBD);
               this.Controls.Add(this.tbDonVi);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.panel9);
               this.Name = "frmLichBaoDuong";
               this.Text = "frmLichBaoDuong";
               this.Load += new System.EventHandler(this.frmLichBaoDuong_Load);
               this.panel9.ResumeLayout(false);
               this.panel9.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.TextBox tbMaLBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaCB;
        private System.Windows.Forms.TextBox tbKip;
        private System.Windows.Forms.TextBox tbNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCongViec;
        private System.Windows.Forms.TextBox tbMaLLV;
    }
}