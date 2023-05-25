using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DB_Connect
    {
        public static string server_name = "LAPTOP-QIHU78TD";
        public static string db_name = "QLCH_TIVI";

        public static SqlConnection Connect()
            => new SqlConnection(@"Data Source="+ server_name +
                ";Initial Catalog=" + db_name + ";Integrated Security=True");
    }

    public class DB_Access
    {

        /* ### DB -> CONNECT ##################################################### */ // -> OK
        public static SqlConnection conn = DB_Connect.Connect();

        /* ### DB -> COMMON ###################################################### */ // -> OK
        public static Account Checklogin_DAS(string uname, string upass)
        {
            Account account = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_LOGIN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@upass", upass);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    account = new Account(
                        reader.GetString(0).Trim(),
                        reader.GetString(1).Trim(),
                        reader.GetString(2).Trim(),
                        reader.GetString(3).Trim(),
                        reader.GetInt32(6)
                    );
                }
                reader.Close();
                conn.Close();
            }
            return account;
        }
        public static bool Check_Exists_DAS(string table, string field, string keyword)
        {
            conn.Open();
            bool isExists = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + field + " = '" + keyword + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                isExists = true;
            }
            conn.Close();
            return isExists;
        }
        public static DataTable Get_Object_DAS(string table, string conditions)
        {
            DataTable staff = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + conditions + "", conn);
            Console.WriteLine(cmd.CommandText);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                staff = new DataTable();
                staff.Load(reader);
                reader.Close();
            }
            conn.Close();
            return staff;
        }
        public static DataTable Get_Table_DAS(string table, string sort)
        {
            DataTable acc_table = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + "", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            acc_table.Load(reader);
            acc_table.DefaultView.Sort = sort;
            conn.Close();
            return acc_table;
        }
        public static void Delete_DAS(string table, string field, string keyword)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE " + field + " = '" + keyword + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable Get_Staff_DAS(string scode)
        {
            DataTable staff = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GET_STAFF", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_NV", scode);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                staff = new DataTable();
                staff.Load(reader);
                reader.Close();
            }
            conn.Close();
            return staff;
        }

        /* ### DB -> STAFF ####################################################### */ // -> OK
        public static DataTable GetList_Staff_DAS()
        {
            DataTable staff_table = new DataTable();            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GETLIST_STAFF", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            staff_table.Load(reader);
            staff_table.DefaultView.Sort = "CAP_DO ASC";
            conn.Close();
            return staff_table;
        }
        public static void Insert_Staff_DAS(Staff staff)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_ADD_STAFF", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_NV", staff.Staff_code);
            cmd.Parameters.AddWithValue("@TEN_NV", staff.Staff_name);
            cmd.Parameters.AddWithValue("@DTHOAI", staff.Staff_phone);
            cmd.Parameters.AddWithValue("@EMAIL", staff.Staff_email);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Staff_DAS(Staff staff)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_STAFF", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_NV", staff.Staff_code);
            cmd.Parameters.AddWithValue("@TEN_NV", staff.Staff_name);
            cmd.Parameters.AddWithValue("@DTHOAI", staff.Staff_phone);
            cmd.Parameters.AddWithValue("@EMAIL", staff.Staff_email);
            cmd.Parameters.AddWithValue("@MA_CV", staff.Staff_poscode);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void SalaryUp_DAS(string scode, int sl)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NHAN_VIEN SET LUONG_CB = '"+ sl +"' WHERE MA_NV = '"+ scode +"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> POSITION #################################################### */ // -> OK
        public static void Insert_Position_DAS(Position pos)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CHUC_VU VALUES(@MA_CV, @TEN_CV, @CAP_DO, @HS_PHUCAP)", conn);
            cmd.Parameters.AddWithValue("@MA_CV", pos.Pos_code);
            cmd.Parameters.AddWithValue("@TEN_CV", pos.Pos_name);
            cmd.Parameters.AddWithValue("@CAP_DO", pos.Pos_level);
            cmd.Parameters.AddWithValue("@HS_PHUCAP", pos.Pos_scfc);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Position_DAS(Position pos)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_POS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_CV", pos.Pos_code);
            cmd.Parameters.AddWithValue("@TEN_CV", pos.Pos_name);
            cmd.Parameters.AddWithValue("@CAP_DO", pos.Pos_level);
            cmd.Parameters.AddWithValue("@HS_PHUCAP", pos.Pos_scfc);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> ACCOUNT ##################################################### */ // -> OK
        public static void Insert_Account_DAS(Account acc)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TAI_KHOAN VALUES(@MA_TK, @TEN_DN, @MK_DN, @MA_NV)", conn);
            cmd.Parameters.AddWithValue("@MA_TK", acc.Acc_code);
            cmd.Parameters.AddWithValue("@TEN_DN", acc.User_name);
            cmd.Parameters.AddWithValue("@MK_DN", acc.Password);
            cmd.Parameters.AddWithValue("@MA_NV", acc.Staff_code);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Account_DAS(Account acc)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_ACCOUNT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_TK", acc.Acc_code);
            cmd.Parameters.AddWithValue("@TEN_DN", acc.User_name);
            cmd.Parameters.AddWithValue("@MK_DN", acc.Password);
            cmd.Parameters.AddWithValue("@MA_NV", acc.Staff_code);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> PRODUCT ##################################################### */ // -> OK
        public static void Insert_Product_DAS(Product pro)
        {            
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TIVI VALUES (@MA_TV, @TEN_TV, @LOAI, @NAMRAMAT, @GOIBAOHANH, @KICHTHUOC, @KHOILUONG, @DOPHANGIAI, @DONGIA, @XUATXU, @MA_NCC, @TONKHO)", conn);
            cmd.Parameters.AddWithValue("@MA_TV", pro.Pro_code);
            cmd.Parameters.AddWithValue("@TEN_TV", pro.Pro_name);
            cmd.Parameters.AddWithValue("@LOAI", pro.Pro_type);
            cmd.Parameters.AddWithValue("@NAMRAMAT", pro.Pro_yearDebut);
            cmd.Parameters.AddWithValue("@GOIBAOHANH", pro.Pro_guarantee);
            cmd.Parameters.AddWithValue("@KICHTHUOC", pro.Pro_size);
            cmd.Parameters.AddWithValue("@KHOILUONG", pro.Pro_weight);
            cmd.Parameters.AddWithValue("@DOPHANGIAI", pro.Pro_display);
            cmd.Parameters.AddWithValue("@DONGIA", pro.Pro_price);
            cmd.Parameters.AddWithValue("@XUATXU", pro.Pro_origin);
            cmd.Parameters.AddWithValue("@MA_NCC", pro.Pro_suppcode);
            cmd.Parameters.AddWithValue("@TONKHO", pro.Pro_inventory);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Product_DAS(Product pro)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_PRODUCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_TV", pro.Pro_code);
            cmd.Parameters.AddWithValue("@TEN_TV", pro.Pro_name);
            cmd.Parameters.AddWithValue("@LOAI", pro.Pro_type);
            cmd.Parameters.AddWithValue("@NAMRAMAT", pro.Pro_yearDebut);
            cmd.Parameters.AddWithValue("@GOIBAOHANH", pro.Pro_guarantee);
            cmd.Parameters.AddWithValue("@KICHTHUOC", pro.Pro_size);
            cmd.Parameters.AddWithValue("@KHOILUONG", pro.Pro_weight);
            cmd.Parameters.AddWithValue("@DOPHANGIAI", pro.Pro_display);
            cmd.Parameters.AddWithValue("@DONGIA", pro.Pro_price);
            cmd.Parameters.AddWithValue("@XUATXU", pro.Pro_origin);
            cmd.Parameters.AddWithValue("@MA_NCC", pro.Pro_suppcode);
            cmd.Parameters.AddWithValue("@TONKHO", pro.Pro_inventory);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Product_Inventory_DAS(string code, int amount)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TIVI SET TONKHO = '" + amount + "' WHERE MA_TV = '" + code + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> SUPPLIER #################################################### */ // -> OK
        public static void Insert_Supplier_DAS(Supplier sup)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO NHA_CUNG_CAP VALUES(@MA_NCC, @TEN_NCC, @DTHOAI, @DIACHI)", conn);
            cmd.Parameters.AddWithValue("@MA_NCC", sup.Sup_code);
            cmd.Parameters.AddWithValue("@TEN_NCC", sup.Sup_name);
            cmd.Parameters.AddWithValue("@DTHOAI", sup.Sup_phone);
            cmd.Parameters.AddWithValue("@DIACHI", sup.Sup_adress);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Supplier_DAS(Supplier sup)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE NHA_CUNG_CAP SET (TEN_NCC = @TEN_NCC, DTHOAI = @DTHOAI,  DIACHI = @DIACHI) WHERE MA_NCC = @MA_NCC", conn);
            cmd.Parameters.AddWithValue("@MA_NCC", sup.Sup_code);
            cmd.Parameters.AddWithValue("@TEN_NCC", sup.Sup_name);
            cmd.Parameters.AddWithValue("@DTHOAI", sup.Sup_phone);
            cmd.Parameters.AddWithValue("@DIACHI", sup.Sup_adress);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> BILL ######################################################## */ // -> OK
        public static DataTable GetList_Bill_DAS()
        {
            DataTable bill_table = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GETLIST_BILL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            bill_table.Load(reader);
            bill_table.DefaultView.Sort = "NGAY_LAP DESC";
            conn.Close();
            return bill_table;
        }
        public static void Alter_Bill_DAS(Bill bill, string type = "add")
        { 

            string SP_Name = "SP_INSERT_BILL";

            if (type == "update")
            {
                SP_Name = "SP_UPDATE_BILL";
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand(SP_Name, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MA_HD", bill.Bill_code);
            cmd.Parameters.AddWithValue("@MA_NV", bill.Bill_staffcode);
            cmd.Parameters.AddWithValue("@MA_KH", bill.Bill_customercode);
            cmd.Parameters.AddWithValue("@MA_CTHD", bill.Bill_detailcode);
            cmd.Parameters.AddWithValue("@NGAY_LAP", DateTime.Parse(bill.Bill_datefounded));
            cmd.Parameters.AddWithValue("@MA_TV", bill.Bill_procode);
            cmd.Parameters.AddWithValue("@SOLUONG", bill.Bill_amount);
            cmd.Parameters.AddWithValue("@THANHTIEN", bill.Bill_totalprice);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /* ### DB -> CUS ######################################################## */ // -> OK
        public static void Insert_Cus_DAS(Customer cus)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO KHACH_HANG VALUES(@MA_KH, @TEN_KH, @DTHOAI, @EMAIL, @DIACHI)", conn);
            cmd.Parameters.AddWithValue("@MA_KH", cus.Cus_code);
            cmd.Parameters.AddWithValue("@TEN_KH", cus.Cus_name);
            cmd.Parameters.AddWithValue("@DTHOAI", cus.Cus_phone);
            cmd.Parameters.AddWithValue("@EMAIL", cus.Cus_email);
            cmd.Parameters.AddWithValue("@DIACHI", cus.Cus_address);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Cus_DAS(Customer cus)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE KHACH_HANG SET (TEN_KH = @TEN_KH, DTHOAI = @DTHOAI,  EMAIL = @EMAIL, DIACHI = @DIACHI) WHERE MA_KH = @MA_KH", conn);
            cmd.Parameters.AddWithValue("@MA_KH", cus.Cus_code);
            cmd.Parameters.AddWithValue("@TEN_KH", cus.Cus_name);
            cmd.Parameters.AddWithValue("@DTHOAI", cus.Cus_phone);
            cmd.Parameters.AddWithValue("@EMAIL", cus.Cus_email);
            cmd.Parameters.AddWithValue("@DIACHI", cus.Cus_address);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }
}
