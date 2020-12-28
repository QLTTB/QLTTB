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
     public partial class frmDanhMucVTTTB : Form
     {
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          private int check;
          string a;
          public frmDanhMucVTTTB()
          {
               InitializeComponent();
          }
          
          private void frmDanhMucVTTTB_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }
          public void reset()
          {
               table = new DataTable();
               table = connector.LoadData("OutPutTable", "14", "");
               dataGridView1.DataSource = table;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
          }         

          private void btnHuy_Click(object sender, EventArgs e)
          {
               ResetValue();
               Enable();
               tbMaTTB.Enabled = true;
               tbNgayXuat.Enabled = true;
          }
          public void ResetValue()
          {
               tbMaTTB.ResetText();
               tbTenTTB.ResetText();
               tbLoai.ResetText();
               tbTT.ResetText();
               tbNgayNhap.ResetText();
               tbNgayXuat.ResetText();
               tbTrangThai.ResetText();
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               ResetValue();
               tbMaTTB.Enabled = false;
               btnThem.Enabled = false;
               btnSua.Enabled =  false;
               btnXoa.Enabled =  false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
               tbNgayXuat.Enabled = false;
               check = 0;
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               if (tbMaTTB.Text != "")
               {
                    tbMaTTB.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    check = 1;
                    a = tbTT.Text; 
               }
               else
               {
                    MessageBox.Show("Chọn Thiết Bị Bạn Cần Sửa", "Thông Báo");
               }
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if ( tbTenTTB.Text == "" || tbLoai.Text == "" || tbTrangThai.Text == "" || tbNgayNhap.Text == "" ||tbTT.Text =="")
               {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông Báo");
               }
               else
               {
                    if (tbNgayXuat.Text == "") tbNgayXuat.Text = null;
                    if (check == 0)
                    {
                         string a;
                         connector.InsertUpdateObject("AddObject", "14", "", "", tbNgayNhap.Text, tbNgayXuat.Text, "", tbTenTTB.Text, tbLoai.Text, tbTrangThai.Text, "", "", "", "");
                         string sql = "Select * from VTTTB  where NgayNhap = '" + Convert.ToDateTime(tbNgayNhap.Text) + "' and Ten_VTTTB ='"+tbTenTTB.Text +"'and Loai='" +tbLoai.Text+"'";
                         SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
                         connection.Open();
                         SqlCommand command = new SqlCommand(sql, connection);
                         command.CommandType = CommandType.Text;
                         SqlDataReader dataReader = command.ExecuteReader();
                         if (dataReader.Read() == true)
                         {
                              a = dataReader["Ma_VTTTB"].ToString();
                              command.Dispose();
                              connector.InsertUpdateObject("AddObject", "10", a, "", tbNgayNhap.Text, "", "", tbTT.Text, "", "", "", "", "", "1");
                              MessageBox.Show("Thêm Thành Công", "Thông Báo");
                         }
                         command.Dispose();
                         reset();
                         ResetValue();
                         Enable();
                         tbMaTTB.Enabled = true;
                         tbNgayXuat.Enabled = true;
                    }
                    if (check == 1)
                    {
                         if (a == tbTT.Text)
                         {
                              connector.InsertUpdateObject("EditObject", "14", "", "", tbNgayNhap.Text, tbNgayXuat.Text, "", tbTenTTB.Text, tbLoai.Text, tbTrangThai.Text, "", "", "", tbMaTTB.Text);
                              MessageBox.Show("Sửa Thành Công", "Thông Báo");
                              reset();
                              ResetValue();
                              Enable();
                              tbMaTTB.Enabled = true;
                         }
                         else
                         {
                              connector.InsertUpdateObject("EditObject", "14", "", "", tbNgayNhap.Text, tbNgayXuat.Text, "", tbTenTTB.Text, tbLoai.Text, tbTrangThai.Text, "", "", "", tbMaTTB.Text);
                              string sql = "Update LICHSUTINHTRANG SET TG_KT ='" + DateTime.Now+"',KT = 0 where Ma_VTTTB = '" + tbMaTTB.Text.Trim() + "' and KT ='1'";
                              SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
                              connection.Open();
                              SqlCommand command = new SqlCommand(sql, connection);
                              command.CommandType = CommandType.Text;
                              command.ExecuteNonQuery();
                              connection.Close();
                              connector.InsertUpdateObject("AddObject", "10", tbMaTTB.Text, "", DateTime.Now.ToString(), "", "", tbTT.Text, "", "", "", "", "", "1");
                              MessageBox.Show("Sửa Thành Công", "Thông Báo");
                              reset();
                              ResetValue();
                              Enable();
                              tbMaTTB.Enabled = true;
                         }
                    }
               }

          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (tbMaTTB.Text != "")
               {
                    connector.DeleteObject("14",tbMaTTB.Text,"");
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    reset();
                    ResetValue();
                    Enable();

               }
               else
               {
                    MessageBox.Show("Chọn Thiết Bị Bạn Cần Xóa", "Thông Báo");
               }
          }

          private void tbTimKiem_KeyDown(object sender, KeyEventArgs e)
          {
                     
                    table1 = new DataTable();
                    table1 = connector.FindObject("14", tbTimKiem.Text);
                    dataGridView1.DataSource = table1;
               
          }

          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTable", "10", a);
               dataGridView2.DataSource = table1;
               
               tbMaTTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               tbTenTTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               tbLoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               tbNgayNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               tbNgayXuat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               tbTrangThai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               string sql = "Select * from LICHSUTINHTRANG where Ma_VTTTB = '" + tbMaTTB.Text.Trim() + "' and KT = 1 ";
               SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
               connection.Open();
               SqlCommand command = new SqlCommand(sql, connection);
               command.CommandType = CommandType.Text;
               SqlDataReader dataReader = command.ExecuteReader();
               if (dataReader.Read() == true)
               {
                    tbTT.Text = dataReader["TinhTrang"].ToString();
               }
               command.Dispose();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               frmThongKeVTTTB frmThongKe = new frmThongKeVTTTB();
               frmThongKe.ShowDialog();
          }
     }
}
