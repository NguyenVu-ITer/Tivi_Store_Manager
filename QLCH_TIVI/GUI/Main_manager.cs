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
using DTO;

namespace GUI
{
    public partial class Main_manager : Form
    {
        Account account;
        public Main_manager(Account acc)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            account = acc;

            Text = account.User_name + " Controlling";
        }
        private void Main_manager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công với tài khoản " + account.Acc_code);
        }

        private void Main_manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
