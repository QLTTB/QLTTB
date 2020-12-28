namespace QuanLyTTB
{
     partial class frmThongKeVTTTB
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
               this.components = new System.ComponentModel.Container();
               Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
               this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
               this.DataSetBaoCao = new QuanLyTTB.DataSetBaoCao();
               this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCao)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // reportViewer1
               // 
               reportDataSource1.Name = "DataSet1";
               reportDataSource1.Value = this.DataTable1BindingSource;
               this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
               this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTTB.Report1.rdlc";
               this.reportViewer1.Location = new System.Drawing.Point(-5, 0);
               this.reportViewer1.Name = "reportViewer1";
               this.reportViewer1.Size = new System.Drawing.Size(652, 563);
               this.reportViewer1.TabIndex = 0;
               // 
               // DataSetBaoCao
               // 
               this.DataSetBaoCao.DataSetName = "DataSetBaoCao";
               this.DataSetBaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // DataTable1BindingSource
               // 
               this.DataTable1BindingSource.DataMember = "DataTable1";
               this.DataTable1BindingSource.DataSource = this.DataSetBaoCao;
               // 
               // frmThongKeVTTTB
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(645, 561);
               this.Controls.Add(this.reportViewer1);
               this.Name = "frmThongKeVTTTB";
               this.Text = "frmThongKeVTTTB";
               this.Load += new System.EventHandler(this.frmThongKeVTTTB_Load);
               ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCao)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetBaoCao DataSetBaoCao;
    }
}