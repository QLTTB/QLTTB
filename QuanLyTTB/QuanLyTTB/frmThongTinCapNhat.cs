using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyTTB
{
     public partial class frmThongTinCapNhat : Form
     {
          public frmThongTinCapNhat(string temp)
          {
               temp1 = temp;
               InitializeComponent();
          }
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          public string temp1;
          public int check;
          private string str = ConfigurationManager.ConnectionStrings["Conn"].ToString();
          private void frmThongTinCapNhat_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }
          public void reset()
          {
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTableByID", "14", temp1);
               dataGridView1.DataSource = table1;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
               cbMaTTB.Enabled = true;
          }
          public void Disable()
          {
               btnThem.Enabled = false;
               btnSua.Enabled = false;
               btnXoa.Enabled = false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
          }
          public void ResetValue()
          {
               cbMaTTB.ResetText();
               tbGhiChu.ResetText();
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               Disable();
               ResetValue();
               check = 0;
               cbMaTTB.DataSource = connector.LoadData("OutPutTable", "14", "");
               cbMaTTB.DisplayMember = "Ma_VTTTB";
               cbMaTTB.ValueMember = "Ma_VTTTB";
          }

          private void btnHuy_Click(object sender, EventArgs e)
          {
               Enable();
               ResetValue();
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if (cbMaTTB.Text == "")
               {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông Báo");
               }
               else 
               {
                    if (check == 0)
                    {
                         string sql = "Select * from LS_VTTTB where Ma_VTTTB = '" + cbMaTTB.Text.Trim() + "' and Ma_LSCN = '" + temp1 + "'";
                         SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
                         connection.Open();
                         SqlCommand command = new SqlCommand(sql, connection);
                         command.CommandType = CommandType.Text;
                         SqlDataReader dataReader = command.ExecuteReader();
                         command.Dispose();

                         if (dataReader.Read() == true)
                         {
                              MessageBox.Show("Đã Tồn Tại");
                              dataReader.Close();
                              connection.Close();
                         }
                         else
                         {
                              dataReader.Close();
                              connection.Close();
                              connector.InsertUpdateObject("AddObject", "11", temp1, cbMaTTB.Text, "1/1/1990", "1/1/1900", "", tbGhiChu.Text, "", "", "", "", "", "");
                              MessageBox.Show("Thêm Thành Công", "Thông Báo");
                              reset();
                              Enable();
                              ResetValue();
                         }
                    }
               }
               if (check == 1)
               {                   
                         connector.InsertUpdateObject("EditObject", "11", cbMaTTB.Text, "", "1/1/1990", "1/1/1900", "", tbGhiChu.Text, "", "", "", "", cbMaTTB.Text, temp1);
                         MessageBox.Show("Sửa Thành Công", "Thông Báo");
                         reset();
                         Enable();
                         ResetValue();
                    
               }
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               if(cbMaTTB.Text != "")
               {
                    check = 1;
                    Disable();
                    cbMaTTB.Enabled = false;
               }
               else
               {
                    MessageBox.Show("Chọn Thông Tin Bạn Cần Sửa", "Thông Báo");
               }
          }

          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               cbMaTTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               tbGhiChu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (cbMaTTB.Text != "")
               {
                    connector.DeleteObject("11", temp1, cbMaTTB.Text);
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
               table1 = connector.FindObject("11", tbTimKiem.Text);
               dataGridView1.DataSource = table1;
          }
     }
}
