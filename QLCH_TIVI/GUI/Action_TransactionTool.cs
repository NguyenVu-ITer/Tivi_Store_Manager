using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Action_TransactionTool : Form
    {
        /* DECLARE VARIABLES */
        Staff staff = null;
        Product product = null;
        Customer customer = null;
        Bill bill_act = null;
        DataTable pro_table = null;
        DataTable cus_table = null;

        string type_act = string.Empty;

        bool ck_bcode = false;
        bool ck_dbcode = false;
        bool ck_cuscode = false;

        /* FORM CONSTRUCTOR */
        public Action_TransactionTool(string staff_code)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Get_Staff(staff_code);
        }
        public Action_TransactionTool(Customer cus, string type = "update_cus")
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            customer = cus;
        }
        public Action_TransactionTool(string staff_code, string pro_code)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Get_Staff(staff_code);
            Get_Product(pro_code);
        }
        public Action_TransactionTool(Bill bill, string type = "update_bill")
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            bill_act = bill;
            Get_Staff(bill_act.Bill_staffcode);
            Get_Product(bill_act.Bill_procode);
            Get_Customer(bill_act.Bill_customercode);
        }

        /* GET OBJECT */
        private void Get_Staff(string code)
        {
            DataTable dt = new Staff_BLL().Get_Staff(code);
            staff = new Staff(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString(),
                dt.Rows[0][3].ToString(),
                dt.Rows[0][4].ToString(),
                int.Parse(dt.Rows[0][5].ToString()),
                int.Parse(dt.Rows[0][7].ToString())
                );
        }
        private void Get_Product(string code)
        {
            DataTable dt = new Product_BLL().Get_Product("MA_TV = N'"+ code +"'");
            product = new Product(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString(),
                int.Parse(dt.Rows[0][3].ToString()),
                dt.Rows[0][4].ToString(),
                dt.Rows[0][5].ToString(),
                float.Parse(dt.Rows[0][6].ToString()),
                dt.Rows[0][7].ToString(),
                int.Parse(dt.Rows[0][8].ToString()),
                dt.Rows[0][9].ToString(),
                dt.Rows[0][10].ToString(),
                int.Parse(dt.Rows[0][11].ToString())
                );
        }
        private void Get_Customer(string code)
        {
            DataTable dt = new Customer_BLL().Get_Customer("MA_KH = N'" + code + "'");
            customer = new Customer(
                    dt.Rows[0][0].ToString(),
                    dt.Rows[0][1].ToString(),
                    dt.Rows[0][2].ToString(),
                    dt.Rows[0][3].ToString(),
                    dt.Rows[0][4].ToString()
                );
        }
        private Bill Get_Bill_From_Form()
        {
            return new Bill(
                    tDBCode.Text.Trim(),
                    tBCode.Text.Trim(),
                    DateTime.Now.ToString().Trim(),
                    staff.Staff_code.Trim(),
                    tCusCode.Text.Trim(),
                    cbDBProCode.Text.Trim(),
                    int.Parse(nDBAmount.Value.ToString().Trim()),
                    int.Parse(tDBTotalPrice.Text.Trim().Substring(0, tDBTotalPrice.Text.Trim().Length - 4))
                );
        }

        private void Loader()
        {
            switch (type_act)
            {
                case "update_bill":
                    Load_Update_Bill();
                    break;
                case "update_cus":
                    Load_Update_Customer();
                    break;
                default:
                    Load_Add_Bill();
                    break;
            }
            
        }

        /* FORM ENVENT */
        private void Action_TransactionTool_Load(object sender, EventArgs e)
        {
            Loader();
        }
        private void nDBAmount_ValueChanged(object sender, EventArgs e)
        {

            if (product != null)
            {
                tDBTotalPrice.Text = "" + (product.Pro_price * nDBAmount.Value) + " vnd";
            }
            else
            {
                DataTable dt = new Product_BLL().Get_Product("MA_TV = N'" + cbDBProCode.Text.Trim() + "'");
                int pro_price = int.Parse(dt.Rows[0][8].ToString().Trim());
                tDBTotalPrice.Text = "" + (pro_price * nDBAmount.Value) + " vnd";
            }
        }
        private void bBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bAction_Click(object sender, EventArgs e)
        {
            switch (type_act)
            {
                case "update_bill":
                    Handle_Update_Bill();
                    break;
                case "update_cus":
                    Handle_Update_Customer();
                    break;
                default:
                    // MessageBox.Show("ck_bcode: " + ck_bcode + "\nck_dbcode: " + ck_dbcode + "\nck_cuscode: " + ck_cuscode);
                    if (ck_bcode && ck_dbcode && ck_cuscode) Handle_Add_Bill();
                    else MessageBox.Show("Kiểm tra các mã đã nhập trước!");
                    break;
            }


            
        }

        /* LOAD FORM */
        private void Load_Add_Bill()
        {
            lbTitle.Text = "LẬP HÓA ĐƠN";

            rCusNew.Checked = true;
            cbCusName.Visible = false;

            tBCode.Text = "BL" + new Random().Next(1000, 9999);
            tDBCode.Text = "BD" + new Random().Next(1001, 9999);
            tCusCode.Text = "CS" + new Random().Next(1000, 9999);

            if (product != null) Load_ProField_True();
            else Load_ProField_False();

            tDBTotalPrice.Enabled = false;

            if (rCusNew.Checked) Load_Cus_New();
            else Load_Cus_Old();
        }
        private void Load_Update_Bill()
        {
            lbTitle.Text = "CẬP NHẬT HÓA ĐƠN";

            rCusOld.Checked = true;

            tBCode.Text = bill_act.Bill_code;
            tDBCode.Text = bill_act.Bill_detailcode;
            tCusCode.Text = bill_act.Bill_customercode;

            tBCode.Enabled = false;
            tDBCode.Enabled = false;
            tCusCode.Enabled = false;

            bCheck_BCode.Enabled = false;
            bCheck_DBCode.Enabled = false;
            bCheck_CusCode.Enabled = false;

            ck_bcode = true;
            ck_dbcode = true;
            ck_cuscode = true;

            Load_ProField();
            tDBTotalPrice.Enabled = false;            
            Load_CusField();
        }
        private void Load_Update_Customer()
        {
            lbTitle.Text = "CẬP NHẬT THÔNG TIN KHÁCH KHÁCH HÀNG";

            rCusOld.Checked = true;

            grBill.Enabled = false;
            grDBill.Enabled = false;
            tCusCode.Enabled = false;

            rCusNew.Enabled = false;

            bCheck_CusCode.Enabled = false;

            ck_bcode = true;
            ck_dbcode = true;
            ck_cuscode = true;

            tCusPhone.Enabled = true;
            tCusEmail.Enabled = true;
            tCusAdress.Enabled = true;

            Load_CusField();
        }
        private void Load_ProField_True()
        {
            cbDBProCode.Enabled = false;
            tDBProName.Enabled = false;

            cbDBProCode.Text = product.Pro_code;
            tDBProName.Text = product.Pro_name;
            nDBAmount.Value = 1;
            tDBTotalPrice.Text = "" + (product.Pro_price * nDBAmount.Value) + " vnd";
        }
        private void Load_ProField_False()
        {
            cbDBProCode.Enabled = true;
            tDBProName.Enabled = true;
            pro_table = new Product_BLL().GetList_Product();
            for (int i = 0; i < pro_table.Rows.Count; i++)
            {
                cbDBProCode.Items.Add(pro_table.Rows[i][0].ToString().Trim());
            }
            cbDBProCode.Text = cbDBProCode.Items[0].ToString();
            tDBProName.Text = pro_table.Rows[0][1].ToString().Trim();
            nDBAmount.Value = 0;
            tDBTotalPrice.Text = "0 vnd";
        }
        private void Load_ProField()
        {
            Load_ProField_True();
            nDBAmount.Value = bill_act.Bill_amount;
            tDBTotalPrice.Text = bill_act.Bill_totalprice + " vnd";
        }
        private void cbDBProCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox _this = (ComboBox)sender;

            for (int i = 0; i < pro_table.Rows.Count; i++)
            {
                if (pro_table.Rows[i][0].ToString().Trim() == _this.Text.Trim())
                {
                    tDBProName.Text = pro_table.Rows[i][1].ToString().Trim();
                    tDBTotalPrice.Text = "" + (int.Parse(pro_table.Rows[i][8].ToString().Trim()) * nDBAmount.Value) + " vnd";
                    break;
                }
            }

        }
        private void Load_Cus_New()
        {
            cus_table = null;
            cbCusName.Items.Clear();

            tCusName.Visible = true;
            cbCusName.Visible = false;

            tCusCode.Enabled = true;
            tCusPhone.Enabled = true;
            tCusEmail.Enabled = true;
            tCusAdress.Enabled = true;

            ck_cuscode = false;
            bCheck_CusCode.Enabled = true;

            tCusCode.Text = "CS" + new Random().Next(1000, 9999);
            tCusPhone.Text = string.Empty;
            tCusEmail.Text = string.Empty;
            tCusAdress.Text = string.Empty;

        }
        private void Load_Cus_Old()
        {
            cus_table = null;
            cbCusName.Items.Clear();

            tCusName.Visible = false;
            cbCusName.Visible = true;
            cbCusName.Location = tCusName.Location;

            tCusCode.Enabled = false;
            tCusPhone.Enabled = false;
            tCusEmail.Enabled = false;
            tCusAdress.Enabled = false;

            ck_cuscode = true;
            bCheck_CusCode.Enabled = false;

            cus_table = new Customer_BLL().GetList_Customer();
            for (int i = 0; i < cus_table.Rows.Count;i++)
            {
                cbCusName.Items.Add(cus_table.Rows[i][1].ToString());
            }

            cbCusName.Text = cbCusName.Items[0].ToString();
            tCusCode.Text = cus_table.Rows[0][0].ToString();
            tCusPhone.Text = cus_table.Rows[0][2].ToString();
            tCusEmail.Text = cus_table.Rows[0][3].ToString();
            tCusAdress.Text = cus_table.Rows[0][4].ToString();

        }
        private void Load_CusField()
        {
            if (type_act == "update_bill")
                grCustomer.Enabled = false;

            tCusCode.Text = customer.Cus_code;
            cbCusName.Text = customer.Cus_name;
            tCusPhone.Text = customer.Cus_phone;
            tCusEmail.Text = customer.Cus_email;
            tCusAdress.Text = customer.Cus_address;

        }
        private void rCusNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rCusNew.Checked)
            {
                Load_Cus_New();
            }
            else
            {
                Load_Cus_Old();
            }
        }
        private void cbCusName_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox _this = (ComboBox)sender;

            for (int i = 0; i < cus_table.Rows.Count; i++)
            {
                if (cus_table.Rows[i][1].ToString().Trim() == _this.Text.Trim())
                {
                    tCusCode.Text = cus_table.Rows[i][0].ToString();
                    tCusPhone.Text = cus_table.Rows[i][2].ToString();
                    tCusEmail.Text = cus_table.Rows[i][3].ToString();
                    tCusAdress.Text = cus_table.Rows[i][4].ToString();
                }
            }
        }

        /* HANDLE ADD */
        private void Handle_Add_Bill()
        {
            if (rCusNew.Checked)
            {
                new Customer_BLL().Insert_Customer(new Customer(
                        tCusCode.Text.Trim(),
                        tCusName.Text.Trim(),
                        tCusPhone.Text.Trim(),
                        tCusEmail.Text.Trim(),
                        tCusAdress.Text.Trim()
                    ));
            }

            Bill bill = Get_Bill_From_Form();
            new Bill_BLL().Insert_Bill(bill);
            new Product_BLL().Update_Inventory(bill.Bill_procode, bill.Bill_amount);

            Close();
        }
        private void Handle_Update_Bill()
        {
            Bill bill = Get_Bill_From_Form();
            new Bill_BLL().Update_Bill(bill);
            new Product_BLL().Update_Inventory(bill.Bill_procode, bill.Bill_amount);

            Close();
        }
        private void Handle_Update_Customer()
        {
            new Customer_BLL().Update_Customer(new Customer(
                        tCusCode.Text.Trim(),
                        tCusName.Text.Trim(),
                        tCusPhone.Text.Trim(),
                        tCusEmail.Text.Trim(),
                        tCusAdress.Text.Trim()
                    ));
            Close();
        }

        /* HANDLE CHECK */
        private void bCheck_BCode_Click(object sender, EventArgs e)
        {
            if (new Bill_BLL().Check_Exists_Bill("MA_HD", tBCode.Text.Trim()))
            {
                ck_bcode = false; bCheck_BCode.Enabled = true;
                if (MessageBox.Show(tBCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tBCode.Text = "BL" + new Random().Next(1000, 9999);
                }
            } else { ck_bcode = true; bCheck_BCode.Enabled = false; }
        }
        private void bCheck_DBCode_Click(object sender, EventArgs e)
        {
            if (new Bill_BLL().Check_Exists_Bill("MA_CTHD", tDBCode.Text.Trim()))
            {
                ck_dbcode = false; bCheck_DBCode.Enabled = true;
                if (MessageBox.Show(tDBCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tDBCode.Text = "DB" + new Random().Next(1000, 9999);
                }
            } else { ck_dbcode = true; bCheck_DBCode.Enabled = false; }
        }
        private void bCheck_CusCode_Click(object sender, EventArgs e)
        {
            if (new Customer_BLL().Check_Exists_Customer(tCusCode.Text.Trim()))
            {
                ck_cuscode = false; bCheck_CusCode.Enabled = true;
                if (MessageBox.Show(tCusCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tCusCode.Text = "CS" + new Random().Next(1000, 9999);
                }
            } else { ck_cuscode = true; bCheck_CusCode.Enabled = false; }
        }
    }
}
