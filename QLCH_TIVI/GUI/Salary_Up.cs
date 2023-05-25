using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Salary_Up : Form
    {
        string staff_code = string.Empty;

        int old_salary = 0;
        public Salary_Up(string scode, int osl)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            staff_code = scode;
            old_salary = osl;
        }

        private void Salary_Up_Load(object sender, EventArgs e)
        {
            nSalary.Value = old_salary;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAction_Click(object sender, EventArgs e)
        {
            if (nSalary.Value < old_salary)
            {
                if (MessageBox.Show("Xác nhận giảm lương!, Nhấn \"Yes\" để tiếp tục", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Staff_BLL().SalaryUp(staff_code, int.Parse(nSalary.Value.ToString()));
                    Close();
                }

            } else
            {
                new Staff_BLL().SalaryUp(staff_code, int.Parse(nSalary.Value.ToString()));
                Close();
            }
        }
    }
}
