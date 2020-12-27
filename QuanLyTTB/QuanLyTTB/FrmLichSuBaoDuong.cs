using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTTB
{
     public partial class FrmLichSuBaoDuong : Form
     {
          public FrmLichSuBaoDuong()
          {
               InitializeComponent();
          }
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          public int check;
          public void reset()
          {
               table = new DataTable();
               table = connector.LoadData("OutPutTable", "7", "");
               dataGridView1.DataSource = table;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
               cbDonVi.Enabled = true;
               cbNgay.Enabled = true;
               cbKip.Enabled = true;
          }
          public void Disable()
          {
               btnThem.Enabled = false;
               btnSua.Enabled = false;
               btnXoa.Enabled = false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
               cbDonVi.Enabled = false;
               cbNgay.Enabled = false;
               cbKip.Enabled = false;
          }
          public void ResetValue()
          {
               cbLBD.ResetText();
               cbMaCB.ResetText();
               tbDanhGia.ResetText();
               tbTGBĐ.ResetText();
               tbTGKT.ResetText();
               cbDonVi.ResetText();
               cbNgay.ResetText();
               cbKip.ResetText();
          }
          private void FrmLichSuBaoDuong_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }

          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               cbLBD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               cbMaCB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               tbTGBĐ.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               tbTGKT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               tbDanhGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               cbDonVi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               cbNgay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               cbKip.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               Disable();
               ResetValue();
               table = new DataTable();
               table = connector.LoadData("OutPutTable","4","");
               cbLBD.DataSource = table;
               cbLBD.DisplayMember = "Ma_LBD";
               cbLBD.ValueMember = "Ma_LBD";
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTable", "1", "");
               cbMaCB.DataSource = table1;
               cbMaCB.DisplayMember = "Ma_CB";
               cbMaCB.ValueMember = "Ma_CB";
               check = 0;


          }

          private void btnHuy_Click(object sender, EventArgs e)
          {
               Enable();
               cbLBD.Enabled = true;
               ResetValue();
          }

          private void cbLBD_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    table = new DataTable();
                    table = connector.LoadData("OutPutTableByID", "4", cbLBD.Text);
                    cbDonVi.DataSource = table;
                    cbDonVi.DisplayMember = "DonVi";
                    cbDonVi.ValueMember = "DonVi";
                    cbNgay.DataSource = table;
                    cbNgay.DisplayMember = "Ngay";
                    cbNgay.ValueMember = "Ngay";
                    cbKip.DataSource = table;
                    cbKip.DisplayMember = "Kip";
                    cbKip.ValueMember = "Kip";
               }
               catch
               {

               }
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if (cbLBD.Text == ""||cbMaCB.Text == "" ||tbDanhGia.Text==""||tbTGBĐ.Text == ""||tbTGKT.Text =="" )
               {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông Báo");
               }
               else
               {

                    if (check == 0)
                    {
                         connector.InsertUpdateObject("AddObject", "7", cbLBD.Text, cbMaCB.Text, tbTGBĐ.Text, tbTGKT.Text, "", tbDanhGia.Text, "", "", "", "", "", "");
                         MessageBox.Show("Thêm Thành Công", "Thông Báo");
                         ResetValue();
                         reset();
                    }
                    if (check == 1)
                    {
                         connector.InsertUpdateObject("EditObject", "7", cbMaCB.Text, "", tbTGBĐ.Text, tbTGKT.Text, "", tbDanhGia.Text, "", "", "", "", "", cbLBD.Text);
                         MessageBox.Show("Sửa Thành Công", "Thông Báo");
                         reset();
                         Enable();
                         cbLBD.Enabled = true;
                         ResetValue();
                    }
               }
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               table1 = connector.LoadData("OutPutTable", "1", "");
               cbMaCB.DataSource = table1;
               cbMaCB.DisplayMember = "Ma_CB";
               cbMaCB.ValueMember = "Ma_CB";
               if (cbLBD.Text != "")
               {
                    Disable();
                    cbLBD.Enabled = false;
                    check = 1;
               }
               else
               {
                    MessageBox.Show("Chọn Thông Tin Bạn Cần Sửa", "Thông Báo");
               }
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (cbLBD.Text != "")
               {
                    connector.DeleteObject("7", cbLBD.Text, "");
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    reset();
                    ResetValue();
                    Enable();
               }
               else
               {
                    MessageBox.Show("Chọn Thông Tin Bạn Cần Xóa", "Thông Báo");
               }
          }

          private void tbTimKiem_KeyDown(object sender, KeyEventArgs e)
          {
               table = new DataTable();
               table = connector.FindObject("7", tbTimKiem.Text);
               dataGridView1.DataSource = table;
          }
     }
}
