using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Action_AdminTool : Form 
    {
        /* DECLARE VARIABLES */
        string type_act = null;
        string object_act = null;
        Staff staff_act = null;
        Position pos_act = null;
        Account acc_act = null;
        DataTable pos_tb = null;
        DataTable staff_tb = null;
        DataTable acc_tb = null;

        /* FORM CONSTRUCTOR */
        public Action_AdminTool(string type, string obj)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
        }
        public Action_AdminTool(string type, string obj, Staff staff)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
            staff_act = staff;
        }
        public Action_AdminTool(string type, string obj, Position pos)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
            pos_act = pos;
        }
        public Action_AdminTool(string type, string obj, Account acc)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
            acc_act = acc;
        }

        private void Loader()
        {
            pos_tb = object_act == "staff" ? new Position_BLL().GetList_Position() : null;

            staff_tb = object_act == "acc" ? new Staff_BLL().GetList_Staff() : null;

            acc_tb = object_act == "acc" ? new Account_BLL().GetList_Account() : null;

            switch (type_act)
            {
                case "add":
                    switch (object_act)
                    {
                        case "staff":
                            // Load_Position();
                            LoadForm_Add_Staff();
                            break;
                        case "pos":
                            LoadForm_Add_Position();
                            break;
                        case "acc":
                            Load_Staff();
                            LoadForm_Add_Account();
                            break;
                    }
                    break;

                case "update":
                    switch (object_act)
                    {
                        case "staff":
                            Load_Position();
                            LoadForm_Update_Staff(staff_act);
                            break;
                        case "pos":
                            LoadForm_Update_Position(pos_act);
                            break;
                        case "acc":
                            // Load_Staff();
                            LoadForm_Update_Account(acc_act);
                            break;
                    }
                    break;
            }
        }

        /* FORM ENVENT */
        private void Action_Load(object sender, EventArgs e)
        {
            Loader();
        }
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bAction_Click(object sender, EventArgs e)
        {
            switch (type_act)
            {
                case "add":
                    switch (object_act)
                    {
                        case "staff":
                            Handle_Add_Staff();
                            break;
                        case "pos":
                            Handle_Add_Position();
                            break;
                        case "acc":
                            Handle_Add_Account();
                            break;
                    }
                    break;

                case "update":
                    switch (object_act)
                    {
                        case "staff":
                            Handle_Update_Staff();
                            break;
                        case "pos":
                            Handle_Update_Position();
                            break;
                        case "acc":
                            Handle_Update_Account();
                            break;
                    }
                    break;
            }
        }

        /* LOAD FORM */
        private void Load_Staff()
        {
            for (int i = 0; i < staff_tb.Rows.Count; i++)
            {
                bool is_next = false;
                if (staff_tb.Rows[i][7].ToString() == "1") is_next = true;

                for (int j = 0; j < acc_tb.Rows.Count; j++)
                {
                    if (staff_tb.Rows[i][0].ToString() == acc_tb.Rows[j][3].ToString())
                    {
                        is_next = true;
                        break;
                    }
                }

                if (is_next) continue;

                cbAStaff.Items.Add(staff_tb.Rows[i][1].ToString());
            }
        }
        private void Load_Position()
        {
            for (int i = 0; i < pos_tb.Rows.Count; i++)
            {
                if (pos_tb.Rows[i][2].ToString() == "1") continue;
                cbSPosition.Items.Add(pos_tb.Rows[i][1].ToString());
            }
        }
        private void LoadForm_Add_Staff()
        {
            lbTitle.Text = "THÊM NHÂN VIÊN";
            panel_Staff.Visible = true;
            panel_Acc.Visible = false;
            panel_Pos.Visible = false;

            tSCode.Text = "ST" + new Random().Next(1000, 9999);
            cbSPosition.Text = "Nhân viên";
            cbSPosition.Enabled = false;
        }
        private void LoadForm_Update_Staff(Staff st)
        {
            lbTitle.Text = "CẬP NHẬT NHÂN VIÊN";
            panel_Staff.Visible = true;
            panel_Acc.Visible = false;
            panel_Pos.Visible = false;

            tSCode.Enabled = false;
            tSCode.Text = st.Staff_code;
            tSName.Text = st.Staff_name;
            tSPhone.Text = st.Staff_phone;
            tSEmail.Text = st.Staff_email;

            for (int i = 0; i < pos_tb.Rows.Count; i++)
            {
                if (pos_tb.Rows[i][0].ToString().Trim() == st.Staff_poscode)
                    cbSPosition.Text = pos_tb.Rows[i][1].ToString();
            }
        }
        private void LoadForm_Add_Position()
        {
            lbTitle.Text = "THÊM CHỨC VỤ";
            panel_Staff.Visible = false;
            panel_Acc.Visible = false;
            panel_Pos.Visible = true;
            panel_Pos.Location = panel_Staff.Location;

            tPCode.Text = "PO" + tPLevel.Value + "00" + tPLevel.Value;
        }
        private void LoadForm_Update_Position(Position pos)
        {
            lbTitle.Text = "CẬP NHẬT CHỨC VỤ";
            panel_Staff.Visible = false;
            panel_Acc.Visible = false;
            panel_Pos.Visible = true;
            panel_Pos.Location = panel_Staff.Location;

            tPCode.Enabled = false;
            tPCode.Text = pos.Pos_code;
            tPName.Text = pos.Pos_name;
            tPLevel.Value = pos.Pos_level;
            tPScfc.Text = pos.Pos_scfc.ToString();
        }
        private void LoadForm_Add_Account()
        {
            lbTitle.Text = "THÊM TÀI KHOẢN";
            panel_Staff.Visible = false;
            panel_Pos.Visible = false;
            panel_Acc.Visible = true;

            panel_Acc.Location = panel_Staff.Location;

            tACode.Text = "AC" + new Random().Next(1000, 9999);
            cbAStaff.Text = cbAStaff.Items[0].ToString();
        }
        private void LoadForm_Update_Account(Account acc)
        {
            lbTitle.Text = "CHỈNH SỬA TÀI KHOẢN";
            panel_Staff.Visible = false;
            panel_Pos.Visible = false;
            panel_Acc.Visible = true;
            panel_Acc.Location = panel_Staff.Location;

            tACode.Enabled = false;
            cbAStaff.Enabled = false;

            tACode.Text = acc.Acc_code;
            tAUname.Text = acc.User_name;
            tAPass.Text = acc.Password;
            cbAStaff.Text = acc.Staff_code;

        }
        private void tPLevel_ValueChanged(object sender, EventArgs e)
        {
            if (type_act == "add")
            {
                if (tPLevel.Value < 10)
                    tPCode.Text = "AC" + tPLevel.Value + "00" + tPLevel.Value;
                if (tPLevel.Value >= 10)
                    tPCode.Text = "AC" + (int)tPLevel.Value / 10 + "0" + tPLevel.Value;
            }
        }

        /* HANDLE CHECK */
        private bool Check_Email(string email)
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase).IsMatch(email);
        }
        private bool Check_Empty_Form()
        {
            switch (object_act)
            {
                case "staff":
                    if (tSCode.Text.Trim() == String.Empty || tSName.Text.Trim() == String.Empty ||
                        tSPhone.Text.Trim() == String.Empty || tSEmail.Text.Trim() == String.Empty ||
                        cbSPosition.Text.Trim() == String.Empty)
                        return true;
                    break;
                case "pos":
                    if (tPCode.Text.Trim() == String.Empty || tPName.Text.Trim() == String.Empty || tPLevel.Text.Trim() == String.Empty)
                        return true;
                    break;
                case "acc":
                    if (tACode.Text.Trim() == String.Empty || tAUname.Text.Trim() == String.Empty ||
                        tAPass.Text.Trim() == String.Empty || cbAStaff.Text.Trim() == String.Empty)
                        return true;
                    break;
            }
            return false;
        }

        /* HANDLE ADD */
        private void Handle_Add_Staff()
        {
            if (!Check_Empty_Form())
            {
                if (new Staff_BLL().Check_Exists_Staff(tSCode.Text.Trim()))
                {
                    if (MessageBox.Show(tSCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tSCode.Text = "ST" + new Random().Next(1000, 9999);
                    }
                }
                else
                {
                    if (Check_Email(tSEmail.Text.Trim()))
                    {
                        string pos_code = null;
                        for (int i = 0; i < pos_tb.Rows.Count; i++)
                        {
                            if (pos_tb.Rows[i][1].ToString().Trim() == cbSPosition.Text.Trim())
                                pos_code = pos_tb.Rows[i][0].ToString();
                        }

                        new Staff_BLL().Insert_Staff(new Staff(
                            tSCode.Text.Trim(),
                            tSName.Text.Trim(),
                            tSPhone.Text.Trim(),
                            tSEmail.Text.Trim()
                        ));
                        
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("\"" + tSEmail.Text.Trim() + "\" không phải là một địa chỉ mail.");
                        tSEmail.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }        
        private void Handle_Add_Position()
        {
            if (!Check_Empty_Form())
            {
                if (new Position_BLL().Check_Exists_Position(tPCode.Text.Trim()))
                {
                    if (MessageBox.Show(tPCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tPCode.Text = "PO" + new Random().Next(1000, 9999);
                    }
                }
                else
                {
                    new Position_BLL().Insert_Position(new Position(
                        tPCode.Text.Trim(),
                        tPName.Text.Trim(),
                        (int)tPLevel.Value,
                        int.Parse(tPScfc.Text.Trim())
                    ));

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
        private void Handle_Add_Account()
        {
            if (!Check_Empty_Form())
            {
                if (new Account_BLL().Check_Exists_Account(tACode.Text.Trim()))
                {
                    if (MessageBox.Show(tACode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tACode.Text = "AC" + new Random().Next(1000, 9999);
                    }
                }
                else
                {
                    string scode = string.Empty;
                    int slevel = -1;

                    for (int i = 0; i < staff_tb.Rows.Count; i++)
                    {
                        if (staff_tb.Rows[i][1].ToString().Trim() == cbAStaff.Text.Trim())
                        {
                            scode = staff_tb.Rows[i][0].ToString().Trim();
                            slevel = int.Parse(staff_tb.Rows[i][7].ToString().Trim());
                            break;
                        };
                    }

                    new Account_BLL().Insert_Account(new Account(
                        tACode.Text.Trim(),
                        tAUname.Text.Trim(),
                        tAPass.Text.Trim(),
                        scode,
                        slevel
                    ));

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }

        /* HANDLE UPDATE */
        private void Handle_Update_Staff()
        {
            if (!Check_Empty_Form())
            {
                if (Check_Email(tSEmail.Text.Trim()))
                {
                    string pos_code = null;
                    for (int i = 0; i < pos_tb.Rows.Count; i++)
                    {
                        if (pos_tb.Rows[i][1].ToString().Trim() == cbSPosition.Text.Trim())
                            pos_code = pos_tb.Rows[i][0].ToString().Trim();
                    }

                    Staff tmp = new Staff(
                            tSCode.Text.Trim(),
                            tSName.Text.Trim(),
                            tSPhone.Text.Trim(),
                            tSEmail.Text.Trim(),
                            pos_code);

                    new Staff_BLL().Update_Staff(tmp);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("\"" + tSEmail.Text.Trim() + "\" không phải là một địa chỉ mail.");
                    tSEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
        private void Handle_Update_Position()
        {
            if (!Check_Empty_Form())
            {
                new Position_BLL().Update_Position(new Position(
                    tPCode.Text.Trim(),
                    tPName.Text.Trim(),
                    (int)tPLevel.Value,
                    int.Parse(tPScfc.Text.Trim())
                ));

                this.Close();
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
        private void Handle_Update_Account()
        {
            if (!Check_Empty_Form())
            {
                new Account_BLL().Update_Account(new Account(
                    tACode.Text.Trim(),
                    tAUname.Text.Trim(),
                    tAPass.Text.Trim(),
                    cbAStaff.Text.Trim()
                ));

                Close();
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }

    }
}
