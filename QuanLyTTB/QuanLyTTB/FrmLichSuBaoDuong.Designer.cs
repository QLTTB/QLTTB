namespace QuanLyTTB
{
     partial class FrmLichSuBaoDuong
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
               this.btnHuy = new System.Windows.Forms.Button();
               this.label9 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label2 = new System.Windows.Forms.Label();
               this.tbTimKiem = new System.Windows.Forms.TextBox();
               this.btnSua = new System.Windows.Forms.Button();
               this.btnThem = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.panel9 = new System.Windows.Forms.Panel();
               this.tbTGBĐ = new System.Windows.Forms.TextBox();
               this.tbTGKT = new System.Windows.Forms.TextBox();
               this.tbDanhGia = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.cbLBD = new System.Windows.Forms.ComboBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.cbDonVi = new System.Windows.Forms.ComboBox();
               this.cbNgay = new System.Windows.Forms.ComboBox();
               this.cbKip = new System.Windows.Forms.ComboBox();
               this.label10 = new System.Windows.Forms.Label();
               this.cbMaCB = new System.Windows.Forms.ComboBox();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.panel9.SuspendLayout();
               this.SuspendLayout();
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
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(411, 99);
               this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(150, 13);
               this.label9.TabIndex = 117;
               this.label9.Text = "Danh sách Lịch sử bảo dưỡng";
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(414, 114);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(631, 425);
               this.dataGridView1.TabIndex = 116;
               this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
               this.panel9.TabIndex = 114;
               // 
               // tbTGBĐ
               // 
               this.tbTGBĐ.Location = new System.Drawing.Point(119, 317);
               this.tbTGBĐ.Margin = new System.Windows.Forms.Padding(2);
               this.tbTGBĐ.Multiline = true;
               this.tbTGBĐ.Name = "tbTGBĐ";
               this.tbTGBĐ.Size = new System.Drawing.Size(159, 32);
               this.tbTGBĐ.TabIndex = 125;
               // 
               // tbTGKT
               // 
               this.tbTGKT.Location = new System.Drawing.Point(119, 264);
               this.tbTGKT.Margin = new System.Windows.Forms.Padding(2);
               this.tbTGKT.Multiline = true;
               this.tbTGKT.Name = "tbTGKT";
               this.tbTGKT.Size = new System.Drawing.Size(159, 32);
               this.tbTGKT.TabIndex = 126;
               // 
               // tbDanhGia
               // 
               this.tbDanhGia.Location = new System.Drawing.Point(119, 202);
               this.tbDanhGia.Margin = new System.Windows.Forms.Padding(2);
               this.tbDanhGia.Multiline = true;
               this.tbDanhGia.Name = "tbDanhGia";
               this.tbDanhGia.Size = new System.Drawing.Size(159, 32);
               this.tbDanhGia.TabIndex = 128;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(50, 205);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(52, 13);
               this.label6.TabIndex = 123;
               this.label6.Text = "Đánh Giá";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(52, 320);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(36, 13);
               this.label4.TabIndex = 122;
               this.label4.Text = "TGKT";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(52, 267);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(37, 13);
               this.label1.TabIndex = 121;
               this.label1.Text = "TGBĐ";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(50, 114);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(46, 13);
               this.label5.TabIndex = 118;
               this.label5.Text = "Mã LBD";
               // 
               // cbLBD
               // 
               this.cbLBD.FormattingEnabled = true;
               this.cbLBD.Location = new System.Drawing.Point(119, 111);
               this.cbLBD.Name = "cbLBD";
               this.cbLBD.Size = new System.Drawing.Size(159, 21);
               this.cbLBD.TabIndex = 129;
               this.cbLBD.SelectedIndexChanged += new System.EventHandler(this.cbLBD_SelectedIndexChanged);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(50, 381);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(39, 13);
               this.label3.TabIndex = 130;
               this.label3.Text = "Đơn Vị";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(50, 439);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(32, 13);
               this.label7.TabIndex = 131;
               this.label7.Text = "Ngày";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(50, 488);
               this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(24, 13);
               this.label8.TabIndex = 132;
               this.label8.Text = "Kíp";
               // 
               // cbDonVi
               // 
               this.cbDonVi.FormattingEnabled = true;
               this.cbDonVi.Location = new System.Drawing.Point(119, 381);
               this.cbDonVi.Name = "cbDonVi";
               this.cbDonVi.Size = new System.Drawing.Size(159, 21);
               this.cbDonVi.TabIndex = 133;
               // 
               // cbNgay
               // 
               this.cbNgay.FormattingEnabled = true;
               this.cbNgay.Location = new System.Drawing.Point(119, 436);
               this.cbNgay.Name = "cbNgay";
               this.cbNgay.Size = new System.Drawing.Size(159, 21);
               this.cbNgay.TabIndex = 134;
               // 
               // cbKip
               // 
               this.cbKip.FormattingEnabled = true;
               this.cbKip.Location = new System.Drawing.Point(119, 485);
               this.cbKip.Name = "cbKip";
               this.cbKip.Size = new System.Drawing.Size(159, 21);
               this.cbKip.TabIndex = 135;
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Location = new System.Drawing.Point(50, 157);
               this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(39, 13);
               this.label10.TabIndex = 136;
               this.label10.Text = "Mã CB";
               // 
               // cbMaCB
               // 
               this.cbMaCB.FormattingEnabled = true;
               this.cbMaCB.Location = new System.Drawing.Point(119, 154);
               this.cbMaCB.Name = "cbMaCB";
               this.cbMaCB.Size = new System.Drawing.Size(159, 21);
               this.cbMaCB.TabIndex = 137;
               // 
               // FrmLichSuBaoDuong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1056, 556);
               this.Controls.Add(this.cbMaCB);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.cbKip);
               this.Controls.Add(this.cbNgay);
               this.Controls.Add(this.cbDonVi);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.cbLBD);
               this.Controls.Add(this.tbTGKT);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.tbDanhGia);
               this.Controls.Add(this.tbTGBĐ);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.panel9);
               this.Name = "FrmLichSuBaoDuong";
               this.Text = "FrmLichSuBaoDuong";
               this.Load += new System.EventHandler(this.FrmLichSuBaoDuong_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.panel9.ResumeLayout(false);
               this.panel9.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbTGBĐ;
        private System.Windows.Forms.TextBox tbTGKT;
        private System.Windows.Forms.TextBox tbDanhGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox cbLBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.ComboBox cbNgay;
        private System.Windows.Forms.ComboBox cbKip;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.ComboBox cbMaCB;
    }
}