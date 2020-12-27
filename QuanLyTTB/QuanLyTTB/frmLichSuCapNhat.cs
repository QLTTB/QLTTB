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
     
     public partial class frmLichSuCapNhat : Form
     {
          public frmLichSuCapNhat()
          {
               InitializeComponent();
          }
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          private int check;
          public string temp;
          public void reset()
          {
               table = new DataTable();
               table = connector.LoadData("OutPutTable", "8", "");
               dataGridView2.DataSource = table;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
          }
          public void Disable()
          {
               btnThem.Enabled = false;
               btnSua.Enabled =  false;
               btnXoa.Enabled =  false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
          }
          public void ResetValue()
          {
               tbMaLSCN.ResetText();
               tbLoaiCN.ResetText();
               tbND.ResetText();
               cbMaCB.ResetText();
               cbTenCB.ResetText();            
          }
          private void frmLichSuCapNhat_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }
          

          private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               tbMaLSCN.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
               tbLoaiCN.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
               tbND.Text     = dataGridView2.CurrentRow.Cells[2].Value.ToString();
               cbTenCB.Text   = dataGridView2.CurrentRow.Cells[4].Value.ToString();
               cbMaCB.Text  = dataGridView2.CurrentRow.Cells[3].Value.ToString();             
               string a = dataGridView2.CurrentRow.Cells[0].Value.ToString();
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTableByID", "14", a);
               dataGridView1.DataSource = table1;
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               Disable();
               ResetValue();
               check = 0;
               tbMaLSCN.Enabled = false;
               cbMaCB.DataSource = connector.LoadData("OutPutTable","1","");
               cbMaCB.DisplayMember = "Ma_CB";
               cbMaCB.ValueMember = "Ma_CB";             
          }

          private void btnHuy_Click(object sender, EventArgs e)
          {
               Enable();
               ResetValue();
               tbMaLSCN.Enabled = true;
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if ( tbLoaiCN.Text == "" || tbND.Text == "" || cbMaCB.Text == "" || cbTenCB.Text == "")
               {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông Báo");
               }
               else
               {
                    if (check == 0)
                    {
                         connector.InsertUpdateObject("AddObject", "8", cbMaCB.Text, "", "1/1/1990", "1/1/1900", "", tbLoaiCN.Text, tbND.Text, "", "", "", "", "");
                         MessageBox.Show("Thêm Thành Công", "Thông Báo");
                         reset();
                         Enable();
                         ResetValue();
                    }
                    if (check == 1)
                    {
                         connector.InsertUpdateObject("EditObject", "8", cbMaCB.Text, "", "1/1/1990", "1/1/1900", "", tbLoaiCN.Text, tbND.Text, "", "", "", "", tbMaLSCN.Text);
                         MessageBox.Show("Sửa Thành Công", "Thông Báo");
                         reset();
                         Enable();
                         ResetValue();
                    }
               }
          }

          private void cbMaCB_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    cbTenCB.DataSource = connector.LoadData("OutPutTableByID", "1", cbMaCB.Text);
                    cbTenCB.DisplayMember = "Ten_CB";
                    cbTenCB.ValueMember = "Ten_CB";
               }
               catch
               {

               }
          }

          private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {
               temp = dataGridView2.CurrentRow.Cells[0].Value.ToString();
               frmThongTinCapNhat frmTTCN = new frmThongTinCapNhat(temp);              
               frmTTCN.ShowDialog();
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               if (tbMaLSCN.Text != "")
               {
                    Disable();
                    check = 1;
                    tbMaLSCN.Enabled = false;
                    cbMaCB.DataSource = connector.LoadData("OutPutTable", "1", "");
                    cbMaCB.DisplayMember = "Ma_CB";
                    cbMaCB.ValueMember = "Ma_CB";
               }
               else
               {
                    MessageBox.Show("Chọn Thông Tin Bạn Cần Sửa", "Thông Báo");
               }
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (tbMaLSCN.Text != "")
               {
                    connector.DeleteObject("8", tbMaLSCN.Text, "");
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

               table1 = new DataTable();
               table1 = connector.FindObject("8", tbTimKiem.Text);
               dataGridView2.DataSource = table1;
          }
     }
}
