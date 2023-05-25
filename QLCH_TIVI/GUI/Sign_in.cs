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
        public Sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            tUName.Text = Properties.Settings.Default.username;
            tUPass.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.username != string.Empty)
            {
                ckSaveInfo.Checked = true;
            }
        }
        private void bSignin_Click(object sender, EventArgs e)
        {
            if (tUName.Text.Trim() == string.Empty || tUPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được rỗng!");
            } else
            {
                Account acc = new Account_BLL().CheckLogin(tUName.Text, tUPass.Text);
                if (acc != null)
                {
                    // Lưu thông tin đăng nhập cho lần tiếp theo
                    if (ckSaveInfo.Checked)
                    {
                        string uname = tUName.Text.Trim();
                        string upass = tUPass.Text.Trim();

                        Properties.Settings.Default.username = uname;
                        Properties.Settings.Default.password = upass;
                        Properties.Settings.Default.Save();
                    } else
                    {
                        Properties.Settings.Default.Reset();
                    }

                    // Đăng nhập hệ thống
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
            => Application.ExitThread();
        private void lbForgetPass_Click(object sender, EventArgs e)
            => MessageBox.Show("Chức năng lấy lại mật khẩu đang bảo trì!", "Hệ thống thông báo");
        private void lbAuthor_Click(object sender, EventArgs e)
        {
            string author = "\tKHOA CÔNG NGHỆ THÔNG TIN\t\n\n" +
                            "\tNGUYỄN TUẤN VŨ - DTH206069\n" +
                            "\t          CHI ĐOÀN DH21TH2";

            MessageBox.Show(author, "7V_52 | Author");
        }

    }
}
