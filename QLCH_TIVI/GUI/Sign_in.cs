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
using DTO;

namespace GUI
{
    public partial class Sign_in : Form
    {

        Account acc = new Account();
        Account_BLL acc_BLL = new Account_BLL();

        public Sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bSignin_Click(object sender, EventArgs e)
        {
            if (tUName.Text == string.Empty || tUPass.Text == string.Empty)
            {
                // MessageBox.Show("Tên đăng nhập hoặc mật khẩu đang rỗng!");
            } else
            {
                acc = acc_BLL.CheckLogic(tUName.Text, tUPass.Text);

                if (acc != null)
                {
                    new Main_manager(acc).Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hãy thử lại!");
                }
            }

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lbForgetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng lấy lại mật khẩu đang bảo trì!", "Hệ thống thông báo");
        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {
            string author = "\tKHOA CÔNG NGHỆ THÔNG TIN\t\n\n" +
                            "\tNGUYỄN TUẤN VŨ - DTH206069\n" +
                            "\t          CHI ĐOÀN DH21TH2";

            MessageBox.Show(author, "7V_52 | Author");
        }
    }
}
