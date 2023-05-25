using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Customer_Access : DB_Access
    {
        public DataTable Get_Customer_DAL(string conditions) => Get_Object_DAS("KHACH_HANG", conditions);
        public DataTable GetList_Customer_DAL() => Get_Table_DAS("KHACH_HANG", "MA_KH ASC");
        public bool Check_Exists_Customer_DAL(string code) => Check_Exists_DAS("KHACH_HANG", "MA_KH", code);
        public void Insert_Cus_DAL(Customer cus) => Insert_Cus_DAS(cus);
        public void Update_Cus_DAL(Customer cus) => Update_Cus_DAS(cus);
        public void Delete_Cus_DAL(string code) => Delete_DAS("KHACH_HANG", "MA_KH", code);
    }
}
