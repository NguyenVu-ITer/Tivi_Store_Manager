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
    public partial class Action_StoreTool : Form
    {
        /* DECLARE VARIABLES */
        string type_act = null;
        string object_act = null;
        Product pro_act = null;
        Supplier sup_act = null;
        DataTable supplier_tb = null;

        /* FORM CONSTRUCTOR */
        public Action_StoreTool(string type, string obj)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
        }
        public Action_StoreTool(string type, string obj, Product pro)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
            pro_act = pro;
        }
        public Action_StoreTool(string type, string obj, Supplier sup)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            type_act = type;
            object_act = obj;
            sup_act = sup;
        }

        private void Loader()
        {
            switch (object_act)
            {
                case "product":
                    panel_Pro.Visible = true;
                    panel_Sup.Visible = false;
                    panel_Pro.Location = panel_anchor.Location;

                    supplier_tb = new Supplier_BLL().GetList_Supplier();

                    switch (type_act)
                    {
                        case "add":
                            LoadForm_Add_Product();
                            break;
                        case "update":
                            LoadForm_Update_Product();
                            break;
                    }
                    break;

                case "supplier":
                    panel_Pro.Visible = false;
                    panel_Sup.Visible = true;
                    panel_Sup.Location = panel_anchor.Location;

                    switch (type_act)
                    {
                        case "add":
                            LoadForm_Add_Supplier();
                            break;
                        case "update":
                            LoadForm_Update_Supplier();
                            break;
                    }
                    break;
            }
        }

        /* FORM ENVENT */
        private void Action_StoreTool_Load(object sender, EventArgs e)
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
                        case "product":
                            panel_Pro.Visible = true;
                            Handle_Add_Product();
                            break;
                        case "supplier":
                            break;
                    }
                    break;

                case "update":
                    switch (object_act)
                    {
                        case "product":
                            panel_Pro.Visible = true;
                            Handle_Update_Product();
                            break;
                        case "supplier":
                            break;
                    }
                    break;
            }
        }

        /* LOAD FORM */
        private void Refresh_Form_Product(Product pro = null)
        {
            Load_ProSupplie();
            Load_ProDisplay();
            Load_ProGuarantee();
            Load_ProDebut();

            if (pro != null)
            {
                tProCode.Enabled = false;

                tProCode.Text = pro.Pro_code;
                tProName.Text = pro.Pro_name;
                tProType.Text = pro.Pro_type;
                tProSize.Text = pro.Pro_size;
                tProWeight.Text = pro.Pro_weight + "";
                tProPrice.Text = pro.Pro_price + "";
                tProOrigin.Text = pro.Pro_origin;
                tProInventory.Value = pro.Pro_inventory;

                Load_ProComboboxFiled(pro);
            }
            else 
            {
                tProCode.Text = "PR" + new Random().Next(1000, 9999);
                tProName.Text = tProType.Text = tProSize.Text = string.Empty;
                tProWeight.Text = tProPrice.Text = tProOrigin.Text = string.Empty;
                tProInventory.Value = 0;

                cbProSupplier.SelectedIndex = 0;
                cbProDisplay.SelectedIndex = 1;
                cbProGuarantee.SelectedIndex = 0;
                cbProDebut.SelectedIndex = 0;
            }

            tProName.Focus();

        }
        private void Refresh_Form_Supplier(Supplier sup = null)
        {

            if (sup != null)
            {
                tSupCode.Enabled = false;

                tSupCode.Text = sup.Sup_code;
                tSupName.Text = sup.Sup_name;
                tSupPhone.Text = sup.Sup_phone;
                tSupAdress.Text = sup.Sup_adress;
            }
            else
            {
                tSupCode.Text = "SP" + new Random().Next(1000, 9999);
                tSupName.Text = tSupPhone.Text = tSupAdress.Text = string.Empty;
            }

            tSupName.Focus();

        }
        private void Load_ProSupplie()
        {
            for (int i = 0; i < supplier_tb.Rows.Count; i++)
            {
                cbProSupplier.Items.Add(supplier_tb.Rows[i][1].ToString());
            }
        }
        private void Load_ProDisplay()
        {
            cbProDisplay.Items.Add("8K");
            cbProDisplay.Items.Add("Ultra HD (4K)");
            cbProDisplay.Items.Add("Quad HD (2K)");
            cbProDisplay.Items.Add("Full HD");
            cbProDisplay.Items.Add("HD");
        }
        private void Load_ProGuarantee()
        {
            cbProGuarantee.Items.Add("6 Tháng (nữa năm)");
            cbProGuarantee.Items.Add("12 Tháng (1 năm)");
            cbProGuarantee.Items.Add("18 Tháng (1 năm rữi)");
            cbProGuarantee.Items.Add("24 Tháng (2 năm)");
            cbProGuarantee.Items.Add("36 Tháng (3 năm)");
            cbProGuarantee.Items.Add("Trọn đời");
        }
        private void Load_ProDebut()
        {
            for (int i = DateTime.Now.Year; i >= 2015 ; i--)
            {
                cbProDebut.Items.Add(i.ToString());
            }
        }
        private void Load_ProComboboxFiled(Product pro)
        {
            for (int i = 0; i < supplier_tb.Rows.Count; i++)
            {
                if (pro.Pro_suppcode == supplier_tb.Rows[i][0].ToString())
                {
                    cbProSupplier.Text = supplier_tb.Rows[i][1].ToString();
                    break;
                }
            }
            
            cbProDisplay.Text = pro.Pro_display;
            cbProGuarantee.Text = pro.Pro_guarantee;
            cbProDebut.Text = pro.Pro_yearDebut + "";

        }
        private void LoadForm_Add_Product()
        {
            lbTitle.Text = "THÊM SẢN PHẨM";

            Refresh_Form_Product();
        }
        private void LoadForm_Add_Supplier()
        {
            lbTitle.Text = "THÊM NHÀ CUNG CẤP";

            Refresh_Form_Supplier();
        }
        private void LoadForm_Update_Product()
        {
            lbTitle.Text = "CẬP NHẬT SẢN PHẨM";

            Refresh_Form_Product(pro_act);
        }
        private void LoadForm_Update_Supplier()
        {
            lbTitle.Text = "CẬP NHẬT THÔNG TIN NHÀ CUNG CẤP";

            Refresh_Form_Supplier(sup_act);
        }
        /* HANDLE CHECK */
        private bool Check_Empty_Form()
        {
            switch (object_act)
            {
                case "product":
                    if (tProCode.Text.Trim() == String.Empty || tProName.Text.Trim() == String.Empty ||
                        tProType.Text.Trim() == String.Empty || tProSize.Text.Trim() == String.Empty ||
                        tProWeight.Text.Trim() == String.Empty || tProPrice.Text.Trim() == String.Empty ||
                        tProWeight.Text.Trim() == String.Empty || tProPrice.Text.Trim() == String.Empty ||
                        tProOrigin.Text.Trim() == String.Empty || tProInventory.Value == 0 ||
                        cbProSupplier.Text.Trim() == String.Empty || cbProDisplay.Text.Trim() == String.Empty ||
                        cbProGuarantee.Text.Trim() == String.Empty || cbProDebut.Text.Trim() == String.Empty)
                        return true;
                    break;
                case "supplier":
                    if (tSupCode.Text.Trim() == String.Empty || tSupName.Text.Trim() == String.Empty ||
                        tSupPhone.Text.Trim() == String.Empty || tSupAdress.Text.Trim() == String.Empty)
                        return true;
                    break;
            }
            return false;
        }

        /* HANDLE ADD */
        private void Handle_Add_Product()
        {
            if (!Check_Empty_Form())
            {
                if (new Product_BLL().Check_Exists_Product(tProCode.Text.Trim()))
                {
                    if (MessageBox.Show(tProCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tProCode.Text = "PR" + new Random().Next(1000, 9999);
                    }
                }
                else
                {
                    string supplier_code = new Supplier_BLL().Get_Supplier("TEN_NCC LIKE N'" + cbProSupplier.Text.Trim() + "'")
                        .Rows[0][0].ToString().Trim();

                    new Product_BLL().Insert_Product(new Product(
                        tProCode.Text.Trim(),
                        tProName.Text.Trim(),
                        tProType.Text.Trim(),
                        int.Parse(cbProDebut.Text.Trim()),
                        cbProGuarantee.Text.Trim(),
                        tProSize.Text.Trim(),
                        float.Parse(tProWeight.Text.Trim()),
                        cbProDisplay.Text.Trim(),
                        int.Parse(tProPrice.Text.Trim()),
                        tProOrigin.Text.Trim(),
                        supplier_code,
                        int.Parse(tProInventory.Value.ToString())
                    ));
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
        private void Handle_Add_Supplier()
        {
            if (!Check_Empty_Form())
            {
                if (new Supplier_BLL().Check_Exists_Supplier(tSupCode.Text.Trim()))
                {
                    if (MessageBox.Show(tProCode.Text.Trim() + " đã tồn tại, Nhấn \"Yes\" để tạo mã mới", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tProCode.Text = "SP" + new Random().Next(1000, 9999);
                    }
                }
                else
                {
                    new Supplier_BLL().Insert_Supplier(new Supplier(
                        tSupCode.Text.Trim(),
                        tSupName.Text.Trim(),
                        tSupPhone.Text.Trim(),
                        tSupAdress.Text.Trim()
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
        private void Handle_Update_Product()
        {
            if (!Check_Empty_Form())
            {
                if (new Product_BLL().Check_Exists_Product(tProCode.Text.Trim()))
                {
                    string supplier_code = new Supplier_BLL().Get_Supplier("TEN_NCC LIKE N'" + cbProSupplier.Text.Trim() + "'")
                        .Rows[0][0].ToString().Trim();

                    new Product_BLL().Update_Product(new Product(
                        tProCode.Text.Trim(),
                        tProName.Text.Trim(),
                        tProType.Text.Trim(),
                        int.Parse(cbProDebut.Text.Trim()),
                        cbProGuarantee.Text.Trim(),
                        tProSize.Text.Trim(),
                        float.Parse(tProWeight.Text.Trim()),
                        cbProDisplay.Text.Trim(),
                        int.Parse(tProPrice.Text.Trim()),
                        tProOrigin.Text.Trim(),
                        supplier_code,
                        int.Parse(tProInventory.Value.ToString())
                    ));
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
        private void Handle_Update_Supplier()
        {
            if (!Check_Empty_Form())
            {
                if (new Supplier_BLL().Check_Exists_Supplier(tSupCode.Text.Trim()))
                {
                    new Supplier_BLL().Update_Supplier(new Supplier(
                        tSupCode.Text.Trim(),
                        tSupName.Text.Trim(),
                        tSupPhone.Text.Trim(),
                        tSupAdress.Text.Trim()
                    ));
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
        }
    }
}
