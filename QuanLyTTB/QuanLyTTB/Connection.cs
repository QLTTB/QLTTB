using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyTTB
{
     class Connection
     {
          private string str = ConfigurationManager.ConnectionStrings["Conn"].ToString();
          private SqlConnection con;
          private SqlDataAdapter da;
          private DataTable table;
          private SqlCommand com;

          public Connection()
          {
               con = new SqlConnection(str);
          }
          public Connection(string STR)
          {
               str = STR;
               con = new SqlConnection(str);
          }
          public void CloseConnect()
          {
               con.Close();
               con.Dispose();
          }
          public bool TryConnect()
          {
               bool check = false;
               try
               {
                    con = new SqlConnection(str);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                         check = true;
                    }
                    else
                    {
                         throw new Exception("Connection crashed!");
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               return check;
          }

          public DataTable LoadData(string path,string core,string id)
          {
               if (TryConnect())
               {
                    com = new SqlCommand(path, con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@core", core);
                    com.Parameters.AddWithValue("@id", id);
                    da = new SqlDataAdapter(com);
                    table = new DataTable();
                    da.Fill(table);
               }
               CloseConnect();
               return table;
          }

          public bool InsertUpdateObject(string path, string core, string pr1, string pr2, string pr3, string pr4, string pr5, string pr6,string pr7,string pr8,string pr9, string pr10,string pr11,string pr12)
          {
               try 
               { 
               bool check = false;
               if (TryConnect())
               {
                    com = new SqlCommand(path, con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@core", core);
                    com.Parameters.AddWithValue("@pr1", pr1);
                    com.Parameters.AddWithValue("@pr2", pr2);
                    com.Parameters.AddWithValue("@pr3", Convert.ToDateTime(pr3));
                    if(pr4!= "")
                    com.Parameters.AddWithValue("@pr4", Convert.ToDateTime(pr4));
                    else com.Parameters.AddWithValue("@pr4", pr4);
                    com.Parameters.AddWithValue("@pr5", pr5);
                    com.Parameters.AddWithValue("@pr6", pr6);
                    com.Parameters.AddWithValue("@pr7", pr7);
                    com.Parameters.AddWithValue("@pr8", pr8);
                    com.Parameters.AddWithValue("@pr9", pr9);
                    com.Parameters.AddWithValue("@pr10", pr10);
                    com.Parameters.AddWithValue("@pr11", pr11);
                    com.Parameters.AddWithValue("@pr12", pr12);
                    com.ExecuteNonQuery();
                    check = true;
               }
               CloseConnect();
               return check;
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "ERROR");
                    return false;
               }
          }

          public bool DeleteObject(string core, string pr1, string pr2)
          {
               bool check = false;
               if (TryConnect())
               {
                    com = new SqlCommand("DeleteObject", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@core", core);
                    com.Parameters.AddWithValue("@pr1", pr1);
                    com.Parameters.AddWithValue("@pr2", pr2);
                    com.ExecuteNonQuery();
                    check = true;
               }
               CloseConnect();
               return check;
          }

          public DataTable FindObject(string core, string pr1)
          {
               if (TryConnect())
               {
                    com = new SqlCommand("FindObject", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@core", core);
                    com.Parameters.AddWithValue("@pr1", pr1);
                    da = new SqlDataAdapter(com);
                    table = new DataTable();
                    da.Fill(table);
               }
               CloseConnect();
               return table;
          }         
     }
}

