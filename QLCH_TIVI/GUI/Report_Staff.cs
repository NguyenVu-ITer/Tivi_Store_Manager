using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Report_Staff : Form
    {
        public Report_Staff()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Report_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCH_TIVIDataSet.CHUC_VU' table. You can move, or remove it, as needed.
            this.cHUC_VUTableAdapter.Fill(this.qLCH_TIVIDataSet.CHUC_VU);
            // TODO: This line of code loads data into the 'qLCH_TIVIDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.qLCH_TIVIDataSet.STAFF);

            this.reportStaff.RefreshReport();
        }
    }
}
