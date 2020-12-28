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
     public partial class frmThongKeVTTTB : Form
     {
          public frmThongKeVTTTB()
          {
               InitializeComponent();
          }
          private Connection connector = new Connection();
          private void frmThongKeVTTTB_Load(object sender, EventArgs e)
          {
               DataTable1BindingSource.DataSource = connector.LoadData("OutPutTable", "14", "");
               this.reportViewer1.LocalReport.Refresh();
               this.reportViewer1.RefreshReport();
          }
    }
}
