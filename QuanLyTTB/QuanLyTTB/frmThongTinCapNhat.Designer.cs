namespace QuanLyTTB
{
     partial class frmThongTinCapNhat
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
               this.label3 = new System.Windows.Forms.Label();
               this.cbMaTTB = new System.Windows.Forms.ComboBox();
               this.tbGhiChu = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.btnXoa = new System.Windows.Forms.Button();
               this.panel9 = new System.Windows.Forms.Panel();
               this.btnHuy = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.btnSua = new System.Windows.Forms.Button();
               this.tbTimKiem = new System.Windows.Forms.TextBox();
               this.btnThem = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.panel9.SuspendLayout();
               this.SuspendLayout();
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(26, 140);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(46, 13);
               this.label3.TabIndex = 79;
               this.label3.Text = "Mã TTB";
               // 
               // cbMaTTB
               // 
               this.cbMaTTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbMaTTB.FormattingEnabled = true;
               this.cbMaTTB.Location = new System.Drawing.Point(101, 130);
               this.cbMaTTB.Name = "cbMaTTB";
               this.cbMaTTB.Size = new System.Drawing.Size(159, 23);
               this.cbMaTTB.TabIndex = 92;
               // 
               // tbGhiChu
               // 
               this.tbGhiChu.Location = new System.Drawing.Point(101, 188);
               this.tbGhiChu.Margin = new System.Windows.Forms.Padding(2);
               this.tbGhiChu.Multiline = true;
               this.tbGhiChu.Name = "tbGhiChu";
               this.tbGhiChu.Size = new System.Drawing.Size(159, 32);
               this.tbGhiChu.TabIndex = 90;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(24, 191);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(48, 13);
               this.label5.TabIndex = 89;
               this.label5.Text = "Ghi Chú ";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(-76, 32);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(53, 13);
               this.label1.TabIndex = 78;
               this.label1.Text = "Mã LSCN";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(393, 74);
               this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(124, 13);
               this.label9.TabIndex = 86;
               this.label9.Text = "Danh sách Trang thiết bị";
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(396, 89);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(631, 425);
               this.dataGridView1.TabIndex = 85;
               this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
               this.panel9.Controls.Add(this.btnSua);
               this.panel9.Controls.Add(this.btnThem);
               this.panel9.Controls.Add(this.btnLuu);
               this.panel9.Controls.Add(this.btnXoa);
               this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel9.Location = new System.Drawing.Point(0, 0);
               this.panel9.Margin = new System.Windows.Forms.Padding(2);
               this.panel9.Name = "panel9";
               this.panel9.Size = new System.Drawing.Size(1071, 64);
               this.panel9.TabIndex = 76;
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
               this.label2.Location = new System.Drawing.Point(26, 304);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(49, 13);
               this.label2.TabIndex = 7;
               this.label2.Text = "Tìm kiếm";
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
               // tbTimKiem
               // 
               this.tbTimKiem.Location = new System.Drawing.Point(101, 301);
               this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
               this.tbTimKiem.Multiline = true;
               this.tbTimKiem.Name = "tbTimKiem";
               this.tbTimKiem.Size = new System.Drawing.Size(261, 32);
               this.tbTimKiem.TabIndex = 6;
               this.tbTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTimKiem_KeyDown);
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
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(-79, 99);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(75, 13);
               this.label4.TabIndex = 81;
               this.label4.Text = "Loại Cập Nhật";
               // 
               // frmThongTinCapNhat
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1071, 526);
               this.Controls.Add(this.cbMaTTB);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.tbTimKiem);
               this.Controls.Add(this.tbGhiChu);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.panel9);
               this.Name = "frmThongTinCapNhat";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "frmThongTinCapNhat";
               this.Load += new System.EventHandler(this.frmThongTinCapNhat_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.panel9.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaTTB;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label4;
    }
}