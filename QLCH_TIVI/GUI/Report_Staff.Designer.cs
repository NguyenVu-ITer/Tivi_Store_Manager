namespace GUI
{
    partial class Report_Staff
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Staff));
            this.reportStaff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCH_TIVIDataSet = new GUI.QLCH_TIVIDataSet();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new GUI.QLCH_TIVIDataSetTableAdapters.STAFFTableAdapter();
            this.cHUC_VUTableAdapter = new GUI.QLCH_TIVIDataSetTableAdapters.CHUC_VUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH_TIVIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportStaff
            // 
            this.reportStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_STAFF";
            reportDataSource1.Value = this.sTAFFBindingSource;
            reportDataSource2.Name = "DS_POS";
            reportDataSource2.Value = this.cHUCVUBindingSource;
            this.reportStaff.LocalReport.DataSources.Add(reportDataSource1);
            this.reportStaff.LocalReport.DataSources.Add(reportDataSource2);
            this.reportStaff.LocalReport.ReportEmbeddedResource = "GUI.Report_Staff.rdlc";
            this.reportStaff.Location = new System.Drawing.Point(0, 0);
            this.reportStaff.Name = "reportStaff";
            this.reportStaff.ServerReport.BearerToken = null;
            this.reportStaff.Size = new System.Drawing.Size(1249, 741);
            this.reportStaff.TabIndex = 0;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.qLCH_TIVIDataSet;
            // 
            // qLCH_TIVIDataSet
            // 
            this.qLCH_TIVIDataSet.DataSetName = "QLCH_TIVIDataSet";
            this.qLCH_TIVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUC_VU";
            this.cHUCVUBindingSource.DataSource = this.qLCH_TIVIDataSet;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // cHUC_VUTableAdapter
            // 
            this.cHUC_VUTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 741);
            this.Controls.Add(this.reportStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Staff";
            this.Text = "BÁO CÁO THỐNG KÊ BẢNG LƯƠNG CỦA NHÂN VIÊN CỬA HÀNG";
            this.Load += new System.EventHandler(this.Report_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH_TIVIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportStaff;
        private QLCH_TIVIDataSet qLCH_TIVIDataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private QLCH_TIVIDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private QLCH_TIVIDataSetTableAdapters.CHUC_VUTableAdapter cHUC_VUTableAdapter;
    }
}