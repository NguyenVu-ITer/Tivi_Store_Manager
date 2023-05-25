using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class Report_Customer : Form
    {
        string staff_name = string.Empty;
        public Report_Customer(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            staff_name = name;
        }

        private void Report_Customer_Load(object sender, EventArgs e)
        {
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("Staff_Name", staff_name));
            reportViewer1.LocalReport.SetParameters(parameters);

            // TODO: This line of code loads data into the 'qLCH_TIVIDataSet.KHACH_HANG_CHI_TIET' table. You can move, or remove it, as needed.
            this.kHACH_HANG_CHI_TIETTableAdapter.Fill(this.qLCH_TIVIDataSet.KHACH_HANG_CHI_TIET);

            this.reportViewer1.RefreshReport();
        }
    }
}
