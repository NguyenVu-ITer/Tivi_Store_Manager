using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main_manager : Form
    {
        string placeHolder_textbox = "Nhập mã cần tìm tại đây...";
        Account account;

        public Main_manager(Account acc)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            account = acc;
            Text = account.User_name + " đang kiểm soát";
        }
        private void Load_or_Refresh_Form()
        {
            tabControl_Store.Location = new Point(bulkhead.Location.X + 12, bulkhead.Location.Y);

            switch (account.Position)
            {
                case 1:
                    AdminTool_GetTabControl();
                    break;
                default:
                    lbAdminTool.Visible = false;
                    StoreTool_GetTabControl();
                    break;
            }

            Reset_SearchInput(placeHolder_textbox, Color.DarkGray);

        }


        /* FORM ENVENT */
        private void Main_manager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công! " + account.User_name);
            Load_or_Refresh_Form();
        }
        private void Main_manager_FormClosing(object sender, FormClosingEventArgs e) => Application.ExitThread();
        private void lbAdminTool_Click(object sender, EventArgs e) => AdminTool_GetTabControl();
        private void lbStoreTool_Click(object sender, EventArgs e) => StoreTool_GetTabControl();
        private void lbTransactionTool_Click(object sender, EventArgs e) => TransactionTool_GetTabControl();
        private void bSignout_Click(object sender, EventArgs e) => Application.Restart();
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset_SearchInput(placeHolder_textbox, Color.DarkGray);
        }


        /* SEARCH FUNCTIONS & EVENTS */
        private void tSearch_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == placeHolder_textbox)
            {
                Reset_SearchInput(string.Empty, Color.Black);
            }
        }
        private void tSearch_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == string.Empty)
            {
                Reset_SearchInput(placeHolder_textbox, Color.DarkGray);
            }
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "bSearch" && tSearch_Staff.Text.Trim() != string.Empty)
            { Search("Nhân viên", dgStaff, tSearch_Staff); }
            else if (btn.Name == "bSearch_Position" && tSearch_Position.Text.Trim() != string.Empty)
            { Search("Chức vụ", dgPositon, tSearch_Position); }
            else if (btn.Name == "bSearch_Account" && tSearch_Account.Text.Trim() != string.Empty)
            { Search("Tài khoản", dgAccount, tSearch_Account); }
            else if (btn.Name == "bSearch_Product" && tSearch_Product.Text.Trim() != string.Empty)
            { Search("Sản phẩm", dgProduct, tSearch_Product); }
            else if (btn.Name == "bSearch_Supplier" && tSearch_Supplier.Text.Trim() != string.Empty)
            { Search("Nhà cung cấp", dgSupplier, tSearch_Supplier); }
            else if (btn.Name == "bSearch_Bill" && tSearch_Bill.Text.Trim() != string.Empty)
            { Search("Hóa đơn", dgBill, tSearch_Bill); }
            else if (btn.Name == "bSearch_Cus" && tSearch_Cus.Text.Trim() != string.Empty)
            { Search("Khách hàng", dgCustomer, tSearch_Cus); }
            else { MessageBox.Show("Không có giá trị để tìm!"); }
        }
        private void Reset_SearchInput(string str, Color color)
        {
            tSearch_Staff.Text = tSearch_Position.Text = tSearch_Account.Text = str;
            tSearch_Product.Text = tSearch_Supplier.Text = tSearch_Bill.Text = tSearch_Cus.Text = str;

            tSearch_Staff.ForeColor = tSearch_Position.ForeColor = tSearch_Account.ForeColor = color;
            tSearch_Product.ForeColor = tSearch_Supplier.ForeColor = tSearch_Bill.ForeColor = tSearch_Cus.ForeColor = color;
        }
        private void Search(string text_show, DataGridView table, TextBox textbox)
        {
            if (textbox.Text != placeHolder_textbox)
            {
                DataGridView dataGridView = table;
                string show_obj = text_show;
                int count_result = 0;

                string code = textbox.Text.Trim();
                dataGridView.ClearSelection();
                for (int i = 0; i < dataGridView.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        string field = dataGridView.Rows[i].Cells[j].Value?.ToString().Trim();
                        if (field != null && field.ToLower().IndexOf(code.ToLower()) >= 0)
                        {
                            dataGridView.Rows[i].Selected = true;
                            count_result++;
                        }
                    }                    
                }

                if (count_result == 0) MessageBox.Show("Không tìm thấy " + show_obj + " nào có thông tin là: " + textbox.Text.Trim());
            }
            else
            {
                MessageBox.Show("Nhập mã cần tìm vào ô tìm kiếm trước!");
            }
        }


        /* ADMIN TOOL LOAD FORM PAGE ################################################################### */
        private void AdminTool_GetTabControl()
        {
            tabControl_Admin.Visible = true;
            tabControl_Store.Visible = false;
            tabControl_Business.Visible = false;
            tabControl_Admin.Location = tabControl_Store.Location;
            lbAdminTool.ForeColor = Color.FromArgb(200, 0, 0);
            lbStoreTool.ForeColor = ColorTranslator.FromHtml("#000");
            lbTransactionTool.ForeColor = ColorTranslator.FromHtml("#000");

            lbAdminTool.BackColor = Color.Gainsboro;
            lbStoreTool.BackColor = Color.White;
            lbTransactionTool.BackColor = Color.White;

            Load_Staff();
            Load_Postiotion();
            Load_Account();
        }
        private void Load_Staff()
        {
            DataTable staff_tb = new Staff_BLL().GetList_Staff();
            dgStaff.DataSource = staff_tb;
            Load_Card_Staff(0);
        }
        private void Load_Card_Staff(int row_index)
        {
            lbSName.Text = dgStaff.Rows[row_index].Cells[1].Value.ToString();
            lbSPhone.Text = dgStaff.Rows[row_index].Cells[2].Value.ToString();
            lbSEmail.Text = dgStaff.Rows[row_index].Cells[3].Value.ToString();
            lbSPos.Text = dgStaff.Rows[row_index].Cells[5].Value.ToString();

            if (lbSName.Text != string.Empty)
                bSalaryUp_Staff.Visible = true;
            else
                bSalaryUp_Staff.Visible = false;
        }
        private void Load_Postiotion()
        {
            DataTable pos_tb = new Position_BLL().GetList_Position();
            dgPositon.DataSource = pos_tb;
            Load_Card_Postiotion(0);
        }
        private void Load_Card_Postiotion(int row_index)
        {
            lbPCode.Text = dgPositon.Rows[row_index].Cells[0].Value.ToString();
            lbPName.Text = dgPositon.Rows[row_index].Cells[1].Value.ToString();
            lbPLevel.Text = dgPositon.Rows[row_index].Cells[2].Value.ToString();
        }
        private void Load_Account()
        {
            DataTable acc_tb = new Account_BLL().GetList_Account();
            dgAccount.DataSource = acc_tb;
            Load_Card_Account(0);
        }
        private void Load_Card_Account(int row_index)
        {
            lbACode.Text = dgAccount.Rows[row_index].Cells[0].Value.ToString();
            lbAUname.Text = dgAccount.Rows[row_index].Cells[1].Value.ToString();
            lbAStaff.Text = dgAccount.Rows[row_index].Cells[3].Value.ToString();
        }

        /* HANDLE ACTION OF ADMIN TOOL FOR STAFF PAGE */
        private void dgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgStaff.Rows[e.RowIndex].Cells[0].Value.ToString());
            Load_Card_Staff(e.RowIndex > -1 ? e.RowIndex : 0);
        }
        private void bAdd_Staff_Click(object sender, EventArgs e)
        {
            new Action_AdminTool("add", "staff").ShowDialog();
            Load_Staff();
        }
        private void bDel_Staff_Click(object sender, EventArgs e)
        {
            if (dgStaff.SelectedRows.Count > 0)
            {
                string scode = dgStaff.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string sname = dgStaff.SelectedRows[0].Cells[1].Value.ToString().Trim();

                if (MessageBox.Show("Muốn xóa " + sname + " thiệt hả?", "Admin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Staff_BLL().Delete_Staff(scode);
                    Load_Staff();
                }
            }
        }
        private void bEdit_Staff_Click(object sender, EventArgs e)
        {
            if (dgStaff.SelectedRows.Count > 0)
            {
                string scode = dgStaff.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string sname = dgStaff.SelectedRows[0].Cells[1].Value.ToString().Trim();
                string sphone = dgStaff.SelectedRows[0].Cells[2].Value.ToString().Trim();
                string semail = dgStaff.SelectedRows[0].Cells[3].Value.ToString().Trim();
                string spos = dgStaff.SelectedRows[0].Cells[4].Value.ToString().Trim();

                Staff staff_tmp = new Staff(scode, sname, sphone, semail, spos);

                new Action_AdminTool("update", "staff", staff_tmp).ShowDialog();

                Load_Staff();
            }

        }
        private void bSalaryUp_Staff_Click(object sender, EventArgs e)
        {
            if (dgStaff.SelectedCells.Count > 0)
            {
                string scode = dgStaff.Rows[dgStaff.SelectedCells[0].RowIndex].Cells[0].Value.ToString().Trim();
                int salary = int.Parse(dgStaff.Rows[dgStaff.SelectedCells[0].RowIndex].Cells[5].Value.ToString().Trim());
                new Salary_Up(scode, salary).ShowDialog();
                Load_Staff();
            }
        }
        private void bStatistic_Staff_Click(object sender, EventArgs e)
        {
            new Report_Staff().ShowDialog();
        }

        /* HANDLE ACTION OF ADMIN TOOL FOR POSITION PAGE */
        private void dgPositon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Card_Postiotion(e.RowIndex > -1 ? e.RowIndex : 0);
        }
        private void bAdd_Pos_Click(object sender, EventArgs e)
        {
            new Action_AdminTool("add", "pos").ShowDialog();
            Load_Postiotion();
        } 
        private void bDel_Pos_Click(object sender, EventArgs e)
        {
            if (dgPositon.SelectedRows.Count > 0)
            {
                string pcode = dgPositon.SelectedRows[0].Cells[0].Value.ToString().Trim();

                if (MessageBox.Show("Muốn xóa " + pcode + " thiệt hả?", "Admin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Position_BLL().Delete_Position(pcode);
                    Load_Postiotion();
                }
            }
        }
        private void bEdit_Pos_Click(object sender, EventArgs e)
        {
            if (dgPositon.SelectedRows.Count > 0)
            {
                string pcode = dgPositon.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string pname = dgPositon.SelectedRows[0].Cells[1].Value.ToString().Trim();
                int plevel = int.Parse(dgPositon.SelectedRows[0].Cells[2].Value.ToString().Trim());
                float scfc = float.Parse(dgPositon.SelectedRows[0].Cells[3].Value.ToString().Trim());

                Position pos_tmp = new Position(pcode, pname, plevel, scfc);

                new Action_AdminTool("update", "pos", pos_tmp).ShowDialog();

                Load_Postiotion();
            }

        }

        /* HANDLE ACTION OF ADMIN TOOL FOR ACCOUNT PAGE */
        private void dgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Card_Account(e.RowIndex > -1 ? e.RowIndex : 0);
        }
        private void bAdd_Acc_Click(object sender, EventArgs e)
        {
            new Action_AdminTool("add", "acc").ShowDialog();
            Load_Account();
        }
        private void bDel_Acc_Click(object sender, EventArgs e)
        {
            if (dgAccount.SelectedRows.Count > 0)
            {
                string acode = dgAccount.SelectedRows[0].Cells[0].Value.ToString().Trim();

                if (MessageBox.Show("Muốn xóa " + acode + " thiệt hả?", "Admin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Account_BLL().Delete_Account(acode);
                    Load_Account();
                }
            }

        }
        private void bEdit_Acc_Click(object sender, EventArgs e)
        {
            if (dgAccount.SelectedRows.Count > 0)
            {
                string acode = dgAccount.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string auname = dgAccount.SelectedRows[0].Cells[1].Value.ToString().Trim();
                string apass = dgAccount.SelectedRows[0].Cells[2].Value.ToString().Trim();
                string ascode = dgAccount.SelectedRows[0].Cells[3].Value.ToString().Trim();

                Account acc_tmp = new Account(acode, auname, apass, ascode);

                new Action_AdminTool("update", "acc", acc_tmp).ShowDialog();

                Load_Account();
            }
        }


        /* STORE TOOL LOAD FORM PAGE ################################################################### */
        private void StoreTool_GetTabControl()
        {
            tabControl_Admin.Visible = false;
            tabControl_Store.Visible = true;
            tabControl_Business.Visible = false;
            lbAdminTool.ForeColor = ColorTranslator.FromHtml("#000");
            lbStoreTool.ForeColor = Color.FromArgb(200, 0, 0);
            lbTransactionTool.ForeColor = ColorTranslator.FromHtml("#000");

            lbAdminTool.BackColor = Color.White;
            lbStoreTool.BackColor = Color.Gainsboro;
            lbTransactionTool.BackColor = Color.White;

            Load_Product();
            Load_Supplier();
        }
        private void Load_Product()
        {
            DataTable product_tb = new Product_BLL().GetList_Product();
            dgProduct.DataSource = product_tb;
            Load_Card_Product(0);
        }
        private void Load_Card_Product(int row_index)
        {
            lbProCode.Text = dgProduct.Rows[row_index].Cells[0].Value.ToString().Trim();
            lbProName.Text = dgProduct.Rows[row_index].Cells[1].Value.ToString().Trim();
            lbProType.Text = dgProduct.Rows[row_index].Cells[2].Value.ToString().Trim();
            lbProDebut.Text = dgProduct.Rows[row_index].Cells[3].Value.ToString().Trim();
            lbProGuar.Text = dgProduct.Rows[row_index].Cells[4].Value.ToString().Trim();
            lbProDisplay.Text = dgProduct.Rows[row_index].Cells[7].Value.ToString().Trim();
            lbProPrice.Text = dgProduct.Rows[row_index].Cells[8].Value.ToString().Trim();
            lbProRemain.Text = dgProduct.Rows[row_index].Cells[11].Value.ToString().Trim();
        }
        private void Load_Supplier()
        {
            DataTable supplier_tb = new Supplier_BLL().GetList_Supplier();
            dgSupplier.DataSource = supplier_tb;
            Load_Card_Supplier(0);
        }
        private void Load_Card_Supplier(int row_index)
        {
            lbSupCode.Text = dgSupplier.Rows[row_index].Cells[0].Value.ToString();
            lbSupName.Text = dgSupplier.Rows[row_index].Cells[1].Value.ToString();
            lbSupPhone.Text = dgSupplier.Rows[row_index].Cells[2].Value.ToString();
            lbSupAdress.Text = dgSupplier.Rows[row_index].Cells[3].Value.ToString();
        }

        /* HANDLE ACTION OF STORE TOOL FOR PRODUCT PAGE */
        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
            => Load_Card_Product(e.RowIndex > -1 ? e.RowIndex : 0);
        private void bAdd_Product_Click(object sender, EventArgs e)
        {
            new Action_StoreTool("add", "product").ShowDialog();
            Load_Product();
        }
        private void bEdit_Product_Click(object sender, EventArgs e)
        {
            if (dgProduct.SelectedCells.Count > 0)
            {
                int index = dgProduct.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgProduct.Rows[index];

                if (index < dgSupplier.Rows.Count - 1)
                {
                    string pro_code = row.Cells[0].Value.ToString().Trim();
                    string pro_name = row.Cells[1].Value.ToString().Trim();
                    string pro_type = row.Cells[2].Value.ToString().Trim();
                    int pro_yearDebut = int.Parse(row.Cells[3].Value.ToString().Trim());
                    string pro_guarantee = row.Cells[4].Value.ToString().Trim();
                    string pro_size = row.Cells[5].Value.ToString().Trim();
                    float pro_weight = float.Parse(row.Cells[6].Value.ToString().Trim());
                    string pro_display = row.Cells[7].Value.ToString().Trim();
                    int pro_price = int.Parse(row.Cells[8].Value.ToString().Trim());
                    string pro_origin = row.Cells[9].Value.ToString().Trim();
                    string pro_suppcode = row.Cells[10].Value.ToString().Trim();
                    int pro_inventory = int.Parse(row.Cells[11].Value.ToString().Trim());

                    Product pro_tmp = new Product(
                        pro_code, pro_name, pro_type, pro_yearDebut,
                        pro_guarantee, pro_size, pro_weight, pro_display,
                        pro_price, pro_origin, pro_suppcode, pro_inventory
                    );

                    new Action_StoreTool("update", "product", pro_tmp).ShowDialog();
                    Load_Staff();
                }
            }

        }
        private void bPay_Product_Click(object sender, EventArgs e)
        {
            if (dgProduct.SelectedCells.Count > 0)
            {
                int index = dgProduct.SelectedCells[0].RowIndex;
                string pro_code = dgProduct.Rows[index].Cells[0].Value.ToString().Trim();
                new Action_TransactionTool(account.Staff_code, pro_code).ShowDialog();
            }
        }

        /* HANDLE ACTION OF STORE TOOL FOR SUPPLIER PAGE */
        private void dgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Card_Supplier(e.RowIndex > -1 ? e.RowIndex : 0);
        }
        private void bAdd_Supplier_Click(object sender, EventArgs e)
        {
            new Action_StoreTool("add", "supplier").ShowDialog();
            Load_Supplier();
        }
        private void bEdit_Supplier_Click(object sender, EventArgs e)
        {
            if (dgSupplier.SelectedCells.Count > 0)
            {
                int index = dgSupplier.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgSupplier.Rows[index];

                if (index < dgSupplier.Rows.Count - 1)
                {
                    string sup_code = row.Cells[0].Value.ToString().Trim();
                    string sup_name = row.Cells[1].Value.ToString().Trim();
                    string sup_phone = row.Cells[2].Value.ToString().Trim();
                    string sup_adress = row.Cells[3].Value.ToString().Trim();

                    Supplier sup_tmp = new Supplier(sup_code, sup_name, sup_phone, sup_adress);

                    new Action_StoreTool("update", "supplier", sup_tmp).ShowDialog();
                    Load_Supplier();
                }
            }
        }
        private void bDel_Supplier_Click(object sender, EventArgs e)
        {

        }


        /* TRANSACTION TOOL LOAD FORM PAGE ############################################################# */
        private void TransactionTool_GetTabControl()
        {

            tabControl_Admin.Visible = false;
            tabControl_Store.Visible = false;
            tabControl_Business.Visible = true;
            tabControl_Business.Location = tabControl_Store.Location;
            lbAdminTool.ForeColor = ColorTranslator.FromHtml("#000");
            lbStoreTool.ForeColor = ColorTranslator.FromHtml("#000");
            lbTransactionTool.ForeColor = Color.FromArgb(200, 0, 0);

            lbAdminTool.BackColor = Color.White;
            lbStoreTool.BackColor = Color.White;
            lbTransactionTool.BackColor = Color.Gainsboro;

            Load_Bill(); 
            Load_Customer();
        }
        private void Load_Bill()
        {
            dgBill.DataSource = new Bill_BLL().GetList_Bill();
            Load_Card_Bill(0);
        }
        private void Load_Card_Bill(int row_index)
        {
            if (dgBill.Rows[row_index].Cells[0].Value.ToString().Trim() != "")
            {
                string pro_code = dgBill.Rows[row_index].Cells[2].Value.ToString().Trim();
                string pro_name = new Product_BLL().Get_Product("MA_TV = N'" + pro_code + "'").Rows[0][1].ToString();

                string staff_code = dgBill.Rows[row_index].Cells[6].Value.ToString().Trim();
                string staff_name = new Staff_BLL().Get_Staff(staff_code).Rows[0][1].ToString();

                string cus_code = dgBill.Rows[row_index].Cells[7].Value.ToString().Trim();
                string cus_name = new Customer_BLL().Get_Customer("MA_KH = N'" + cus_code + "'").Rows[0][1].ToString();

                lbBCode.Text = dgBill.Rows[row_index].Cells[1].Value.ToString().Trim();
                lbBProduct.Text = pro_name;
                lbBAmount.Text = dgBill.Rows[row_index].Cells[3].Value.ToString().Trim();
                lbBDate.Text = dgBill.Rows[row_index].Cells[5].Value.ToString().Trim();
                lbBStaff.Text = staff_name;
                lbBCustomer.Text = cus_name;
                lbBTotalPrice.Text = dgBill.Rows[row_index].Cells[4].Value.ToString().Trim();
            }
        }
        private void Load_Customer()
        {
            dgCustomer.DataSource = new Customer_BLL().GetList_Customer();
            Load_Card_Customer(0);
        }
        private void Load_Card_Customer(int row_index)
        {
            if (dgCustomer.Rows[row_index].Cells[0].Value.ToString().Trim() != "")
            {
                lbCusCode.Text = dgCustomer.Rows[row_index].Cells[0].Value.ToString().Trim();
                lbCusName.Text = dgCustomer.Rows[row_index].Cells[1].Value.ToString().Trim();
                lbCusPhone.Text = dgCustomer.Rows[row_index].Cells[2].Value.ToString().Trim();
                lbCusEmail.Text = dgCustomer.Rows[row_index].Cells[3].Value.ToString().Trim();
                lbCusAdress.Text = dgCustomer.Rows[row_index].Cells[4].Value.ToString().Trim();
            }
        }

        /* HANDLE ACTION OF TRANSACTION TOOL FOR BILL PAGE */
        private void dgBill_CellClick(object sender, DataGridViewCellEventArgs e)
            => Load_Card_Bill(e.RowIndex > -1 ? e.RowIndex : 0);
        private void bAdd_Bill_Click(object sender, EventArgs e)
        {
            new Action_TransactionTool(account.Staff_code).ShowDialog();
            Load_Bill();
        }
        private void bStatistic_Bill_Click(object sender, EventArgs e)
        {
            string staff_name = new Staff_BLL().Get_Staff(account.Staff_code).Rows[0][1].ToString().Trim();
            new Report_Bill(staff_name).ShowDialog();
        }
        private void bEdit_Bill_Click(object sender, EventArgs e)
        {
            if (dgBill.SelectedCells.Count > 0)
            {
                int index = dgBill.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgBill.Rows[index];

                if (index < dgBill.Rows.Count - 1)
                {
                    string bill_detailcode = row.Cells[0].Value.ToString().Trim();
                    string bill_code = row.Cells[1].Value.ToString().Trim();
                    string bill_procode = row.Cells[2].Value.ToString().Trim();
                    int bill_amount = int.Parse(row.Cells[3].Value.ToString().Trim());
                    int bill_totalprice = int.Parse(row.Cells[4].Value.ToString().Trim());
                    string bill_datefounded = row.Cells[5].Value.ToString().Trim();
                    string bill_staffcode = row.Cells[6].Value.ToString().Trim();
                    string bill_customercode = row.Cells[7].Value.ToString().Trim();

                    Bill bill = new Bill(
                            bill_detailcode,
                            bill_code,
                            bill_datefounded,
                            bill_staffcode,
                            bill_customercode,
                            bill_procode,
                            bill_amount,
                            bill_totalprice
                        );

                    new Action_TransactionTool(bill).ShowDialog();
                    Load_Bill();
                }
                
            }

        }
        private void bDel_Bill_Click(object sender, EventArgs e)
        {
            if (dgBill.SelectedCells.Count > 0)
            {
                int index = dgBill.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgBill.Rows[index];

                if (index < dgBill.Rows.Count - 1)
                {
                    string bill_code = row.Cells[1].Value.ToString().Trim();

                    new Bill_BLL().Delete_Bill(bill_code);
                    Load_Bill();
                }

            }
        }

        /* HANDLE ACTION OF TRANSACTION TOOL FOR CUSTOMER PAGE */
        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
            => Load_Card_Customer(e.RowIndex > -1 ? e.RowIndex : 0);
        private void bEdit_Cus_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedCells.Count > 0)
            {
                int index = dgCustomer.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgCustomer.Rows[index];

                if (index < dgCustomer.Rows.Count - 1)
                {
                    string cus_code = row.Cells[0].Value.ToString().Trim();
                    string cus_name = row.Cells[1].Value.ToString().Trim();
                    string cus_phone = row.Cells[2].Value.ToString().Trim();
                    string cus_email = row.Cells[3].Value.ToString().Trim();
                    string cus_adress = row.Cells[4].Value.ToString().Trim();

                    Customer cus = new Customer(cus_code, cus_name, cus_phone, cus_email, cus_adress);

                    new Action_TransactionTool(cus).ShowDialog();
                    Load_Customer();
                }

            }
        }
        private void bStatistic_Cus_Click(object sender, EventArgs e)
        {
            string staff_name = new Staff_BLL().Get_Staff(account.Staff_code).Rows[0][1].ToString().Trim();
            new Report_Customer(staff_name).ShowDialog();
        }

    }
}
