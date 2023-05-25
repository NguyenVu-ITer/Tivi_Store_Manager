namespace GUI
{
    partial class Report_Customer
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
            this.qLCH_TIVIDataSet = new GUI.QLCH_TIVIDataSet();
            this.kHACHHANGCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACH_HANG_CHI_TIETTableAdapter = new GUI.QLCH_TIVIDataSetTableAdapters.KHACH_HANG_CHI_TIETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH_TIVIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGCHITIETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_CUS";
            reportDataSource1.Value = this.kHACHHANGCHITIETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_Customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLCH_TIVIDataSet
            // 
            this.qLCH_TIVIDataSet.DataSetName = "QLCH_TIVIDataSet";
            this.qLCH_TIVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGCHITIETBindingSource
            // 
            this.kHACHHANGCHITIETBindingSource.DataMember = "KHACH_HANG_CHI_TIET";
            this.kHACHHANGCHITIETBindingSource.DataSource = this.qLCH_TIVIDataSet;
            // 
            // kHACH_HANG_CHI_TIETTableAdapter
            // 
            this.kHACH_HANG_CHI_TIETTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 741);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Customer";
            this.Text = "Report_Customer";
            this.Load += new System.EventHandler(this.Report_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLCH_TIVIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGCHITIETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLCH_TIVIDataSet qLCH_TIVIDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGCHITIETBindingSource;
        private QLCH_TIVIDataSetTableAdapters.KHACH_HANG_CHI_TIETTableAdapter kHACH_HANG_CHI_TIETTableAdapter;
    }
}