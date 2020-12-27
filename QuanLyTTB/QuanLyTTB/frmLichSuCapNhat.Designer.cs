namespace QuanLyTTB
{
     partial class frmLichSuCapNhat
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
               this.tbND = new System.Windows.Forms.TextBox();
               this.label11 = new System.Windows.Forms.Label();
               this.btnHuy = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.btnSua = new System.Windows.Forms.Button();
               this.tbTimKiem = new System.Windows.Forms.TextBox();
               this.label9 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label8 = new System.Windows.Forms.Label();
               this.dataGridView2 = new System.Windows.Forms.DataGridView();
               this.panel9 = new System.Windows.Forms.Panel();
               this.btnThem = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.tbMaLSCN = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.tbLoaiCN = new System.Windows.Forms.TextBox();
               this.cbMaCB = new System.Windows.Forms.ComboBox();
               this.label7 = new System.Windows.Forms.Label();
               this.cbTenCB = new System.Windows.Forms.ComboBox();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
               this.panel9.SuspendLayout();
               this.SuspendLayout();
               // 
               // tbND
               // 
               this.tbND.Location = new System.Drawing.Point(128, 236);
               this.tbND.Multiline = true;
               this.tbND.Name = "tbND";
               this.tbND.Size = new System.Drawing.Size(159, 35);
               this.tbND.TabIndex = 69;
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(26, 239);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(52, 13);
               this.label11.TabIndex = 68;
               this.label11.Text = "Nội Dung";
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
               this.label2.Location = new System.Drawing.Point(714, 30);
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
               this.tbTimKiem.Location = new System.Drawing.Point(805, 23);
               this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
               this.tbTimKiem.Multiline = true;
               this.tbTimKiem.Name = "tbTimKiem";
               this.tbTimKiem.Size = new System.Drawing.Size(261, 32);
               this.tbTimKiem.TabIndex = 6;
               this.tbTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTimKiem_KeyDown);
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(663, 82);
               this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(124, 13);
               this.label9.TabIndex = 66;
               this.label9.Text = "Danh sách Trang thiết bị";
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(656, 97);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(561, 570);
               this.dataGridView1.TabIndex = 65;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(26, 341);
               this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(86, 13);
               this.label8.TabIndex = 64;
               this.label8.Text = "Lịch sử cập nhật";
               // 
               // dataGridView2
               // 
               this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView2.Location = new System.Drawing.Point(26, 359);
               this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
               this.dataGridView2.Name = "dataGridView2";
               this.dataGridView2.RowHeadersWidth = 51;
               this.dataGridView2.RowTemplate.Height = 24;
               this.dataGridView2.Size = new System.Drawing.Size(581, 308);
               this.dataGridView2.TabIndex = 63;
               this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
               this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
               // 
               // panel9
               // 
               this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.panel9.Controls.Add(this.btnHuy);
               this.panel9.Controls.Add(this.label2);
               this.panel9.Controls.Add(this.btnSua);
               this.panel9.Controls.Add(this.tbTimKiem);
               this.panel9.Controls.Add(this.btnThem);
               this.panel9.Controls.Add(this.btnLuu);
               this.panel9.Controls.Add(this.btnXoa);
               this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel9.Location = new System.Drawing.Point(0, 0);
               this.panel9.Margin = new System.Windows.Forms.Padding(2);
               this.panel9.Name = "panel9";
               this.panel9.Size = new System.Drawing.Size(1228, 64);
               this.panel9.TabIndex = 50;
               // 
               // btnThem
               // 
               this.btnThem.Location = new System.Drawing.Point(26, 9);
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
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(357, 86);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(60, 13);
               this.label6.TabIndex = 59;
               this.label6.Text = "Mã Cán Bộ";
               // 
               // tbMaLSCN
               // 
               this.tbMaLSCN.Location = new System.Drawing.Point(128, 79);
               this.tbMaLSCN.Margin = new System.Windows.Forms.Padding(2);
               this.tbMaLSCN.Multiline = true;
               this.tbMaLSCN.Name = "tbMaLSCN";
               this.tbMaLSCN.Size = new System.Drawing.Size(159, 27);
               this.tbMaLSCN.TabIndex = 51;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(26, 86);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(53, 13);
               this.label1.TabIndex = 52;
               this.label1.Text = "Mã LSCN";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(23, 153);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(75, 13);
               this.label4.TabIndex = 56;
               this.label4.Text = "Loại Cập Nhật";
               // 
               // tbLoaiCN
               // 
               this.tbLoaiCN.Location = new System.Drawing.Point(128, 150);
               this.tbLoaiCN.Margin = new System.Windows.Forms.Padding(2);
               this.tbLoaiCN.Multiline = true;
               this.tbLoaiCN.Name = "tbLoaiCN";
               this.tbLoaiCN.Size = new System.Drawing.Size(159, 32);
               this.tbLoaiCN.TabIndex = 55;
               // 
               // cbMaCB
               // 
               this.cbMaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbMaCB.FormattingEnabled = true;
               this.cbMaCB.Location = new System.Drawing.Point(448, 83);
               this.cbMaCB.Name = "cbMaCB";
               this.cbMaCB.Size = new System.Drawing.Size(159, 23);
               this.cbMaCB.TabIndex = 72;
               this.cbMaCB.SelectedIndexChanged += new System.EventHandler(this.cbMaCB_SelectedIndexChanged);
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(357, 159);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(64, 13);
               this.label7.TabIndex = 74;
               this.label7.Text = "Tên Cán Bộ";
               // 
               // cbTenCB
               // 
               this.cbTenCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbTenCB.FormattingEnabled = true;
               this.cbTenCB.Location = new System.Drawing.Point(448, 153);
               this.cbTenCB.Name = "cbTenCB";
               this.cbTenCB.Size = new System.Drawing.Size(159, 23);
               this.cbTenCB.TabIndex = 75;
               // 
               // frmLichSuCapNhat
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1228, 670);
               this.Controls.Add(this.cbTenCB);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.cbMaCB);
               this.Controls.Add(this.tbND);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.dataGridView2);
               this.Controls.Add(this.panel9);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.tbMaLSCN);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.tbLoaiCN);
               this.Name = "frmLichSuCapNhat";
               this.Text = "frmLichSuCapNhat";
               this.Load += new System.EventHandler(this.frmLichSuCapNhat_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
               this.panel9.ResumeLayout(false);
               this.panel9.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.TextBox tbND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaLSCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoaiCN;
          private System.Windows.Forms.ComboBox cbMaCB;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.ComboBox cbTenCB;
     }
}