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
     public partial class frmLichBaoDuong : Form
     {
          public frmLichBaoDuong()
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
               table = connector.LoadData("OutPutTable", "4", "");
               dataGridView1.DataSource = table;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
               tbMaCB.Enabled = true;
               tbNgay.Enabled = true;
               tbCongViec.Enabled = true;
               tbKip.Enabled = true;
          }
          public void Disable()
          {
               btnThem.Enabled = false;
               btnSua.Enabled = false;
               btnXoa.Enabled = false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
               tbMaCB.Enabled = false;
               tbNgay.Enabled = false;
               tbCongViec.Enabled = false;
               tbKip.Enabled = false;
          }
          public void ResetValue()
          {
               tbMaLBD.ResetText();
               tbDonVi.ResetText();
               tbMaLLV.ResetText();
               tbMaCB.ResetText();
               tbCongViec.ResetText();
               tbNgay.ResetText();
               tbKip.ResetText();
          }
          private void frmLichBaoDuong_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }
         
          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               tbMaLBD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               tbDonVi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               tbMaLLV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               tbMaCB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               tbNgay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               tbCongViec.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               tbKip.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();             
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               Disable();
               ResetValue();
               check = 0;
               tbMaLBD.Enabled = false;
          }

          private void btnHuy_Click(object sender, EventArgs e)
          {
               Enable();
               ResetValue();
               tbMaLBD.Enabled = true;
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if (tbDonVi.Text == ""|| tbMaLLV.Text == "")
               {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông Báo");
               }
               else
               {
                    if (check == 0)
                    {

                         connector.InsertUpdateObject("AddObject", "4", tbMaLLV.Text, "", "1/1/1990", "1/1/1900", "", tbDonVi.Text, "", "", "", "", "", "");
                         MessageBox.Show("Thêm Thành Công", "Thông Báo");
                         Enable();
                         tbMaLBD.Enabled = true;
                         ResetValue();
                         reset();
                    }
                    if (check == 1)
                    {
                         connector.InsertUpdateObject("EditObject", "4", tbMaLLV.Text, "", "1/1/1990", "1/1/1900", "", tbDonVi.Text, "", "", "", "", "", tbMaLBD.Text);
                         MessageBox.Show("Sửa Thành Công", "Thông Báo");
                         reset();
                         Enable();
                         tbMaLBD.Enabled = true;
                         ResetValue();
                    }
               }
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               if (tbMaLBD.Text != "")
               {
                    Disable();
                    tbMaLBD.Enabled = false;
                    check = 1;
               }
               else
               {
                    MessageBox.Show("Chọn Thông Tin Bạn Cần Sửa", "Thông Báo");
               }
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (tbMaLBD.Text != "")
               {
                    connector.DeleteObject("4",tbMaLBD.Text,"");
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
               table =  connector.FindObject("4", tbTimKiem.Text);
               dataGridView1.DataSource = table;
          }
     }
}
